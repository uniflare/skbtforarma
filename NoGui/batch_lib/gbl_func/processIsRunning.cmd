@echo off
SETLOCAL ENABLEDELAYEDEXPANSION
set processName=%1
set processPath=%2
set usePath=0
echo false

set process=
if "%processPath"=="" (
	set process=processName
) else (
	set process="%processPath:"=%\%processName:"=%"
	set usePath=1
)

if %usePath%==0 (
	tasklist /FI "IMAGENAME eq %armaserverexe%" 2>NUL | find /I /N "%armaserverexe%">NUL
	if "!%ERRORLEVEL%!"=="0" echo true
) else (
	set PathResult=0
	set pn=
	for /f "tokens=2 delims=," %%I in (
		'wmic process where "name='%processName:"=%'" get ExecutablePath^,Handle /format:"%WINDIR%\System32\wbem\en-us\csv" ^| find /i "%processName:"=%"'
	) do call :Func_CheckPath "%%~I"
	if !PathResult!==1 echo true
)

goto :EOF

:Func_CheckPath
set thePath=%1
set checkPath=%process%
call :Func_NormlizePath thePath "%thePath%"
call :Func_NormlizePath checkPath "%checkPath%"
call :LoCase thePath
call :LoCase checkPath
if "%thePath%"=="%checkPath%" set PathResult=1
goto :EOF

:Func_NormlizePath
set thePathToNormalize=%2

set normalPath=%thePathToNormalize:"=%
set normalPath=%normalPath:/=\%
set normalPath=%normalPath:\\=\%
set normalPath=%normalPath:\\=\%
REM // set output to the return variable
set "%1=%normalPath%"
goto :EOF

:LoCase
:: Subroutine to convert a variable VALUE to all lower case.
:: The argument for this subroutine is the variable NAME.
SET %~1=!%1:A=a!
SET %~1=!%1:B=b!
SET %~1=!%1:C=c!
SET %~1=!%1:D=d!
SET %~1=!%1:E=e!
SET %~1=!%1:F=f!
SET %~1=!%1:G=g!
SET %~1=!%1:H=h!
SET %~1=!%1:I=i!
SET %~1=!%1:J=j!
SET %~1=!%1:K=k!
SET %~1=!%1:L=l!
SET %~1=!%1:M=m!
SET %~1=!%1:N=n!
SET %~1=!%1:O=o!
SET %~1=!%1:P=p!
SET %~1=!%1:Q=q!
SET %~1=!%1:R=r!
SET %~1=!%1:S=s!
SET %~1=!%1:T=t!
SET %~1=!%1:U=u!
SET %~1=!%1:V=v!
SET %~1=!%1:W=w!
SET %~1=!%1:X=x!
SET %~1=!%1:Y=y!
SET %~1=!%1:Z=z!
GOTO:EOF