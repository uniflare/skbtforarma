@echo off
call c:\batch_settings.cmd
if %keepalive_bec%==1 (
	REM // Double start fix
	tasklist /FI "IMAGENAME eq %becexename%" 2>NUL | find /I /N "%becexename%">NUL
	if "!ERRORLEVEL!"=="0"  goto :EOF
	set currentDir=%CD%
	cd /D %armapath%/batch_lib/external
	psexec -w "%becpath%" -d -%becPriority% -a %becAffinity% -accepteula %becpath%/%becexename% -f Config.cfg
	cd /D !currentDir!
)
goto :EOF