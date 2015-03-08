@echo off
cd "%armapath%"
tasklist /FI "IMAGENAME eq %armaserverexe%" 2>NUL | find /I /N "%armaserverexe%">NUL
if "%ERRORLEVEL%"=="0" (
	echo true
) else (
	echo false
)
goto :EOF