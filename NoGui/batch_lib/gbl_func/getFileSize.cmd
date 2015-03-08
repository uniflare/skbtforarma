@echo off
rem %1=Path to File to get Size of
setlocal EnableDelayedExpansion
set file=%1
FOR /F "usebackq" %%A IN ('%file%') DO set size=%%~zA
echo %size%