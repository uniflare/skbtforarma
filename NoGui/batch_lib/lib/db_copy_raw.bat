@echo off
setlocal ENABLEDELAYEDEXPANSION

REM // %1 = location to save backup

echo.Starting Copy...
copy "%databasefile%" "%1\%databasefile_name%"
echo. Completed.

goto :EOF