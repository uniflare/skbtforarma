@echo off

set currentDir=%CD%
cd /D %armapath%/batch_lib/external

psexec -w "%armapath%" -d -%serverPriority% -a %serverAffinity% -accepteula %armapath%/%servercommandline%
set safecommandline=%servercommandline: =.-.%
set safecommandline=
call :FUNC NOVAR BatchLogWrite 3__START_SERVER__PSEXEC__-w.-."%armapath: =.-.%".-.-d.-.-%serverPriority: =.-.%.-.-a.-.%serverAffinity:,=.+.%.-.-accepteula.-.%armapath: =.-.%/%safecommandline%

REM // call :FUNC sleeprtn sleep %serverStartTimeout%
cd /D %currentDir%
REM psexec [\\computer[,computer2[,...] | @file]][-u user [-p psswd][-n s][-r servicename][-h][-l][-s|-e][-x][-i [session]][-c [-f|-v]][-w directory][-d][-<priority>][-a n,n,...] cmd [arguments]
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