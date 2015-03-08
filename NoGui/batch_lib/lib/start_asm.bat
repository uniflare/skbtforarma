@echo off
if %keepalive_hc%==1 (
	tasklist /FI "IMAGENAME eq %asmexename%" 2>NUL | find /I /N "%asmexename%">NUL
	if "!ERRORLEVEL!"=="0"  goto :EOF
	set currentDir=%CD%
	cd /D %armapath%/batch_lib/external
	if "%asm_log_file%"=="" (
		set logcmdstr=
	) else (
		set logcmdstr= -l%asm_log_file% -t%asm_log_interval%
	)
	psexec -w "%asmpath%" -d -%asmPriority% -a %asmAffinity% -accepteula %asmpath%\%asmexename% !logcmdstr!
	cd /D !currentDir!
)
goto :EOF