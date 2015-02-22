@echo off


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
set keepalive_database=1
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
set databasebackupfolder=C:\apps\epoch_redis_backups

REM // Location to store the Server Log Backups
set logfilebackupfolder=C:\apps\epoch_log_backups

REM // Manual Action Timeout in Seconds
REM // Length of time to keep the game server down after using manual_stop.bat
REM // ex, To edit the database objects or vehicles/mission file upload etc.
set manual_timeout_length=300

REM // Automated Event Timeout in Seconds
REM // Length of time in seconds to wait for the Arma server EXE to close by itself before force closing it
REM // Used with BEC Scheduler so it can setauto.bat and shutdown server using #shutdown gracefully
set auto_timeout_length=25

REM // Auto close any error dialogs after a crash event (will close ALL WER error dialogs)
set cleanWerDialogs=false


REM \\ // ===================================================== \\ //
REM // \\               HC COMMAND LINE PARAMTERS               // \\
REM \\ // ===================================================== \\ //

REM // Headless Client Launch params
set hclaunchparams=-connect=%serverip% -port=%serverport% -client -nosound -mod=@Epoch;


REM \\ // ===================================================== \\ //
REM // \\                 FILE NAMES AND PATHS                  // \\
REM \\ // ===================================================== \\ //

REM // THESE PATHS MUST NOT CONTAIN ANY SPACES - unless:
REM // *tip* If Your paths contain spaces you can use Short Dos Style Directory Paths Eg: C:\Progra~1\Steam\SteamApps\Common\Arma~1\)
REM // To find these short names you can use the command: "dir /x" at a command prompt to see the folder/file names in short dos style

REM // Executable Names
REM // Name of the server executable (if using arma 2 or arma 3 etc)
set armaserverexe=arma3server.exe
REM // Headless Client EXE name
set hcexename=arma3serverHC.exe
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
set armapath=F:\games\A3Master
REM // Headless Client path (if using)
set hcarmapath=%armapath%
REM // Teamspeak Path (if using)
set teamspeakpath=C:\apps\teamspeak
REM // Full path the Database folder with redis.conf/redis-server.exe/dump.rdb
set redispath=%armapath%\DB
REM // Full path the Arma Server Monitor executable (Just put inside arma directory)
set asmpath=%armapath%
REM // Full path to the Battleye folder containing your BE Filters and Config
set Battleyepath=%armapath%\SC\BattlEye
REM // Full path to the log/config/instance folder (containing server rpt and config.cfg and basic.cfg)
set LogPath=%armapath%\SC
REM // Full path to the BEC executable
set becpath=%armapath%\BEC
REM // Full path to the Database File/Folder
set databasefile=%armapath%\DB\%databasefile_name%


REM \\ // ===================================================== \\ //
REM // \\             SERVER COMMAND LINE PARAMTERS             // \\
REM \\ // ===================================================== \\ //

REM // Location of config.cfg server config file
set servercfgpath=%armapath%\SC\config.cfg

REM // Location of basic.cfg Server Config File
set serverbasicpath=%armapath%\SC\basic.cfg

REM // Profile name
REM // Location of the users folder with arma profiles (difficulty settings etc)
set profilepathname=SC
set cli_username=SC

REM // Command line to launch the server with as called from windows console/shortcuts.
if %bindtoip%==1 (
	set ip_param= -ip=%serverip%
) else (
	set ip_param=
)

REM // Mod string for startup command line
set mod_string= -mod=@Epoch;@EpochHive;@CBA_A3

REM // This should not need to be altered.
set servercommandline=%armaserverexe% %mod_string% -config=%servercfgpath% %ip_param% -port=%serverport% -profiles=%profilepathname% -cfg=%serverbasicpath% -name=%cli_username% -autoinit

REM \\ // ===================================================== \\ //
REM // \\           EXECUTABLE AFFINITIES/PRIORITIES            // \\
REM \\ // ===================================================== \\ //

REM // Affinity of the Process (use comma seperated list of processor core numbers, eg: "serverAffinity=0,2" for core 1 and 3)
set serverAffinity=0,1
set becAffinity=1
set hcAffinity=2
set redisAffinity=2
set teamspeakAffinity=2
set asmAffinity=2

REM // Server Priority, Specify: low, belownormal, normal, abovenormal, high or realtime
set serverPriority=normal
set becPriority=normal
set hcPriority=normal
set redisPriority=normal
set teamspeakPriority=normal
set asmPriority=normal

REM \\ // ====================================== \\ //
REM // \\ BELOW ARE NOT NEEDED / NOT IMPLEMENTED // \\
REM \\ // ====================================== \\ //

REM // NOTE, PBO AUTO UPDATES ARE NOT ENABLED IN THIS VERSION.
REM // Enable auto config pbo upload. (NOTE: Customized slightly for Epoch A3)
REM //
set enable_pbo_updates=0
REM // Folder to upload new pbo files too automatically apply on next restart:
REM set dropfolder_newpbo=c:\new_pbo
REM // Folder to upload new config PBO to.
REM set server_addon_folder=%armapath%\@EpochHive\Addons
REM // Folder to upload new Mission PBO to.
REM set mpmission_folder=%armapath%\MPMissions

REM \\ // ====================================== \\ //
REM // \\ BELOW ARE NOT NEEDED / NOT IMPLEMENTED // \\
REM \\ // ====================================== \\ //

REM // Full path to desktop (Not Implemented), should just use %desktop% or w/e anyway
REM set desktop_path=C:\Users\Administrator\Desktop

REM // Path to the Apache executable (httpd.exe) (NOT IMPLEMENTED)
REM set apachebinpath=C:\web\bin\apache24\bin

REM // Path to your MPMissions Folder (in your Arma Server Directory, shouldn't need to change this) (NOT IMPLEMENTED)
REM set pbopath=%armapath%\MPMissions

REM // Path to the Epoch Hive PBO file. (NOT IMPLEMENTED)
REM set spbopath=%armapath%\@EpochHive\Addons

REM // Path to PBO Manager's executable. (NOT IMPLEMENTED)
REM set pbocompath=C:\Progra~1\PBO Manager v.1.4 beta
goto :EOF
rem exit