@echo off
call "C:\batch_settings.cmd"
if not exist "%armapath%" goto :noArmaPath
if not exist "%armapath%\batch_lib" goto :noBatchLib
cd /D %armapath%
start "Keepalive Launcher v1.1" "batch_lib\core\ka_launcher.bat"
exit

:noArmaPath
echo.CRITICAL ERROR:
echo.
echo. Please correct your Arma Path in c:\batch_settings.bat!
echo.^(cant find "%armapath%"^)
echo.
echo.
pause
exit

:noBatchLib
echo.CRITICAL ERROR:
echo.
echo. Please make sure you have installed this tool correctly! 
echo.^(cant find "%armapath%\batch_lib"^)
echo.
echo.
pause
exit