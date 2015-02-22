@echo off
setlocal ENABLEDELAYEDEXPANSION
call c:\batch_settings.cmd
set currentDir=%CD%
cd /D %armapath%\batch_lib\external

set exename="%1"
set exename=%exename:"=%
set arg2="%2"
set arg2=%arg2:"=%

:startKill

tasklist /FI "IMAGENAME eq %exename%" | find /I "%exename%"
if "%ERRORLEVEL%"=="0" (

	if "%arg2%"=="force" (
		taskkill /t /f /im %exename%
		ping -n 2 127.0.0.1 > nul
		tasklist /FI "IMAGENAME eq %exename%" 2>NUL | find /I /N "%exename%"
		if "!ERRORLEVEL!"=="0" (
			call :FUNC NOVAR BatchLogWrite 1__STOP.CMD__KILLTASK:%exename%__PROCESS_STUCK
			echo FAILED
		) else (
			call :FUNC NOVAR BatchLogWrite 1__STOP.CMD__KILLTASK:%exename%__PROCESS_MANUAL_FORCE_TERMINATED
			echo PROCESS_TERMINATED
		)
	) else (
		taskkill /t /im %exename% && set taskresult=SUCCESS || set taskresult=FAILURE
		call :FUNC NOVAR sleep 1
		tasklist /FI "IMAGENAME eq %exename%" 2>NUL | find /I /N "%exename%">NUL
		if "!ERRORLEVEL!"=="0" (
			taskkill /t /f /im %exename% && set taskresult=SUCCESS || set taskresult=FAILURE
		) else (
			call :FUNC NOVAR BatchLogWrite 1__STOP.CMD__KILLTASK:%exename%__PROCESS_FORCE_TERMINATED
			echo PROCESS_TERMINATED
		)
	)
) else (
	call :FUNC NOVAR BatchLogWrite 1__STOP.CMD__KILLTASK:%exename%__PROCESS_NOT_RUNNING
	echo PROCESS_NOT_RUNNING
)
tasklist /FI "IMAGENAME eq %exename%" | find /I "%exename%"
if "%ERRORLEVEL%"=="0" (
	taskkill /t /f /fi "status eq not responding"
	goto :startKill
)

cd /D %currentDir%
goto :EOF

:FUNC
set currentDir=%CD%
cd "%armapath%/batch_lib/gbl_func"
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
cd %currentDir%
goto :EOF