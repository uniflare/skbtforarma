@echo off
if %keepalive_database%==1 (
	REM // Double start fix
	tasklist /FI "IMAGENAME eq %redisexename%" 2>NUL | find /I /N "%redisexename%">NUL
	if "!ERRORLEVEL!"=="0"  goto :EOF
	set currentDir="%CD%"
	cd /D "%armapath%/batch_lib/external"
	psexec -w "%redispath%" -d -%redisPriority% -a %redisAffinity% -accepteula "%redispath%\%redisexename%" redis.conf
	call :FUNC NOVAR BatchLogWrite 3__START_DB__PSEXEC__-w.-."%redispath: =.-.%".-.-d.-.-%redisPriority: =.-.%.-.-a.-.%redisAffinity:,=.+.%.-.-accepteula.-."%redispath: =.-.%\%redisexename: =.-.%".-.redis.conf
	echo cd: %currentDir%
	cd /D %currentDir%
)
goto :EOF