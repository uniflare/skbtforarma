==================
ARMA SERVER KEEPALIVE TOOL 1.2.2.2 (NoGui)
==================
Fixed before server event call. Should be called right before server start. (Now it is).

==================
== NEW CHANGES  ==
==================


==================
== INSTALLATION ==
==================

1. Place batch_lib folder in your arma 3 main directory (with the server exe).
2. Place batch_settings.cmd in the root of your c drive. 
3. Create a shortcut somewhere to start_keepalive.bat
4. Configure the batch_settings.cmd file properly
5. Start the shortcut and test it out!

IMPORTANT: The Game install can be on any drive, but the batch_settings.bat file MUST be on C Drive in Root folder (top folder): C:\batch_settings.cmd

Please dont distribute as your own work, link back to the forum post or drop me an email: uniflare@gmail.com
Problems? Go to the forum thread and ask there.

Good luck!


====USAGE====
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
It wil log accordingly. without using this all your events will be "unknown".

You can also use some web service or other program on the computer to set a "Manual Restart" by running setmanual.bat. 
Once set, the server will stay down for 60 seconds. (You can edit this in batch_settings.cmd - manual_timeout_length)

The logfile is called "batchrun.log" and is placed in the batch_lib directory


==================
= OLD CHANGELOGS =
==================

== Version 1.2.1
Added checks for Redis Server Path/EXE Name and HC Path/EXE Name
Fixed Logging typo at start of keepalive

== Version 1.2.0
Fixed typo preventing wer dialogs from being closed when requested to automatically (true to 1)
Added custom process feature, keep up to 100 extra custom processes alive complete with affinity,priority and command line parameters)

== Version 1.1.0:
Fixed ASM not starting unless keepalive_hc was 1, typo
Added New config variable "skbt_debug". Change log detail level
Added New config "auto_restart_delay". Forcefully delays between ONLY restart events
Added 3 batch files in custom folder to aid in hooking code before certain events, more info inside those files

== Version 1.0.3.1 HOTIFIX:
Fixed modline problem (Wasn't loading mods properly).
Finally fixed space and parenthesis usage in path names

== Version 1.0.3:
Less processor intensive. (was loading settings 12 times/sec ...)
Fixed a bug where the path to the database EXE was used as backup target instead of dump file.
Fixed usage of parenthesis and spaces in path names fully! (hopefully).
Fixed Arma Launch parameters weren't quoted correctly.
Fixed a few more bugs related to config settings.
Added a new config setting: bec_flag_dsc, (fix BEC auto closing due to no update signal).
Fixed database backup if database dump file not found related errors.

== Version 1.0.2:
Fixed config editing issues after saving a config.
-Minor Fixes, skipped public release

== Version 1.0.1:
Fixed start_keepalive where starting from a different Disk Drive would fail.
taskkill/tasklist removed from external folder as were unpredictable in other envirnoments. Now relies on the servers config.

== Version 1.0.0:
*FIXED: start_keepalive where starting from a different Disk Drive would fail.
*REMOVED: taskkill/tasklist removed from external folder as were unpredictable in other envirnoments. Now relies on the servers config.

== Version: 0.9.4:
*FIXED: Server crash on stop/start
*NEW: Crash Detection! Will force close any crashed processes!
*FIXED: Config Structure (should be easier to understand)
*NEW: Affinity and Priority settings!
*CHANGED: Bundled required exe's in external folder for redistributability

== Version 0.9.3 HF (Private Release):
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