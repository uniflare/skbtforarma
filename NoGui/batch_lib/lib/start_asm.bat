@echo off
if %keepalive_asm%==1 (
	tasklist /FI "IMAGENAME eq %asmexename%" 2>NUL | find /I /N "%asmexename%">NUL
	if "!ERRORLEVEL!"=="0"  goto :EOF
	set currentDir=%CD%
	cd /D "%armapath%/batch_lib/external"
	if "%asm_log_file%"=="" (
		set logcmdstr=
	) else (
		set logcmdstr= -l%asm_log_file% -t%asm_log_interval%
	)
	psexec -w "%asmpath%" -d -%asmPriority% -a %asmAffinity% -accepteula %asmpath%\%asmexename% !logcmdstr!
	call :FUNC NOVAR BatchLogWrite 3__START_ASM__PSEXEC__-w.-."%asmpath: =.-.%".-.-d.-.-%asmPriority: =.-.%.-.-a.-.%asmAffinity:,=.+.%.-.-accepteula.-.%asmpath: =.-.%\%asmexename: =.-.%.-.!logcmdstr: =.-.!
	cd /D !currentDir!
)
goto :EOF

:FUNC
set currentDirF=%CD%
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
cd /D %currentDirF%
goto :EOF