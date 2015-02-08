@echo off
rem %1=Path to File to get Size of
setlocal EnableDelayedExpansion
call c:/batch_settings.cmd
cd "%armapath%/batch_lib/gbl_func"
set file=%1
FOR /F "usebackq" %%A IN ('%file%') DO set size=%%~zA
echo %size%