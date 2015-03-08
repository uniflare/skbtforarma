@echo off
cd "%armapath%"
tasklist /FI "IMAGENAME eq %becexename%" 2>NUL | find /I /N "%becexename%">NUL
if "%ERRORLEVEL%"=="0" (
	echo true
) else (
	echo false
)
goto :EOF