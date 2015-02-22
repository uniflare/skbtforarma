@echo off
setlocal EnableDelayedExpansion

set sleeptime=%1
echo sleeping for %sleeptime% seconds
call "%armapath%/batch_lib/external/sleep.exe" %sleeptime%
REM PING 127.0.0.1 -n %sleeptime% >NUL 2>&1 || PING ::1 -n %sleeptime% >NUL 2>&1

goto :EOF