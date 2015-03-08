@echo off
setlocal ENABLEDELAYEDEXPANSION
set originalDirectory="%CD%"
cd /D "%armapath%"
call :FUNC NOVAR BatchLogWrite 1__START.BAT__INITIALIZE__STARTING_SERVER

:StartServer
echo Server Start Initialize!

if "%1"=="bec" goto SKIP_ROUTINE
call "batch_lib/lib/setstarted.bat"
call :FUNC datetimestr_start getTimeStr

REM // 
REM // Archive all server logs into either zipped 7z archives or folders in plain text.
REM // 
:ArchiveLogs
cls

echo ===================================
echo === Archiving Database And Logs ===
echo ===================================
echo.

REM // Create a directory if none exists
mkdir "%logfilebackupfolder%" >nul 2>&1

REM // Set defaults
cd /D "%armapath%"
set deleteServerLogs=0
set deleteBELogs=0
set log_normally=1

REM // Try to archive logs using zip
if "%use_zip_logs%"=="1" (
	
	echo Saving Log Files to zip file "%logfilebackupfolder%\%datetimestr_start%.7z"
	echo.
	echo Saving "%LogPath%\*.log"
	echo Saving "%BattleyePath%\*.log"
	echo Saving "%LogPath%\*.rpt"
	echo.
	
	REM // Use a For construct to grab a result from 7za command
	set commandstr=batch_lib\external\7za.exe a -t7z "%logfilebackupfolder%\%datetimestr_start%.7z" "%LogPath%\*.rpt" -ms
	for /f %%a in ('!commandstr!') do set RESULT=%%a
	set commandstr=batch_lib\external\7za.exe a -t7z "%logfilebackupfolder%\%datetimestr_start%.7z" "%BattleyePath%\*.log" -ms
	for /f %%a in ('!commandstr!') do set RESULT=%%a
	set commandstr=batch_lib\external\7za.exe a -t7z "%logfilebackupfolder%\%datetimestr_start%.7z" "%LogPath%\*.log" -ms
	for /f %%a in ('!commandstr!') do set RESULT=%%a
	
	if exist %logfilebackupfolder%\%datetimestr_start%.7z (
		REM // Zip was created successfully
		
		REM // Log archiving was a success!
		set deleteServerLogs=1
		set deleteBELogs=1
		
		REM // Set this so we dont trigger the plain text archive
		set log_normally=0
		
		echo Log File Zip Success.
		echo.
		
		REM // Batch Log File
		call :FUNC NOVAR BatchLogWrite 1__START.BAT__LOG_ARCHIVE:ZIP__SUCCESS
		
		REM // Skip rest to delete logs
		goto DeleteArchiveLogs;
	) else (
		REM // Something went wrong with zipping the logs
		
		echo WARNING :: Zip File Failed! (Do you have 7za.exe in the batch_lib folder?)
		echo Attempting Plain Text Backup to %logfilebackupfolder%\%datetimestr_start%
		echo. 
		
		REM // Batch Log File
		call :FUNC NOVAR BatchLogWrite 1__START.BAT__LOG_ARCHIVE:ZIP__FAILED:TRYING_PLAINTEXT
		call :FUNC NOVAR BatchLogWrite 1__START.BAT__LOG_ARCHIVE:ZIP__FAILED_DEBUG:cd-%cd%:CMD-batch_lib\external\7za".-.a.-.-t7z.-.%logfilebackupfolder%\%datetimestr_start%.7z.-.%logfilebackupfolder%\%datetimestr_start%.7z.-.%LogPath%\+.log.-.%BattleyePath%\+.log.-.%LogPath%\+.rpt.-.-ms"
	)
)
REM // Use plain text log archives
if "%log_normally%"=="1" (

	set copiedLogs=SUCCESS
	set copiedBELogs=SUCCESS

	REM // Create the directories if none exist for the new log archives
	mkdir "%logfilebackupfolder%\%datetimestr_start%" >nul 2>&1
	mkdir "%logfilebackupfolder%\%datetimestr_start%\Battleye" >nul 2>&1
	
	REM // Copy the logs over
	copy "%LogPath%\*.rpt" "%logfilebackupfolder%\%datetimestr_start%" && set copiedLogs234234=SUCCESS || set copiedLogs=FAILED
	echo Copying "%LogPath%\*.rpt" to
	echo  "%logfilebackupfolder%\%datetimestr_start%" ... !copiedLogs!
	if "!copiedLogs!"=="SUCCESS" copy "%LogPath%\*.log" "%logfilebackupfolder%\%datetimestr_start%" && set copiedLogs34234=SUCCESS || set copiedLogs=FAILED
	echo Copying "%LogPath%\*.log" to 
	echo "%logfilebackupfolder%\%datetimestr_start%" ... !copiedLogs!
	if "!copiedLogs!"=="SUCCESS" copy "%Battleyepath%\*.log" "%logfilebackupfolder%\%datetimestr_start%\Battleye" && set copiedLogs234234=SUCCESS || set copiedBELogs=FAILED
	echo Copying "%BattleyePath%\*.log" to
	echo  "%logfilebackupfolder%\%datetimestr_start%\Battleye" ... !copiedLogs!
	echo. 
	
	
	echo r = !copiedLogs!
	if "!copiedLogs!"=="SUCCESS" (
		call :FUNC NOVAR BatchLogWrite 1__START.BAT__LOG_ARCHIVE:PLAINTEXT__SUCCESS
		set deleteServerLogs=1
	) else (
		call :FUNC NOVAR BatchLogWrite 1__START.BAT__LOG_ARCHIVE:PLAINTEXT__MOVE_FAILED
	)
	if "!copiedBELogs!"=="SUCCESS" (
		call :FUNC NOVAR BatchLogWrite 1__START.BAT__LOG_ARCHIVE:PLAINTEXT:BATTLEYELOGS__SUCCESS
		set deleteBELogs=1
	) else (
		call :FUNC NOVAR BatchLogWrite 1__START.BAT__LOG_ARCHIVE:PLAINTEXT:BATTLEYELOGS__MOVE_FAILED
	)
)

:DeleteArchiveLogs

REM // Delete the old logs
if "!deleteServerLogs!"=="1" (
	echo Deleting Old Server Logs...
	
	del "%LogPath%\*.rpt"
	del "%LogPath%\*.log"
)
if "!deleteBELogs!"=="1" (
	echo Deleting Old Battleye Logs...
	del "%Battleyepath%\*.log"
)
echo. 
if "!deleteServerLogs!"=="0"  (
	if "!deleteBELogs!"=="1" (
		REM // Should never happen on modern windows??
		call :FUNC NOVAR BatchLogWrite 1__START.BAT__ARCHIVE__FAILED:LOGS_NOT_ARCHIVED
	)
)

goto DISABLED_FEATURES_A2

:checkDatabaseQueries
cls
echo Executing Restart Queries
call "batch_lib/exec_sql.bat"

:DISABLED_FEATURES_A1
call :FUNC NOVAR BatchLogWrite 1__START.BAT__SQL_AUTO_SCRIPT__FEATURE_DISABLED

:checkNewConfigPBO
if %enable_pbo_updates%==1 (
	set newfile_path=%dropfolder_newpbo%\a3_epoch_server_settings.pbo
	set serverfile_path=%server_addon_folder%\a3_epoch_server_settings.pbo
	call :FUNC RETURNVAR update_server_file !serverfile_path!__!newfile_path!__a3_epoch_server_settings.pbo
	echo !RETURNVAR!
	pause
)

goto DISABLED_FEATURES_A2

:checkNewMission
cls
echo Checking for New Mission PBO
set file_newmish=%desktop_path%\DayZ_Epoch_11.Chernarus.pbo
set file_oldmish=%armapath%\MPMissions\DayZ_Epoch_11.Chernarus.pbo
set file_lastmish=%armapath%\MPMissions\DayZ_Epoch_11.Chernarus.pbo.last

echo CHECKING FOR NEW MISSION FILE
if exist "%file_newmish%" (
	echo FOUND NEW MISSION FILE
	call :FUNC NOVAR BatchLogWrite 1__START.BAT__DETECTED__NEW_MISSION
	set taskresult=NO_FILE
	if exist "%file_lastmish%" (
		del "%file_lastmish%" && set taskresult=SUCCESS || set taskresult=FAILURE	
		echo DELETING LAST MISSION FILE BACKUP %taskresult%
	)
	call :FUNC NOVAR BatchLogWrite 1__START.BAT__REMOVE:%file_lastmish: =.-.%:RESULT__!taskresult!
	
	set taskresult=NO_FILE
	if exist "%file_oldmish%" (
		rename "%file_oldmish%" DayZ_Epoch_11.Chernarus.pbo.last && set taskresult=SUCCESS || set taskresult=FAILURE
		echo BACKING UP OLD MISSION FILE %taskresult%
	)
	call :FUNC NOVAR BatchLogWrite 1__START.BAT__RENAME_TO_LAST:%file_oldmish: =.-.%:RESULT__!taskresult!
	
	echo MOVING NEW MISSION FILE
	call :fMoveLogged "%file_newmish%" "%armapath%\MPMissions"
) else (
	call :FUNC NOVAR BatchLogWrite 1__START.BAT__NOT_DETECTED__NEW_MISSION
)
goto startCommand

:DISABLED_FEATURES_A2
call :FUNC NOVAR BatchLogWrite 1__START.BAT__PBO_AUTO_FEATURES_WORKINPROGRESS

:SKIP_ROUTINE
:startCommand
cls
echo STARTING SERVER
set startserver=false
set startbec=false

IF /i "%1"=="" (
	set startserver=true
	set startbec=true
	echo STARTING BOTH
)
IF /i "%1"=="server" (
	set startserver=true
	echo STARTING SERVER ONLY
)
IF /i "%1"=="bec" (
	set startbec=true
	echo STARTING BEC ONLY
)
if "%startbec%"=="true" (
	call "batch_lib/lib/start_bec.bat" && set taskresult=SUCCESS || set taskresult=FAILURE
	call :FUNC NOVAR BatchLogWrite 1__START.BAT__BECEXE__%taskresult%
)

if "%startserver%"=="true" (
	call "batch_lib/lib/start_server.bat" && set taskresult=SUCCESS || set taskresult=FAILURE
	call :FUNC NOVAR BatchLogWrite 1__START.BAT__ARMAEXE__%taskresult%
)

:End
cd /D "%originalDirectory%"
goto :EOF

:fMoveLogged
setlocal
set resultnum=0
for /f %%b in ('move /y %1 %2') do (
	set resultnum=%%b
)
if "%resultnum%"=="0" (
	set taskresult=NOFILES
) else (
	echo %resultnum%|findstr /r "[^0-9]" > nul
	if errorlevel 0 set taskresult=FAILURE
	if errorlevel 1 set taskresult=SUCCESS
)
set t_move=%1
set t_move=%t_move:\*=._.%
set t_move=%t_move: =.-.%
if "%taskresult%"=="SUCCESS" (
	call :FUNC NOVAR BatchLogWrite 1__START.BAT__MOVE:%t_move%:RESULT__%taskresult%[%resultnum%]
) else (
	call :FUNC NOVAR BatchLogWrite 1__START.BAT__MOVE:%t_move%:RESULT__%taskresult%
)
endlocal
goto :EOF

:FUNC
set currentDir="%CD%"
cd /D "%armapath%/batch_lib/gbl_func"
rem %1 = return var, %2 = function, %3 = args
set returnvarname=%1
set funcname=%2
set argString=%3
set argString=%argString:__= %
set argString=%argString:"=%
set argString=%argString:(=[%
set argString=%argString:)=]%
set args=%argString%
if "%argString%"=="__=" set args=
if "%argString%"=="" (
	set args=
)
set filename=%funcname%.cmd
set val1=
for /f %%I in ('%filename% "%args%"') do (
	set "val1=%%I"
)
set "%1=%val1%"
cd /D "%currentDir%"
goto :EOF
