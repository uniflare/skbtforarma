@echo off
if %keepalive_ts%==1 (
	tasklist /FI "IMAGENAME eq %teamspeakfilename%" 2>NUL | find /I /N "%teamspeakfilename%">NUL
	if "!ERRORLEVEL!"=="0"  goto :EOF
	set currentDir=%CD%
	cd /D %armapath%/batch_lib/external
	psexec -w "%teamspeakpath%" -d -%teamspeakPriority% -a %teamspeakAffinity% -accepteula %teamspeakpath%/%teamspeakfilename% default_voice_port=%teamspeak_port% open_win_console=1
	call :FUNC NOVAR BatchLogWrite 3__START_TS__PSEXEC__-w.-."%teamspeakpath: =.-.%".-.-d.-.-%teamspeakPriority: =.-.%.-.-a.-.%teamspeakAffinity:,=.+.%.-.-accepteula.-.%teamspeakpath: =.-.%/%teamspeakfilename: =.-.%.-.default_voice_port=%teamspeak_port%.-.open_win_console=1
	cd /D !currentDir!
)
goto :EOF