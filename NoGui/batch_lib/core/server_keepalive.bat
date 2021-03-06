@echo off
setlocal ENABLEDELAYEDEXPANSION
set criticalconfigerror=1
call :doSanityCheck
cd "%armapath%"

call :FUNC TIMESTR GetTimeStr
call :FUNC NOVAR BatchLogWrite 1__KEEPALIVE__INITIALIZE__Starting_v1.2.2_Gui
set DEBUG_FLAG=0
set /a auto_timeout=%auto_timeout_length%
set /a manual_timeout=%manual_timeout_length%
set /a last_auto_index=0
set /a last_manual_index=0
set /a last_started=0
if exist "batch_lib/wrkdir/laststarted.txt" (
	set /p last_started=<batch_lib/wrkdir/laststarted.txt
	set /a last_started=%last_started%
)
set /a lastdb_backupunix=0
set /a db_backup_interval_sec=%db_backup_interval% * 60
set /a keepalive_count=0
set /a auto_counter=0
set /a manual_counter=0
set /a keptAlive=0
set /a eventCount=0
set /a checkTimeout=1
set /a lastmanual=0
set /a lastmanualraw=0
set forcedbsave=0
set firstloop=1
set redis_down=0
set db_backup_started=0
set db_copy_started=0
set manual_stopped=false
set in_auto_routine=false
set in_manual_routine=false
set SERVER_CRASHED=false
set current_message=Waiting for timer to check server status...
call :FUNC UNIX_TIME GetUnixTime
set quicklasttime=%UNIX_TIME%
set lastdb_backuptime=No backups since this particular runtime
call :draw_display
goto :doloop
					
:reset_timer
set /a checkTimeout=5
goto :EOF

:draw_display
cls
echo ===========================================             %TIMESTR:@= @ %

echo    Server Keepalive 1.2.2.1 by Uniflare (AKA) Chemical Bliss
echo.
echo    Armapath: %armapath%
echo.
echo    Check Number: %keepalive_count%
echo    Checking in %checkTimeout% Seconds
echo.   
echo    Last Database Backup: %lastdb_backuptime:@= @ %
echo.   
echo    Status: !current_message!
echo ===============================================================================
echo Server events: %eventCount%
echo.
if "%eventCount%" LEQ "0" goto :EOF

SET /a i=1
rem show restarts - may fail over 500+ items, need to trim or overwrite maybe?
:mloop
if %i% GTR %eventCount% goto :EOF
echo [%i%]!restartDates[%i%]!
SET /a i=%i%+1
goto mloop
goto :EOF

:doloop
set autoLogMessage=
set manualLogMessage=
set noUnknownAction=false
call :FUNC datetimestr_cur getTimeStr
set %in_auto_routine%=%in_auto_routine%
set %in_manual_routine%=%in_manual_routine%
call :FUNC TIMESTR getTimeStr
set UNIX_TIME_CUR=
call :FUNC UNIX_TIME_CUR GetUnixTime
@echo %UNIX_TIME_CUR%>"%armapath%\batch_lib\wrkdir\heartbeat.txt"
set /p quitflag=<"%armapath%\batch_lib\wrkdir\stopkeepalive.txt"
if "%quitflag%"=="keepalivequit" exit

if exist "%armapath%\batch_lib\wrkdir\lastauto.txt" (
	set /p lastauto=<batch_lib\wrkdir\lastauto.txt
	set /a lastauto=!lastauto!
	set /a lastauto=!lastauto!+%auto_timeout%
	set foundIfMatch=false
	if !lastauto! GEQ %UNIX_TIME% set foundIfMatch=true
	if "%in_auto_routine%"=="true" (
		set /a auto_counter=%auto_counter%+1
		set serverStoppedT=false
		if !auto_counter!==%auto_timeout% (
			call "batch_lib\lib\stop_all.bat"
			set autoLogMessage=TIMEOUT_FORCE_START
			set restartDates[%last_auto_index%]=!restartDates[%last_auto_index%]! :: TIMEOUT [!auto_counter!s]
			set serverStoppedT=true
		) else (
		
			call :FUNC isRunning serverIsRunning
			if "!isRunning!"=="false" (
				set /a checkTimeout=0
				set autoLogMessage=GRACEFUL_START_[!auto_counter!]s
				set restartDates[%last_auto_index%]=!restartDates[%last_auto_index%]! :: GRACEFUL [!auto_counter!s]
				set serverStoppedT=true
			)
		)
		if !serverStoppedT!==true (
			call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__AUTO_RESTART__WAITING_%auto_restart_delay%_SECONDS
			set current_message=Waiting %auto_restart_delay% seconds as per auto_restart_delay config...
			call :draw_display
			call :FUNC sleeprtn sleep %auto_restart_delay%
		)
		set foundIfMatch=false
	)
	if "!foundIfMatch!" == "true" (
		set /a auto_counter=1
		set in_manual_routine=false
		call :autoEvent & call :draw_display
	)
	rem load time
)

if exist "%armapath%\batch_lib\wrkdir\lastmanual.txt" (
	set /p thismanualraw=<batch_lib\wrkdir\lastmanual.txt
	set /a lastmanual=!thismanualraw!
	set /a lastmanual=!lastmanual!+%manual_timeout%
	set foundIfMatch=false
	if !lastmanual! GEQ %UNIX_TIME% set foundIfMatch=true
	if "!in_manual_routine!"=="true" (
		
		set /a manual_counter=!manual_counter!+1
		set manualLogMessage=TIMEOUT_FORCE_START_[!manual_counter!]
		set foundIfMatch=false
		if "!thismanualraw!"=="0" (
			set checkTimeout=0
			set manualLogMessage=USERACTION_STARTED_[!manual_counter!]
			set restartDates[%last_manual_index%]=!restartDates[%last_manual_index%]! :: USER ACTION [!manual_counter!s]
			set noUnknownAction=true
			
		) else (
			
			if not "!lastmanualraw!"=="!thismanualraw!" (
				set manualLogMessage=USERACTION_MANUALRESET_[!manual_counter!]
				set restartDates[%last_manual_index%]=!restartDates[%last_manual_index%]! :: TIMER RESET [!manual_counter!s]
				set foundIfMatch=true
			)
		)

		call :FUNC isRunning serverIsRunning
		if "!isRunning!"=="false" (
			if "%manual_stopped%"=="false" (
				set manual_stopped=true
			)
		) else (
			if "%manual_stopped%"=="true" (
				if "!noUnknownAction!" == "false" (
					set checkTimeout=0
					set manualLogMessage=UNKNOWN_ACTION_STARTED_[!manual_counter!]
					set restartDates[%last_manual_index%]=!restartDates[%last_manual_index%]! :: UNKNOWN ACTION [!manual_counter!s]
					set foundIfMatch=false
					set noUnknownAction=true
				)
			)
		)
	)
	if "!foundIfMatch!"=="true" (
		if "!in_auto_routine!"=="true" (
			set restartDates[%last_auto_index%]=!restartDates[%last_auto_index%]! :: MANUAL INTERRUPT [!auto_counter!s]
			set in_auto_routine=false
		)
		set /a manual_counter=1
		call :manualEvent & call :draw_display
	)
	set /a lastmanualraw=!thismanualraw!
)

REM // DATABASE BACKUP
if exist "%databasefile%" (
	if "!in_manual_routine!"=="false" (
		if "!in_auto_routine!"=="false" (
			if %forcedbsave%==1 (
				set lastdb_backupunix=0
			) else (
				if exist "%armapath%\batch_lib\wrkdir\lastdb_backup.txt" (
					set /p lastdb_backupunix=<"%armapath%\batch_lib\wrkdir\lastdb_backup.txt"
				) else (
					set lastdb_backupunix=0
				)
			)
			set /a nextdb_backupunix=!lastdb_backupunix! + %db_backup_interval_sec%
			
			if %UNIX_TIME% GEQ !nextdb_backupunix! (
				
				set do_raw_backup=0
				set backedupBytes=0
				
				if %use_zip_backups%==1 (
				
					if exist "%databasebackupfolder%\%datetimestr_last%.7z" (
						call :FUNC backedupBytes getFileSize "%databasebackupfolder%\%datetimestr_last%.7z"
						call :FUNC is7zarunning 7zaIsRunning
						if "!is7zarunning!"=="false" (
							REM // get compression ratio
							call :FUNC original_size getFileSize "%databasefile%"
							call :MATH compress_ratio !original_size! / !backedupBytes!
							set current_message=DB Backup Finished. Size: !backedupBytes! Bytes. Ratio: !compress_ratio!x
							call "%armapath%\batch_lib\lib\setlastdb.bat" %UNIX_TIME%
							set lastdb_backuptime=!datetimestr_last!
							set datetimestr_last=NULL
							set db_backup_started=0
							set forcedbsave=0
							call :FUNC NOVAR BatchLogWrite 1__KEEPALIVE__DB_BACKUP__ZIP_SUCCESS
							goto endDBbackup
						) else (
							set current_message=Database Backup Running... !backedupBytes! Bytes
						)
					) else (
						if %db_backup_started%==1 (
							set current_message=Database Backup Zip Failed! Attempting Raw Backup - No Compression
							call :FUNC NOVAR BatchLogWrite 1__KEEPALIVE__DB_BACKUP__ZIP_FAILED
							set do_raw_backup=1
						) else (
							mkdir "%databasebackupfolder%" >nul 2>&1
							start /B "" "%armapath%\batch_lib\external\7za" a -t7z "%databasebackupfolder%\%datetimestr_cur%.7z" "%databasefile%" -ms >nul
							set datetimestr_last=%datetimestr_cur%
							set old_message=%current_message%
							set current_message=Database Backup Started... 0 Bytes
							set db_backup_started=1
						)
					)
				) else (
					set do_raw_backup=1
				)
				
				if !do_raw_backup!==1 (
					REM //
					if exist "%databasebackupfolder%\%datetimestr_last%\%databasefile_name%" (
						// REM Copying
						call :FUNC backedupBytes getFileSize "%databasebackupfolder%\%datetimestr_last%\%databasefile_name%"
						if "!backedupBytes!"=="%db_size_raw%" (
							REM // Finished
							set current_message=DB Backup Finished. Size: !backedupBytes!
							call "%armapath%\batch_lib\lib\setlastdb.bat" %UNIX_TIME%
							set lastdb_backuptime=!datetimestr_last!
							set datetimestr_last=NULL
							set db_copy_started=0
							call :FUNC NOVAR BatchLogWrite 1__KEEPALIVE__DB_BACKUP__RAW_SUCCESS
							set forcedbsave=0
							goto endDBbackup
						) else (
							REM // Running
							set current_message=Database Backup Running - raw... !backedupBytes! Bytes
						)
					) else (
						if %db_copy_started%==1 (
							// REM Not Copying?? Error
							set current_message=Error! Database Backup Failed!
							call :DbBackupErrorEvent & call :draw_display
							set datetimestr_last=NULL
							set db_copy_started=0
							call "%armapath%\batch_lib\lib\setlastdb.bat" %UNIX_TIME%
							call :FUNC NOVAR BatchLogWrite 1__KEEPALIVE__DB_BACKUP__RAW_FAILED
							goto endDBbackup
							
						) else (
							// REM Start Copy
							mkdir "%databasebackupfolder%\%datetimestr_cur%" >nul 2>&1
							set datetimestr_last=%datetimestr_cur%
							call :FUNC db_size_raw getFileSize "%databasefile%"
							start /B "" "%armapath%\batch_lib\lib\db_copy_raw.bat" "%databasebackupfolder%\%datetimestr_cur%" >nul
							set db_copy_started=1
						)
					)
				)
			) else (
				REM // Wait to backup
				echo waiting
			)
			
		)
	)
) else (
	set current_message=No Database Dump Found. Skipping... No Database Backup Performed
)
:endDBbackup


call :draw_display
set /a checkTimeout=checkTimeout-1
call :FUNC sleeprtn sleep 1
if %checkTimeout% LEQ 0 goto server_check

goto :doloop
REM // Check CProcess Crash Loop
:mloop_cproc_crashed
set i=0
set maxcproc=99
:mloop_cproc_main
if !keepalive_cusproc[%i%]!==1 (
	set crashval=false
	call :FUNC crashval processHasCrashed !cusproc_filename[%i%]!
	if !crashval!==true (
		set "%1=true"
		set "%2=%i%"
		set "%3=!cusproc_filename[%i%]!"
		goto :EOF
	)
	set /a i=%i%+1
	if i==99 goto :EOF
	goto :mloop_cproc_main
)
goto :EOF

:server_check
set current_message=Checking if server processes are running...
call :draw_display

REM // CRASH CHECK
call :FUNC UNIX_TIME GetUnixTime
set SERVER_CRASHED=false
set HC_CRASHED=false
set DB_CRASHED=false
set BEC_CRASHED=false
set TS_CRASHED=false
set ASM_CRASHED=false
set CPROC_CRASHED=false
set CPROCID=
set CPROCFN=
set crashed=0

if exist "batch_lib\wrkdir\laststarted.txt" (
	set /p last_started=<batch_lib\wrkdir\laststarted.txt
	set /a last_started=!last_started!
	set /a timetocheck=!last_started!+%serverStartTimeout%
	
	if !UNIX_TIME! GTR !timetocheck! (
		call :FUNC SERVER_CRASHED processHasCrashed %armaserverexe%
		call :FUNC HC_CRASHED processHasCrashed %hcexename%
		call :FUNC DB_CRASHED processHasCrashed %redisexename%
		call :FUNC BEC_CRASHED processHasCrashed %becexename%
		call :FUNC TS_CRASHED processHasCrashed %teamspeakfilename%
		call :FUNC ASM_CRASHED processHasCrashed %asmexename%
		call :mloop_cproc_crashed CPROC_CRASHED CPROCID CPROCFN
		
		if !SERVER_CRASHED!==true (
			REM // Make Sure (wait a second)
			call :FUNC sleeprtn sleep 2
			call :FUNC SERVER_CRASHED processHasCrashed %armaserverexe%
			if !SERVER_CRASHED!==true (
				set crashed=1
				call :serverCrashEvent & call :draw_display
				call :FUNC RETURNVAR stop %armaserverexe% force
			)
		)
		if %keepalive_bec%==1 (
			if !crashed!==0 (
				if !BEC_CRASHED!==true (
					REM // Make Sure (wait a second)
					call :FUNC sleeprtn sleep 2
					call :FUNC BEC_CRASHED processHasCrashed %becexename%
					if !BEC_CRASHED!==true (
						set crashed=1
						call :becCrashEvent & call :draw_display
						call :FUNC RETURNVAR stop %becexename% force
					)
				)
			)
		)
		if %keepalive_database%==1 (
			if !crashed!==0 (
				if !DB_CRASHED!==true (
					REM // Make Sure (wait a second)
					call :FUNC sleeprtn sleep 2
					call :FUNC DB_CRASHED processHasCrashed %redisexename%
					if !DB_CRASHED!==true (
						set crashed=1
						call :dbCrashEvent & call :draw_display
						call :FUNC RETURNVAR stop %redisexename% force
					)
				)
			)
		)
		if %keepalive_hc%==1 (
			if !crashed!==0 (
				if !HC_CRASHED!==true (
					REM // Make Sure (wait a second)
					call :FUNC sleeprtn sleep 2
					call :FUNC HC_CRASHED processHasCrashed %hcexename%
					if !HC_CRASHED!==true (
						set crashed=1
						call :hcCrashEvent & call :draw_display
						call :FUNC RETURNVAR stop %hcexename% force
					)
				)
			)
		)
		
		if %keepalive_ts%==1 (
			if !crashed!==0 (
				if !TS_CRASHED!==true (
					REM // Make Sure (wait a second)
					call :FUNC sleeprtn sleep 2
					call :FUNC TS_CRASHED processHasCrashed %teamspeakfilename%
					if !TS_CRASHED!==true (
						set crashed=1
						call :hcCrashEvent & call :draw_display
						call :FUNC RETURNVAR stop %teamspeakfilename% force
					)
				)
			)
		)
		if %keepalive_asm%==1 (
			if !crashed!==0 (
				if !ASM_CRASHED!==true (
					REM // Make Sure (wait a second)
					call :FUNC sleeprtn sleep 2
					call :FUNC ASM_CRASHED processHasCrashed %asmexename%
					if !ASM_CRASHED!==true (
						set crashed=1
						call :hcCrashEvent & call :draw_display
						call :FUNC RETURNVAR stop %asmexename% force
					)
				)
			)
		)
		
		if !CPROC_CRASHED!==true (
			if !crashed!==0 (
				REM // Make Sure (wait a second)
				call :FUNC sleeprtn sleep 2
				set CPROC_CRASHED=false
				call :FUNC CPROC_CRASHED processHasCrashed !CPROCFN!
				set fname_t=!CPROCFN!
				if !CPROC_CRASHED!==true (
					set crashed=1
					call :CProcCrashEvent !CPROCID! & call :draw_display
					call :FUNC RETURNVAR stop !CPROCFN! force
				)
			)
		)
		
		if !crashed!==1 (
			if "%cleanWerDialogs%"=="1" (
				call :FUNC RETURNVAR stop werfault.exe force
			)
		)
	)
)


set /a checkTimeout=0
set redis_down=0
set /a keepalive_count=%keepalive_count%+1
call :draw_display
call :reset_timer

REM EVENT HOOK - custom/event_BeforeServerCheck.bat
call "batch_lib/custom/event_BeforeServerCheck.bat"

:Stage1
REM CHECK IF DATABASE IS ACTIVE FIRST/ALWAYS
if "%keepalive_database%"=="0" goto :Stage2

if %ProcPathCheck%==1 (
	set ACTIVE=false
	call :FUNC2 ACTIVE processIsRunning "!redisexename!" "!redispath:"=!"
	if !ACTIVE!==true goto :Stage2
) else (
	tasklist /FI "IMAGENAME eq %redisexename%" 2>NUL | find /I /N "%redisexename%">NUL
	if "!ERRORLEVEL!"=="0" goto Stage2
)
if %firstloop%==0 call :RedisInactiveEvent & call :draw_display
if %firstloop%==0 call "batch_lib\lib\stop_all.bat"
call "batch_lib/lib/start_redis.bat" & set taskresult=SUCCESS || set taskresult=FAILURE
call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__START_REDIS_DB__%taskresult%
set forcedbsave=1
set redis_down=1

:Stage2
if "%keepalive_asm%"=="1" (
	REM CHECK IF SERVER MONITOR (ASM) IS ACTIVE
	if %ProcPathCheck%==1 (
		set ACTIVE=false
		call :FUNC2 ACTIVE processIsRunning "!asmexename!" "!asmpath:"=!"
		if !ACTIVE!==true goto :Stage3
	) else (
		tasklist /FI "IMAGENAME eq %asmexename%" 2>NUL | find /I /N "%asmexename%">NUL
		if "!ERRORLEVEL!"=="0"  goto Stage3
	)
	if %firstloop%==0 call :MonitorInactiveEvent & call :draw_display
	call "batch_lib/lib/start_asm.bat" & set taskresult=SUCCESS || set taskresult=FAILURE
	call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__START_ASM__%taskresult%
)

:Stage3
if "%keepalive_ts%"=="1" (
	REM CHECK IF TEAMSPEAK IS ACTIVE
	if %ProcPathCheck%==1 (
		set ACTIVE=false
		call :FUNC2 ACTIVE processIsRunning "!teamspeakfilename!" "!teamspeakpath:"=!"
		if !ACTIVE!==true goto :Stage4
	) else (
		tasklist /FI "IMAGENAME eq %teamspeakfilename%" 2>NUL | find /I /N "%teamspeakfilename%">NUL
		if "!ERRORLEVEL!"=="0"  goto Stage4
	)
	if %firstloop%==0 call :TeamspeakInactiveEvent & call :draw_display
	call "batch_lib/lib/start_teamspeak.bat" & set taskresult=SUCCESS || set taskresult=FAILURE
	call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__START_TEAMSPEAK__%taskresult%
)

:Stage4
if "%keepalive_hc%"=="1" (
	REM CHECK IF Headless Client IS ACTIVE
	if %ProcPathCheck%==1 (
		set ACTIVE=false
		call :FUNC2 ACTIVE processIsRunning "!hcexename!" "!hcarmapath:"=!"
		if !ACTIVE!==true goto :Stage4_2
	) else (
		tasklist /FI "IMAGENAME eq %hcexename%" 2>NUL | find /I /N "%hcexename%">NUL
		if "!ERRORLEVEL!"=="0"  goto Stage4_2
	)
	if %redis_down%==0 (
		if %in_manual_routine%==false (
			if %in_auto_routine%==false (
				if %firstloop%==0 call :HCInactiveEvent & call :draw_display
			)
		)
	)
	call "batch_lib/lib/start_hc.bat" & set taskresult=SUCCESS || set taskresult=FAILURE
	call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__START_HC__%taskresult%
)

:Stage4_2
REM // For Custom Processes, loop and check each
set i=0
set j=99
:mloop_cproc_active
if %i%==100 goto Stage5
if "!keepalive_cusproc[%i%]!"=="1" (
	if %ProcPathCheck%==1 (
		set ACTIVE=false
		call :FUNC2 ACTIVE processIsRunning "!cusproc_filename[%i%]!" "!cusproc_path[%i%]:"=!"
		if !ACTIVE!==true (
			set /a i=%i%+1
			goto :mloop_cproc_active
		)
	) else (
		tasklist /FI "IMAGENAME eq !cusproc_filename[%i%]!" 2>NUL | find /I /N "!cusproc_filename[%i%]!">NUL
		if "!ERRORLEVEL!"=="0" (
			set /a i=%i%+1
			goto :mloop_cproc_active
		)
	)
	if %firstloop%==0 call :CProcInactiveEvent %i% & call :draw_display
	call "batch_lib/lib/start_cproc.bat" %i% & set taskresult=SUCCESS || set taskresult=FAILURE
	call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__START_CPROC[%i%]__%taskresult%
)
if %i%==99 goto Stage5
set /a i=%i%+1
goto :mloop_cproc_active


:Stage5
set isRunning=false
set isBecRunning=false
if %ProcPathCheck%==1 (
	call :FUNC2 isRunning processIsRunning "!armaserverexe!" "!armapath:"=!"
) else (
	call :FUNC isRunning serverIsRunning
)

if "!isRunning!"=="true" (
	if "%in_manual_routine%"=="true" (
		if not "!thismanualraw!"=="0" (
			if "%noUnknownAction%"=="false" (
				set restartDates[%last_manual_index%]=!restartDates[%last_manual_index%]! :: UNKNOWN [%manual_counter%s]
				set manualLogMessage=TIMEOUT_UNKNOWN_START[%manual_counter%s]
			)
		)
		call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__STARTSERVER__!manualLogMessage!
		call "batch_lib/lib/setmanual.bat" clear
	) else (
		if "%keepalive_bec%"=="1" (
			if %ProcPathCheck%==1 (
				call :FUNC2 isBecRunning processIsRunning "%becexename%" "%becpath:"=%"
			) else (
				call :FUNC isBecRunning becIsRunning
			)
			if !isBecRunning!==false goto BECOnlyNotRunning
		)
	)
	goto ServerIsRunning
)



rem Double Start Fix
if exist "batch_lib\wrkdir\laststarted.txt" (
	set /p last_started=<batch_lib\wrkdir\laststarted.txt
	set /a last_started=!last_started!
	set /a last_started=!last_started!+10
)
if "!isRunning!"=="false" (

	call :FUNC UNIX_TIME GetUnixTime

	if !last_started! GTR !UNIX_TIME! (
		set /a thisdiff=!last_started!-!UNIX_TIME!
		echo Server was started recently, waiting !thisdiff! seconds before trying again.
		set /a thisdiff=!thisdiff!+1
		call :FUNC sleeprtn sleep !thisdiff!
		if %ProcPathCheck%==1 (
			call :FUNC2 isRunning processIsRunning "!armaserverexe!" "!armapath:"=!"
		) else (
			call :FUNC isRunning serverIsRunning
		)
		if "!isRunning!"=="false" goto ServerNotRunning
		goto ServerIsRunning
	) else (
		goto ServerNotRunning
	)
)

:ServerIsRunning
goto LoopAgain

:BECOnlyNotRunning
if %firstloop%==0 call :BECInactiveEvent & call :draw_display
call "batch_lib/lib/start_bec.bat" & set taskresult=SUCCESS || set taskresult=FAILURE
call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__START_BEC__%taskresult%

goto LoopAgain

:ServerNotRunning

set tempType=unknown
if %redis_down%==1 set tempType=redis
if %firstloop%==1 set tempType=firststart
if !SERVER_CRASHED!==true set tempType=crash
if !HC_CRASHED!==true set tempType=crash
if !DB_CRASHED!==true set tempType=crash
if !BEC_CRASHED!==true set tempType=crash
if !TS_CRASHED!==true set tempType=crash
if !ASM_CRASHED!==true set tempType=crash

if "%in_auto_routine%"=="true" set tempType=auto
if "%in_manual_routine%"=="true" set tempType=manual

if "%tempType%"=="unknown" call :unknownEvent & call :draw_display
if "%tempType%"=="firststart" call :firstStartEvent & call :draw_display
call "batch_lib/core/server_check.bat" & set taskresult=SUCCESS || set taskresult=FAILURE
if not "%autoLogMessage%"=="" (
	set taskresult=%autoLogMessage%
)
if not "%manualLogMessage%"=="" (
	if %manual_timeout%==true (
		set restartDates[%last_manual_index%]=!restartDates[%last_manual_index%]! :: TIMEOUT [%manual_counter%s]
	) else (
		set restartDates[%last_manual_index%]=!restartDates[%last_manual_index%]!
	)
	set taskresult=%manualLogMessage%
)
call :FUNC NOVAR BatchLogWrite 3__KEEPALIVE__STARTSERVER__%taskresult%
call "batch_lib/lib/setmanual.bat" clear
call "batch_lib/lib/setauto.bat" clear

set in_auto_routine=false
set in_manual_routine=false
goto LoopAgain

:LoopAgain
set firstloop=0
set current_message=Waiting for timer to check server status...
set manual_stopped=false
set in_auto_routine=false
set in_manual_routine=false

REM EVENT HOOK - custom/event_AfterServerStart.bat
call "batch_lib/custom/event_AfterServerStart.bat"

goto doloop

:EventDetected
set /a eventCount=%eventCount%+1
set /a newIndex=%eventCount%
if "%in_auto_routine%"=="true" set /a last_auto_index=%newIndex%
if "%in_manual_routine%"=="true" set /a last_manual_index=%newIndex%
set thisType=%1
call :FUNC NOVAR BatchLogWrite 1__KEEPALIVE__DETECTED__%thisType%
set restartDates[%newIndex%]=%DATE% @ %TIME% :: %thisType% EVENT DETECTED
goto :EOF

:autoEvent
if "%in_auto_routine%"=="false" (
	set in_auto_routine=true
	call :EventDetected AUTOMATIC
	set current_message=AUTOMATIC EVENT IN PROGRESS...
	set last_saved=%lastauto%
	set /a checkTimeout=%auto_timeout%
)
goto :EOF

:manualEvent
set in_manual_routine=true
call :EventDetected MANUAL
set current_message=MANUAL EVENT IN PROGRESS
set /a difference=!lastmanual!-%UNIX_TIME%
set /a checkTimeout=!difference!
goto :EOF

:firstStartEvent
call :EventDetected START_SERVER
set current_message=START EVENT IN PROGRESS
set /a checkTimeout=0
set firstloop=0
goto :EOF

:unknownEvent
call :EventDetected UNKNOWN
set current_message=UNKNOWN EVENT IN PROGRESS
set /a checkTimeout=0
goto :EOF

:serverCrashEvent
call :EventDetected SERVER_CRASH
set current_message=SERVER CRASH DETECTED
set /a checkTimeout=0
goto :EOF

:dbCrashEvent
call :EventDetected DATABASE_CRASH
set current_message=DATABASE CRASH DETECTED
set /a checkTimeout=0
goto :EOF

:hcCrashEvent
call :EventDetected HEADLESSCLIENT_CRASH
set current_message=HEADLESSCLIENT CRASH DETECTED
set /a checkTimeout=0
goto :EOF

:tsCrashEvent
call :EventDetected TEAMSPEAK_CRASH
set current_message=TEAMSPEAK CRASH DETECTED
set /a checkTimeout=0
goto :EOF

:asmCrashEvent
call :EventDetected ASM_CRASH
set current_message=ASM CRASH DETECTED
set /a checkTimeout=0
goto :EOF

:BECInactiveEvent
call :EventDetected BEC_NOT_ACTIVE
set current_message=BEC IS NOT RUNNING
set /a checkTimeout=0
goto :EOF

:RedisInactiveEvent
call :EventDetected REDISDB_NOT_ACTIVE
set current_message=REDIS DB SERVER IS NOT RUNNING
set /a checkTimeout=0
goto :EOF

:MonitorInactiveEvent
call :EventDetected ASM_NOT_ACTIVE
set current_message=SERVER PERFORMANCE MONITOR IS NOT ACTIVE
set /a checkTimeout=0
goto :EOF

:TeamspeakInactiveEvent
call :EventDetected TEAMSPEAK_NOT_ACTIVE
set current_message=TEAMSPEAK IS NOT ACTIVE
set /a checkTimeout=0
goto :EOF

:HCInactiveEvent
call :EventDetected HEADLESSCLIENT_NOT_ACTIVE
set current_message=HEADLESS CLIENT IS NOT ACTIVE
set /a checkTimeout=0
goto :EOF

:DbBackupErrorEvent
call :EventDetected DB_BACKUP_ERROR
set current_message=ERROR - DATABASE WASN'T BACKED UP
set /a checkTimeout=0
goto :EOF

:CProcInactiveEvent
set CProcID=%1
call :EventDetected CPROC[%CProcID%]_NOT_ACTIVE
set current_message=CUSTOM PROCESS !cusproc_name[%CProcID%]! NOT ACTIVE
set /a checkTimeout=0
goto :EOF

:CProcCrashEvent
set CProcID=%1
call :EventDetected CPROC[%CProcID%]_CRASH
set current_message=CPROC[%CProcID%] CRASH DETECTED
set /a checkTimeout=0
goto :EOF

:doSanityCheck
REM // Check files exist
set criticalconfigerror=0
if not exist "%armapath%" (
	set criticalconfigerror=1
	set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
	call :draw_display
	echo.CONFIG ERROR: Cannot find Arma server's root directory at:
	echo."%armapath%"
	echo. --- set armapath in the config file to the correct location
	echo.
	goto :EndSanity
)
if not exist "%armapath%\batch_lib" (
	set criticalconfigerror=1
	set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
	call :draw_display
	echo.CONFIG ERROR: Cannot find batch_lib folder at:
	echo."%armapath%\batch_lib"
	echo. --- Relocate this set of scripts to your arma folder! arma/batch_lib!
	echo.
	goto :EndSanity
)
if not exist "%armapath%\%armaserverexe%" (
	set criticalconfigerror=1
	set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
	call :draw_display
	echo.CONFIG ERROR: Cannot find the Arma server executable at:
	echo."%armapath%\%armaserverexe%"
	echo. --- set armaserverexe in the config file to the correct name
	echo.
	goto :EndSanity
)
if %keepalive_bec%==1 (
	if not exist "%Battleyepath%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find the path to Battleye at:
		echo."%Battleyepath%"
		echo. --- set Battleyepath in the config file to the correct location
		echo.
		goto :EndSanity
	)
	if not exist "%becpath%\%becexename%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find Battleye's Extended Control executable file at:
		echo."%becpath%\%becexename%"
		echo. --- set becpath in the config file to the correct location
		echo.
		goto :EndSanity
	)
)
if not exist "%LogPath%" (
	set criticalconfigerror=1
	set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
	call :draw_display
	echo.CONFIG ERROR: Cannot find the path to server logs at:
	echo."%LogPath%"
	echo. --- set LogPath in the config file to the correct location
	echo.
	goto :EndSanity
)
if %keepalive_database%==1 (
	if not exist "%databasefile%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find the server Database File at:
		echo."%databasefile%"
		echo. --- set databasefile in the config file to the correct location
		echo.
		goto :EndSanity
	)
	if not exist "%redispath%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find the server Database folder at:
		echo."%redispath%"
		echo. --- set redispath in the config file to the correct location
		echo.
		goto :EndSanity
	)
	if not exist "%redispath%\%redisexename%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find the server Database EXE at:
		echo."%redispath%\%redisexename%"
		echo. --- set redisexename in the config file to the correct name
		echo.
		goto :EndSanity
	)
)
if %keepalive_hc%==1 (
	if not exist "%hcarmapath%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find the Headless Client folder at:
		echo."%hcarmapath%"
		echo. --- set hcarmapath in the config file to the correct location
		echo.
		goto :EndSanity
	)
	if not exist "%hcarmapath%\%hcexename%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find -Headless Client- executable at:
		echo."%hcarmapath%\%hcexename%"
		echo. --- set hcarmapath AND hcexename in the config file correctly
		echo.
		goto :EndSanity
	)
)
if %keepalive_asm%==1 (
	if not exist "%asmpath%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find Arma Server Monitor's folder at:
		echo."%asmpath%"
		echo. --- set asmpath in the config file to the correct location
		echo.
		goto :EndSanity
	)
	if not exist "%asmpath%\%asmexename%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		
		call :draw_display
		echo.CONFIG ERROR: Cannot find -Arma Server Monitor- executable at:
		echo."%asmpath%\%asmexename%"
		echo. --- set asmpath in the config file to the correct location!
		echo.
		goto :EndSanity
	)
)
if %keepalive_ts%==1 (
	if not exist "%teamspeakpath%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find the Teamspeak Server folder at:
		echo."%teamspeakpath%"
		echo. --- set teamspeakpath in the config file to the correct location
		echo.
		goto :EndSanity
	)
	if not exist "%teamspeakpath%\%teamspeakfilename%" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find -Teamspeak Server- executable at:
		echo."%teamspeakpath%\%teamspeakfilename%"
		echo. --- set teamspeakpath AND teamspeakfilename in the config file correctly
		echo.
		goto :EndSanity
	)
)
REM // Multi HC Array Check
set maxCusProc=99
set i=0
:mloop_2
if "!keepalive_cusproc[%i%]!"=="1" (
	set returnVal=
	call :Method_CusProcSanity returnVal %i%
)
if "returnVal"=="false" goto :EndSanity
if %i%==99 goto :end_mloop2
set /a i=%i%+1
goto :mloop_2
:end_mloop2

set check7za=0
if "%use_zip_logs%"=="1" (
	set check7za==1
)
if "%use_zip_backups%"=="1" (
	set check7za=1
)
if "!check7za!"=="1" (
	if not exist "%armapath%\batch_lib\external\7za.exe" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find 7-Zip Command line tool at:
		echo."%armapath%\batch_lib\external\7za.exe"
		echo. --- make sure the file exists, if it does not you can easily google 7za.exe.
		echo.
		goto :EndSanity
	)
)

:EndSanity
if "%criticalconfigerror%"=="1" (
	pause
	exit
) else (
	goto :EOF
)

:Method_CusProcSanity
set cprocID=%2
set "%1=true"
if not exist "!cusproc_path[%cprocID%]!" (
	set criticalconfigerror=1
	set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
	call :draw_display
	echo.CONFIG ERROR: Cannot find the path to a Custom Defined Process
	echo."!cusproc_path[%cprocID%]!"
	echo. --- make sure the path exists.
	set "%1=false"
) else (
	if not exist "!cusproc_path[%cprocID%]!\!cusproc_filename[%cprocID%]!" (
		set criticalconfigerror=1
		set current_message=CRITICAL ERROR^(s^) - REVIEW BELOW
		call :draw_display
		echo.CONFIG ERROR: Cannot find the file for a Custom Defined Process
		echo."!cusproc_path[%cprocID%]!\!cusproc_filename[%cprocID%]!"
		echo. --- make sure the file exists at the specified path.
		set "%1=false"
	)
)
goto :EOF

:FUNC
set currentDir=%CD%
cd /D "%armapath%/batch_lib/gbl_func"
rem %1 = return var, %2 = function, %3 = args
set returnvarname=%1
set funcname=%2
set argString=%3
set argString2=%4
set argString=%argString:__= %
set argString=%argString:"=%
set argString=%argString:(=[%
set argString=%argString:)=]%
set args=
set args2=
set args=%argString%
if "%args%"=="__=" set args=
set filename=%funcname%.cmd
set val1=

if "%returnvarname%"=="original_size" (
	echo 1 = "%1"
	echo 2 = "%2"
	echo 3 = %3
)
if not "%argString2%"=="" set args2= "%argString2%"
for /f %%I in ('%filename% "%args%"%args2%') do (
	set "val1=%%I"
)
set "%1=%val1%"
cd /D %currentDir%
goto :EOF

:FUNC2
set currentDirF=%CD%
cd "%armapath%/batch_lib/gbl_func"
rem %1 = return var, %2 = function, %3 = args
set returnvarname=%1
set funcname=%2
set argString=%3
set argString2=%4
set argString=%argString:__= %
set argString=%argString:"=%
set argString=%argString:(=[%
set argString=%argString:)=]%
set args=
set args2=
set args=%argString%
if "%args%"=="__=" set args=
set filename=%funcname%.cmd
set val1=
if not "%argString2:"=%"=="" set args2=%argString2%

for /f %%I in ('%filename% "%args:"=%" "%args2:"=%"') do (
	set "val1=%%I"
)
set "%1=%val1%"
cd %currentDirF%
goto :EOF

:MATH
set returnvarname=%1
call "%armapath%/batch_lib/gbl_func/math_simple.cmd" %2 %3 %4
set "%1=%result%"
goto :EOF