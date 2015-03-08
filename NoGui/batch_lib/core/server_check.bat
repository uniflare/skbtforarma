@echo off

set server=false
set bec=false
set started_server=false

:Stage1
tasklist /FI "IMAGENAME eq %armaserverexe%" 2>NUL | find /I /N "%armaserverexe%">NUL
if "%ERRORLEVEL%"=="0" 	goto ServerRunning
goto ServerNotRunning

:ServerRunning
echo Server is running already, not starting...
set server=true
echo %server%
goto Stage2

:ServerNotRunning
echo Server is not running, is BEC?
set server=false

rem check BEC
:Stage2
tasklist /FI "IMAGENAME eq %becexename%" 2>NUL | find /I /N "%becexename%">NUL
if "%ERRORLEVEL%"=="0" 	goto BECRunning
goto BECNotRunning

:BECRunning
echo BEC is running already, not starting...
set bec=true
if %server% == true goto bothrunning	rem if
echo %server%
goto becrunning_noserver				rem else

:BECNotRunning
echo BEC is not running...
set bec=false
if "%server%"=="true" goto serverrunning_nobec	rem if
goto noserver_nobec								rem else

:becrunning_noserver
echo Closing BEC, starting Both
call :FUNC stop %becexename% force
goto noserver_nobec

:serverrunning_nobec
echo Starting BEC
cd /D "%armapath%"
call "batch_lib/core/start.bat" bec
goto End

:noserver_nobec
echo starting Both
cd /D "%armapath%"
call "batch_lib/core/start.bat"
set /a started_server=true

goto End

:bothrunning
echo Doing Nothing
goto End


:End
goto :EOF

:FUNC
set currentDir=%CD%
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