@echo off
call "C:\TESTFO~1\folder\FSF(SE~1.CMD"
set fContents=%1
<nul set /p "=%fContents%">"%armapath%\batch_lib\wrkdir\lastdb_backup.txt"
goto :EOF