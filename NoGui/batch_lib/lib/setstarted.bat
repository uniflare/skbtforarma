@echo off
call "C:\batch_settings.cmd"
call :FUNC UNIX_TIME getUnixTime
if "%1"=="clear" (
	set fContents=0
) else (
	set fContents=%UNIX_TIME%
)
set startedtxtfile="%armapath%\batch_lib\wrkdir\laststarted.txt"
call :FUNC NOVAR BatchLogWrite 3__STARTED_SET__%fContents%__%startedtxtfile: =.-.%
<nul set /p "=%fContents%" > "%startedtxtfile%"
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
cd /D %currentDir%
goto :EOF