@echo off
rem %1=enum int debug level | %2=Code Section | %3=Code Result/Mission
setlocal EnableDelayedExpansion
set currentDir=%CD%
cd /D "%armapath%/batch_lib/gbl_func"

set args=%1
set args=%args:"=%
set origin=
set /a debuglevel=0
set section=
set result=

set i=0
for %%a in (%args%) do (
	set /a i=!i!+1
	if "!i!"=="1" set /a debuglevel=%%a
	if "!i!"=="2" set origin=%%a
	if "!i!"=="3" set section=%%a
	if "!i!"=="4" set result=%%a
)

REM // Log accordingly
if %debuglevel% GTR %skbt_debug% goto :SkipLog

set section=%section:.-.= %
set section=%section:._.=\*%
set section=%section:.+.=,%

if "%result%"=="" goto skipres
set result=%result:.+.=,%
set result=%result:.-.= %
set result=%result:._.=\*%
set result=%result:.+_.="%
:skipres

for /f "delims=" %%I in ('getTimeStr.cmd') do (
	set "val1=%%I"
)
set TIMESTRB=%val1%
set tempLogResultString=%section%:%result%
set "tempLogString=%TIMESTRB%:%origin%:%tempLogResultString%"
cd /D "%armapath%\batch_lib"
REM //if "%newline%"=="0" (
REM //	<nul set /p ".=%tempLogResultString%" >> batchrun.log
REM //) else (
echo %tempLogString% >> batchrun.log
REM //)

:SkipLog
cd /D "%currentDir%"

goto :EOF