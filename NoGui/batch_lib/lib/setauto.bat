@echo off
call c:\batch_settings.cmd
call :FUNC UNIX_TIME getUnixTime
if "%1"=="clear" (
	set fContents=0
) else (
	set fContents=%UNIX_TIME%
)
set autotxtfile=%armapath%\batch_lib\wrkdir\lastauto.txt
set manualtxtfile=%armapath%\batch_lib\wrkdir\lastmanual.txt
call :FUNC NOVAR BatchLogWrite 1__AUTO_SET__%fContents%__%autotxtfile: =.-.%
<nul set /p "=%fContents%" > "%autotxtfile%"
call :FUNC NOVAR BatchLogWrite 1__MANUAL_SET__0__%manualtxtfile: =.-.%
<nul set /p "=0" > "%manualtxtfile%"
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