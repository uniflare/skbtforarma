@echo off
call c:/batch_settings.cmd
cd "%armapath%"
set crashed=false
set processName=%1
set processName=%processName:"=%
(tasklist /FI "Status eq Not Responding"|find "%processName%")&&set crashed=true
(tasklist /FI "Status eq Unknown"|find "%processName%")&&set crashed=true
call :FUNC NOVAR BatchLogWrite 1__processHasCrashed__%processName%__%crashed%
echo.%crashed%
goto :EOF

:FUNC
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
if not "%argString2%"=="" set args2= "%argString2%"
for /f %%I in ('%filename% "%args%"%args2%') do (
	set "val1=%%I"
)
set "%1=%val1%"
cd %currentDirF%
goto :EOF