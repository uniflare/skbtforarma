REM // Use this file to do something before the server is started at ANY TIME (even first run/start/Manual AND auto restarts!).
REM // These files delay the core keepalive process, this ensures it wont continue until this code has finished.

REM // Example Batch Log Write (The 3 at the start is the debug level, refer to config file.)
REM // call :FUNC NOVAR BatchLogWrite 3__EVENT_BSC__Example_Log_Title__Example_Log_Result

REM // This is preferred method to "sleep"/"wait"
REM // call :FUNC sleeprtn sleep 5

REM // Keep your code above this line. ==========================
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