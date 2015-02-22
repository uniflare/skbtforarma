@echo off
rem %1=Path to File to get Size of

:math_simple
set result=error
set num1=%1
set num2=%3
set operation=%2
set "beginJS=mshta "javascript:close(new ActiveXObject('Scripting.FileSystemObject').GetStandardStream(1).Write(eval("
set "endJS=)));""
for /f %%N in (
  '%beginJS% parseFloat(%num1%%operation%%num2%).toFixed(2) %endJS%'
) do set result=%%N