@echo off
call c:/batch_settings.cmd
cd "%armapath%"
tasklist /FI "IMAGENAME eq %redisexename%" 2>NUL | find /I /N "%redisexename%">NUL
if "%ERRORLEVEL%"=="0" (
	echo true
) else (
	echo false
)
goto :EOF