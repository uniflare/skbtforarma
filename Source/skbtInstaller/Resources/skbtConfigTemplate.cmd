@echo off
if "%configdone%"=="1" (
	GOTO :EOF
)
set configdone=0
set skbt_debug={DEBUG_LEVEL}
set keepalive_database={KEEPALIVE_DATABASE}
set keepalive_bec={KEEPALIVE_BEC}
set keepalive_asm={KEEPALIVE_ASM}
set keepalive_ts={KEEPALIVE_TS}
set keepalive_hc={KEEPALIVE_HC}
set serverport={SERVERPORT}
set bindtoip={BINDTOIP}
set serverip={SERVERIP}
set bec_flag_dsc={BEC_FLAG_DSC}
set teamspeak_port={TEAMSPEAK_PORT}
set asm_log_interval={ASM_LOG_INTERVAL}
set serverStartTimeout={SERVER_START_TIMEOUT}
set db_backup_interval={DB_BACKUP_INTERVAL}
set use_zip_logs={UZE_ZIP_LOGS}
set use_zip_backups={USE_ZIP_BACKUPS}
set databasebackupfolder="{DATABASE_BACKUP_FOLDER}"
set logfilebackupfolder="{LOG_BACKUP_FOLDER}"
set manual_timeout_length={MANUAL_TIMEOUT_LENGTH}
set auto_timeout_length={AUTO_TIMEOUT_LENGTH}
set auto_restart_delay={AUTO_RESTART_DELAY_LENGTH}
set cleanWerDialogs={CLEAN_WER_DIALOGS}
set hclaunchparams={HC_LAUNCH_PARAMS}
set armaserverexe={ARMA_SERVER_EXE}
set hcexename={HC_EXE}
set teamspeakfilename={TS_EXE_NAME}
set redisexename={REDIS_EXE_NAME}
set becexename={BEC_EXE_NAME}
set asmexename={ASM_EXE_NAME}
set databasefile_name={DATABASE_DUMP_NAME}
set asm_log_file={ASM_LOG_NAME}
set armapath="{ARMA_PATH}"
set hcarmapath="{HC_PATH}"
set teamspeakpath="{TS_PATH}"
set redispath="{DB_PATH}"
set asmpath="{ASM_PATH}"
set Battleyepath="{BE_PATH}"
set LogPath="{LOG_PATH}"
set becpath="{BEC_PATH}"
set databasefile="{DB_FILE_FULLPATH}"
set servercfgpath="{SERVER_CONFIG_PATH}"
set serverbasicpath="{SERVER_BASIC_PATH}"
set profilepathname="{PROFILE_PATH}"
set cli_username="{PROFILE_NAME}"
if %bindtoip%==1 (
	set ip_param= -ip=%serverip%
) else (
	set ip_param=
)
set mod_string={MOD_STRING}
set servercommandline={COMMAND_LINE}
set serverAffinity={AFFINITY_SERVER}
set becAffinity={AFFINITY_BEC}
set hcAffinity={AFFINITY_HC}
set redisAffinity={AFFINITY_DB}
set teamspeakAffinity={AFFINITY_TS}
set asmAffinity={AFFINITY_ASM}
set serverPriority={PRIORITY_SERVER}
set becPriority={PRIORITY_BEC}
set hcPriority={PRIORITY_HC}
set redisPriority={PRIORITY_DB}
set teamspeakPriority={PRIORITY_TS}
set asmPriority={PRIORITY_ASM}

REM Clean Paths?
cd /D %armapath%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %armapath%') do (
    set result=%%a
)
	set armapath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %hcarmapath%') do (
    set result=%%a
)
	set hcarmapath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %teamspeakpath%') do (
    set result=%%a
)
	set teamspeakpath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %redispath%') do (
    set result=%%a
)
	set redispath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %asmpath%') do (
    set result=%%a
)
	set asmpath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %Battleyepath%') do (
    set result=%%a
)
	set Battleyepath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %LogPath%') do (
    set result=%%a
)
	set LogPath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %becpath%') do (
    set result=%%a
)
	set becpath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" "%databasefile:"=%"') do (
    set result=%%a
)
	set databasefile=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %servercfgpath%') do (
    set result=%%a
)
	set servercfgpath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %serverbasicpath%') do (
    set result=%%a
)
	set serverbasicpath=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %databasebackupfolder%') do (
    set result=%%a
)
	set databasebackupfolder=%result%
for /F "delims=" %%a in ('cscript.exe "batch_lib/lib/getShortPath.vbs" %logfilebackupfolder%') do (
    set result=%%a
)
	set logfilebackupfolder=%result%
set configdone=1
goto :EOF