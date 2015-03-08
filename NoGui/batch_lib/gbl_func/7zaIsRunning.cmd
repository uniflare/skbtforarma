@echo off
cd "%armapath%"
tasklist /FI "IMAGENAME eq 7za.exe" 2>NUL | find /I /N "7za.exe">NUL
if "%ERRORLEVEL%"=="0" (
	echo.true
) else (
	echo.false
)