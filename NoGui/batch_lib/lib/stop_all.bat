@echo off
call :FUNC TIMESTR GetTimeStr
echo Stopping BEC
call :FUNC RETURNVAR stop %becexename% >nul 2>&1
echo %RETURNVAR%
echo.
echo Stopping Arma 3 Server
call :FUNC RETURNVAR stop %armaserverexe% >nul 2>&1
echo %RETURNVAR%
echo.
echo Stopping Arma 3 Headless Client
if %keepalive_hc%==1 (
	call :FUNC RETURNVAR stop %hcexename% >nul 2>&1
	echo %RETURNVAR%
	echo.
)
if "%cleanWerDialogs%"=="true" (
	call :FUNC RETURNVAR stop werfault.exe force
)
goto :EOF

:FUNC
set currentDir=%CD%
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
if not "%argString2%"=="" set args2= "%argString2%"
for /f %%I in ('%filename% "%args%"%args2%') do (
	set "val1=%%I"
)
set "%1=%val1%"
cd %currentDir%
goto :EOF

:MATH
set returnvarname=%1
call "%armapath%/batch_lib/gbl_func/math_simple.cmd" %2 %3 %4
set "%1=%result%"
goto :EOF