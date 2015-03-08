@echo off
rem %1=bool newline or not | %2=Code Section | %3=Code Result/Mission
setlocal EnableDelayedExpansion
cd /D "%armapath%/batch_lib/gbl_func"

set args=%1
set args=%args:"=%
set origin=
set newline=
set section=
set result=

set i=0
for %%a in (%args%) do (
	set /a i=!i!+1
	if "!i!"=="1" set newline=%%a
	if "!i!"=="2" set origin=%%a
	if "!i!"=="3" set section=%%a
	if "!i!"=="4" set result=%%a
)
set section=%section:.-.= %
set section=%section:._.=\*%
set result=%result:.-.= %
set result=%result:._.=\*%

for /f "delims=" %%I in ('getTimeStr.cmd') do (
	set "val1=%%I"
)
set TIMESTRB=%val1%
set tempLogResultString=%section%:%result%
set "tempLogString=%TIMESTRB%:%origin%:%tempLogResultString%"
cd /D "%armapath%\batch_lib"
if "%newline%"=="0" (
	<nul set /p ".=%tempLogResultString%" >> batchrun.log
) else (
	echo %tempLogString% >> batchrun.log
)
cd /D "%armapath%"

goto :EOF