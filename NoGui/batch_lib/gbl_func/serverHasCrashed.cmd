@echo off
call c:/batch_settings.cmd
cd "%armapath%"
set crashed=false
(tasklist /FI "Status eq not responding"|find "%armaserverexe%")&&set crashed=true
(tasklist /FI "Status eq Unknown"|find "%armaserverexe%")&&set crashed=true
echo.%crashed%
goto :EOF