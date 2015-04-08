@echo off
if %keepalive_bec%==1 (
	REM // Double start fix
	tasklist /FI "IMAGENAME eq %becexename%" 2>NUL | find /I /N "%becexename%">NUL
	if "!ERRORLEVEL!"=="0"  goto :EOF
	set currentDir="%CD%"
	cd /D "%armapath%/batch_lib/external"
	set dscoption=--dsc
	if "%bec_flag_dsc%"=="0" set dscoption=
	psexec -w "%becpath%" -d -%becPriority% -a %becAffinity% -accepteula "%becpath%/%becexename%" -f Config.cfg %dscoption%
	call :FUNC NOVAR BatchLogWrite 3__START_BEC__PSEXEC__-w.-."%becpath: =.-.%".-.-d.-.-%becPriority: =.-.%.-.-a.-.%becAffinity:,=.+.%.-.-accepteula.-."%becpath: =.-.%/%becexename: =.-.%".-.-f.-.Config.cfg.-.%dscoption: =.-.%
	cd /D "!currentDir!"
)
goto :EOF