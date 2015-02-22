@echo off
setlocal ENABLEDELAYEDEXPANSION
call c:\batch_settings.cmd

REM // %1 = location to save backup

echo.Starting Copy...
copy %databasefile% %1\%databasefile_name%
echo. Completed.

goto :EOF