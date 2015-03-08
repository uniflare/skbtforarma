@echo off
if %keepalive_hc%==1 (
	tasklist /FI "IMAGENAME eq %hcexename%" 2>NUL | find /I /N "%hcexename%">NUL
	if "!ERRORLEVEL!"=="0"  goto :EOF
	set currentDir=%CD%
	cd /D %armapath%/batch_lib/external
	psexec -w "%hcarmapath%" -d -%hcPriority% -a %hcAffinity% -accepteula %hcarmapath%/%hcexename% %hclaunchparams%
	cd /D !currentDir!
)
goto :EOF