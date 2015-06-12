@echo off
if %keepalive_bec%==1 (
	set currentDir="%CD%"
	cd /D "%armapath%/batch_lib/external"
	set dscoption=--dsc
	if "%bec_flag_dsc%"=="0" set dscoption=
	psexec -w "%becpath%" -d -%becPriority% -a %becAffinity% -accepteula "%becpath%/%becexename%" -f Config.cfg %dscoption%
	call :FUNC NOVAR BatchLogWrite 3__START_BEC__PSEXEC__-w.-."%becpath: =.-.%".-.-d.-.-%becPriority: =.-.%.-.-a.-.%becAffinity:,=.+.%.-.-accepteula.-."%becpath: =.-.%/%becexename: =.-.%".-.-f.-.Config.cfg.-.%dscoption: =.-.%
	cd /D "!currentDir!"
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