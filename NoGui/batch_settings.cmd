@echo off
if "%configdone%"=="1" (
	GOTO :EOF
)
set configdone=0

REM \\ // ===================================================== \\ //
REM // \\             INTRODUCTION AND INFORMATION              // \\
REM \\ // ===================================================== \\ //

REM //    Welcome to the SKBT Configuration file, in here you will find 
REM //    everything necessary to customize your keepalive tool.
REM //    
REM //    A quick note of the most used/needed setting changes:
REM //    
REM //    STANDARD/COMMON KEEPALIVE SETTINGS :: serverport
REM //    STANDARD/COMMON KEEPALIVE SETTINGS :: bindtoip
REM //    STANDARD/COMMON KEEPALIVE SETTINGS :: serverip (if bindtoip is 1)
REM //    
REM //    KEEPALIVE TOOL SPECIFIC SETTINGS :: databasebackupfolder
REM //    KEEPALIVE TOOL SPECIFIC SETTINGS :: logfilebackupfolder
REM //    KEEPALIVE TOOL SPECIFIC SETTINGS :: cleanWerDialogs
REM //    
REM //    FILE NAMES AND PATHS :: armapath
REM //    
REM //    SERVER COMMAND LINE PARAMTERS :: mod_string
REM //    
REM //    EXECUTABLE AFFINITIES/PRIORITIES :: serverAffinity
REM //    EXECUTABLE AFFINITIES/PRIORITIES :: becAffinity
REM //    EXECUTABLE AFFINITIES/PRIORITIES :: serverPriority
REM //    EXECUTABLE AFFINITIES/PRIORITIES :: becPriority
REM //    

REM \\ // ===================================================== \\ //
REM // \\          STANDARD/COMMON KEEPALIVE SETTINGS           // \\
REM \\ // ===================================================== \\ //


REM // Keep database alive?
set keepalive_database=0
REM // Keep BEC alive?
set keepalive_bec=1
REM // Keep an Arma Server Monitor alive? (@ASM)
set keepalive_asm=0
REM // Keep a Teamspeak Server alive?
set keepalive_ts=0
REM // Keep a Headless Client alive?
set keepalive_hc=0

REM // Server Port (this is used regardless if -ip param is omitted)
set serverport=2302

REM // bindtoip, 1 to enable -ip param in command line, 0 to disable (omit from launch params).
set bindtoip=0
REM // ONLY USED IF bindtoip IS 1 :: Public IP address when using the -ip param in your command line. 
set serverip=127.0.0.1


REM \\ // ===================================================== \\ //
REM // \\           EXTERNAL TOOL SPECIFIC SETTINGS             // \\
REM \\ // ===================================================== \\ //

REM // Use Battleye Extended Controls DSC Flag? (adds --dsc to BEC startup command. Try if BEC keeps closing when connecting).
set bec_flag_dsc=1

REM // Teamspeak port number (if using)
set teamspeak_port=2310

REM // ASM log file write interval (if using)
set asm_log_interval=5


REM \\ // ===================================================== \\ //
REM // \\           KEEPALIVE TOOL SPECIFIC SETTINGS            // \\
REM \\ // ===================================================== \\ //

REM // How long to wait for the server to start before assuming it has crashed
set serverStartTimeout=30

REM // Database Backup Interval _in Minutes_ // CAUTION: Too short an interval and you may fill your hard drive rather quickly!
set db_backup_interval=5

REM // Backup log files to zipped archives (1) or plaint text (0)
set use_zip_logs=1

REM // Backup Database file to a zipped archive (1) or raw (0)
set use_zip_backups=1

REM // Folder to store the Database Backups
set databasebackupfolder="C:\apps\epoch_redis_backups"

REM // Location to store the Server Log Backups
set logfilebackupfolder="C:\apps\epoch_log_backups"

REM // Manual Action Timeout in Seconds
REM // Length of time to keep the game server down after using manual_stop.bat
REM // ex, To edit the database objects or vehicles/mission file upload etc.
set manual_timeout_length=300

REM // Automated Event Timeout in Seconds
REM // Length of time in seconds to wait for the Arma server EXE to close by itself before force closing it
REM // Used with BEC Scheduler so it can setauto.bat and shutdown server using #shutdown gracefully
set auto_timeout_length=25

REM // Auto close any error dialogs after a crash event (will close ALL WER error dialogs)
set cleanWerDialogs=0


REM \\ // ===================================================== \\ //
REM // \\               HC COMMAND LINE PARAMTERS               // \\
REM \\ // ===================================================== \\ //

REM // Headless Client Launch params
set hclaunchparams=-connect=%serverip% -port=%serverport% -client -nosound -mod=@Epoch;


REM \\ // ===================================================== \\ //
REM // \\                 FILE NAMES AND PATHS                  // \\
REM \\ // ===================================================== \\ //

REM // Executable Names
REM // Name of the server executable (if using arma 2 or arma 3 etc)
set armaserverexe=Arma3Server.exe
REM // Headless Client EXE name
set hcexename=Arma3ServerHC.exe
REM // Teamspeak Server EXE name
set teamspeakfilename=ts3server_win64.exe
REM // Database Server EXE name
set redisexename=redis-server.exe
REM // BEC EXE name
set becexename=bec.exe
REM // ASM EXE name
set asmexename=ArmaServerMonitor.exe

REM // Filename of the Database File/Folder (Only for reference in the backups)
set databasefile_name=dump.rdb
REM // name of logfile for ASM (if using, will put in same directory as asm.exe)
set asm_log_file=asm_performance.log


REM // Full path to your Arma Server Directory (With the Arma EXE File Inside)
set armapath="c:\Arma3Server"
REM // Headless Client path (if using)
set hcarmapath="%armapath:"=%"
REM // Teamspeak Path (if using)
set teamspeakpath="C:\apps\teamspeak"
REM // Full path the Database folder with redis.conf/redis-server.exe/dump.rdb
set redispath="%armapath:"=%\DB"
REM // Full path the Arma Server Monitor executable (Just put inside arma directory)
set asmpath="%armapath:"=%"
REM // Full path to the Battleye folder containing your BE Filters and Config
set Battleyepath="%armapath:"=%\SC\Battleye"
REM // Full path to the log/config/instance folder (containing server rpt and config.cfg and basic.cfg)
set LogPath="%armapath:"=%"
REM // Full path to the BEC executable
set becpath="%armapath:"=%\BEC"
REM // Full path to the Database File/Folder
set databasefile="%armapath:"=%\DB\dump.rdb"


REM \\ // ===================================================== \\ //
REM // \\             SERVER COMMAND LINE PARAMTERS             // \\
REM \\ // ===================================================== \\ //

REM // Location of config.cfg server config file
set servercfgpath="SC\config.cfg"

REM // Location of basic.cfg Server Config File
set serverbasicpath="SC\basic.cfg"

REM // Profile name
REM // Location of the users folder with arma profiles (difficulty settings etc)
set profilepathname="SC"
set cli_username="SC"

REM // Command line to launch the server with as called from windows console/shortcuts.
if %bindtoip%==1 (
	set ip_param= -ip=%serverip%
) else (
	set ip_param=
)

REM // Mod string for startup command line -- NOTE: Make sure there are NO extra spaces before "-mod...."
set mod_string=-mod=@Epoch;@EpochHive

REM // This should not need to be altered.
set servercommandline=%armaserverexe% %ip_param% -port=%serverport% "-config=%servercfgpath:"=%" "-cfg=%serverbasicpath:"=%" "-profiles=%profilepathname:"=%" "-name=%cli_username:"=%" "%mod_string:"=%" -autoinit

REM \\ // ===================================================== \\ //
REM // \\           EXECUTABLE AFFINITIES/PRIORITIES            // \\
REM \\ // ===================================================== \\ //

REM // Affinity of the Process (use comma seperated list of processor core numbers, eg: "serverAffinity=0,2" for core 1 and 3)
set serverAffinity=0,3,1
set becAffinity=0,1,2,3
set hcAffinity=0,1,2,3
set redisAffinity=0,1,2,3
set teamspeakAffinity=0,1,2,3
set asmAffinity=0,1,2,3

REM // Server Priority, Specify: low, belownormal, normal, abovenormal, high or realtime
set serverPriority=normal
set becPriority=normal
set hcPriority=normal
set redisPriority=normal
set teamspeakPriority=normal
set asmPriority=normal

REM \\ // ====================================== \\ //
REM // \\  FIX FOR LONG PATH NAMES WITH SPACES   // \\
REM \\ // ====================================== \\ //

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