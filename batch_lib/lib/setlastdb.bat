@echo off
call c:\batch_settings.cmd
set fContents=%1
<nul set /p "=%fContents%">%armapath%\batch_lib\wrkdir\lastdb_backup.txt
goto :EOF