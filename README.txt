==================
ARMA SERVER KEEPALIVE TOOL 1.1.0.1 HOTFIX RELEASE
==================
*HOTFIX: Fixed exception when chaning db file location on first install.

Added some new config variables and Fixed a typo that broke ASM Start Procedure.

==================
== NEW CHANGES  ==
==================
*HOTFIX: Fixed exception when chaning db file location on first install.

(Merged from NonGui v1.1.0)
Fixed: ASM not starting unless keepalive_hc was 1, typo
Added: New config variable "skbt_debug". Change log detail level
Added: New config "auto_restart_delay". Forcefully delays between ONLY restart events
Added: 3 batch files in custom folder to aid in hooking code before certain events, more info inside those files

Note; Check GUI on how to use these new settings.

==================
== INSTALLATION ==
==================

For Manual install instructions please download the NoGui version. Readme included has the instructions.

Please dont distribute as your own work, link back to the forum post or drop me an email: uniflare@gmail.com
Problems? Go to the forum thread and ask there.

Good luck!


====USAGE====
Start the keepalive! It will keep your processes alive (albeit once configured correctly...).

====AUTO/MANUAL RESTARTS====
To set up auto restarts with this batch file, you need to add custom entries into your BEC Scheduler file, ie, you need to add a command to run setauto.bat (batch_lib/lib/setauto.bat) _JUST_ before shutting down. For example:

	<!-- THESE TWO JOBS WILL AUTO RESTART THE SERVER AT MIDNIGHT, ASSUMING THE KEEPALIVE BATCH TOOL IS RUNNING -->
	<job id="0">
		<start>23:59:59</start>
		<runtime>000000</runtime>
		<day>1,2,3,4,5,6,7</day>
		<loop>0</loop> 
		<cmd>F:\games\A3Master\batch_lib\setauto.bat</cmd>	
	</job>
	<job id="1">
		<start>00:00:00</start>
		<runtime>000000</runtime>
		<day>1,2,3,4,5,6,7</day>
		<loop>0</loop> 
		<cmd>#shutdown</cmd>	
	</job>

When the server shuts down the batch will read "lastauto.txt" (set by running setauto.bat) and notice it is a planned restart (auto). 
It will log accordingly. without using this all your events will be "unknown".

You can also use some web service or other program on the computer to set a "Manual Restart" by running setmanual.bat. 
Once set, the server will stay down for 60 seconds. (You can edit this in batch_settings.cmd - manual_timeout_length)

NOTE: The logfile is called "batchrun.log" and is placed in the batch_lib directory

==================
= OLD CHANGELOGS =
==================

== Version 1.0.3.1 HOTIFIX:
Merged new changes from 1.0.3.1 NonGui Hotfix

== Version 1.0.3:
Merged new changes from 1.0.3 NonGui

== Version 1.0.2
Fixed config editing issues after saving a config.
-Minor Fixes, skipped public release

== Version 1.0.1
FIXED: template files, no more batch_settings errors spamming the screen.
FIXED: Install Dialog Cancel (Used to continue when cancelled).
FIXED: Uninstall Function (Works)
ADDED: keepalive instance shortcuts to start menu and desktop.
REMOVED: Text Window (not needed)

== Version 1.0.0
NEW: **Installation GUI** (Not Required)
NEW: Multi Server Support (Using GUI).
NEW: Full Path names with spaces allowed in config. (AFAIK)

== Version 0.9.4
FIXED: Server crash on stop/start
NEW: Crash Detection! Will force close any crashed processes!
FIXED: Config Structure (should be easier to understand)
NEW: Affinity and Priority settings!
CHANGED: Bundled required exe's in external folder for redistributability

== Version 0.9.3 HF (Private Release)
**HOTFIX: Possibly fixed a double start issue for some (slower) servers.

== Version 0.9.3:
*NEW: Can configure to keep db/bec alive.
*NEW: Reworked Config File (Should be a little clearer).
*NEW: Some new error checking at start. Should catch simple mistakes.
*FIXED: Some hard-coded paths (again).
*FIXED: Critical Error at start now shows the correct error message.

==  Version 0.9.2:
NEW: Can configure to keep a separate Arma process alive (for headless clients)
FIXED: Some hard-coded paths and exe names were replaced with variables from config

==  Version 0.9.1: (hotfix)
FIXED: Hardcoded paths where should of been variables which made the database backup run every second.
NEW: Configuration settings for ASM logging, consult config file for new settings.

==  Version 0.9.0:

NEW: Moved database backup to runtime loop which allows;
NEW: A new setting in config: Database Interval, Minutes between DB Backups
NEW: Ability to keep ASM server monitor alive.
NEW: Ability to keep Teamspeak server alive.
NEW: Log backup and db backup locations configurable
NEW: Many more new settings explained in config.
NEW: Graceful process end timeout, let arma close nicely using #shutdown (BEC Scheduler required)
NEW: Manual Action Timeout configurable. (How long will it take you to upload new pbos?)
CLUTTER: Temp files moved to batch_lib folder to hide clutter in main arma folder
FIXED: Time/Date strings should now function on all windows variants beyond Win XP


==  Version 0.8.0:

Auto log file rotation - Server logs will be backed up to a folder called log_archives in arma server root
Ability to use 7zip to archive logs and/or database file - will save considerable space on large servers
Keep Arma Server Monitor active (Optional) (addon for arma 2/3) - download the addon from http://www.armaholic.com/page.php?id=21436
Keep Teamspeak Server Active (Optional) - Make sure to set correct settings in batch_settings.cmd file!
Restructured the batch_lib folders, now easier to use.