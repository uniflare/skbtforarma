@echo off
if %keepalive_database%==1 (
	REM // Double start fix
	tasklist /FI "IMAGENAME eq %redisexename%" 2>NUL | find /I /N "%redisexename%">NUL
	if "!ERRORLEVEL!"=="0"  goto :EOF
	set currentDir="%CD%"
	cd /D "%armapath%/batch_lib/external"
	psexec -w "%redispath%" -d -%redisPriority% -a %redisAffinity% -accepteula "%redispath%\%redisexename%" redis.conf
	call :FUNC NOVAR BatchLogWrite 3__START_DB__PSEXEC__-w.-."%redispath: =.-.%".-.-d.-.-%redisPriority: =.-.%.-.-a.-.%redisAffinity:,=.+.%.-.-accepteula.-."%redispath: =.-.%\%redisexename: =.-.%".-.redis.conf
	echo cd: %currentDir%
	cd /D %currentDir%
)
goto :EOF

:FUNC
set currentDirF=%CD%
cd "%armapath%/batch_lib/gbl_func"
rem %1 = return var, %2 = function, %3 = args
set returnvarname=%1
set funcname=%2
set argString=%3
set argString2=%4
set argString=%argString:__= %
set argString=%argString:"=%
set argString=%argString:(=[%
set argString=%argString:)=]%
set args=
set args2=
set args=%argString%
if "%args%"=="__=" set args=
set filename=%funcname%.cmd
set val1=
if not "%argString2%"=="" set args2= "%argString2%"
for /f %%I in ('%filename% "%args%"%args2%') do (
	set "val1=%%I"
)
set "%1=%val1%"
cd %currentDirF%
goto :EOF