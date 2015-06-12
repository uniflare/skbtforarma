@echo off
rem Bypass "Terminate Batch Job" prompt.
if "%~1"=="-FIXED_CTRL_C" (
   REM Remove the -FIXED_CTRL_C parameter
   SHIFT
) ELSE (
   REM Run the batch with <NUL and -FIXED_CTRL_C
   CALL <NUL %0 -FIXED_CTRL_C %*
   GOTO :EOF
)
call :FUNC TIMESTR getTimeStr
echo Keepalive Launcher.
echo. 
echo. NOTE: Keep this window open to keep the keepalive always open.
echo. If you want to close the keepalive, you need to close this window first.
echo. 
echo. 
echo [%TIMESTR%] Starting Keepalive
cd %armapath%
set /a kkk=0
start /wait "Server Keepalive Tools v1.2.2.1 by Uniflare (AKA) Chemical Bliss" "batch_lib\core\server_keepalive.bat" >nul 2>&1
:keep_keepalive_alive
echo. 
set /p quitflag=<"batch_lib\wrkdir\stopkeepalive.txt"
if "%quitflag%"=="keepalivequit" goto quit_keepalive
set /a kkk=%kkk%+1
echo [%TIMESTR%] UNKNOWN EVENT. KEEPALIVE WAS CLOSED.
call :FUNC NOVAR BatchLogWrite 2__KEEPALIVE_LAUNCHER__DETECTED__KEEPALIVE_QUIT[%kkk%]
copy "batch_lib\core\server_keepalive.bat" "batch_lib\core\server_keepalive.%kkk%.bat" >nul 2>&1
echo [%TIMESTR%] STARTING "server_keepalive.%kkk%.bat"
start /wait "KEEPALIVE CONSOLE APP" "batch_lib\core\server_keepalive.%kkk%.bat" >nul 2>&1
echo. 
goto :keep_keepalive_alive
goto :EOF

:quit_keepalive
break>"batch_lib\wrkdir\stopkeepalive.txt"
exit

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