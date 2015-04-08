@echo off
setlocal ENABLEDELAYEDEXPANSION
cd %armapath%\batch_lib\gbl_func

set serverfile_path=%1
set uploadedfile_path=%2
set serverfile_name=%3
set overwrite_suffix=.original

REM // check if file already exists
if not exist %serverfile_path% call :FUNC NOVAR BatchLogWrite 3__UPDATE_SERVER_FILE.BAT__WARNING__%serverfile_path%

REM // Check if new file is there to copy over
if exist "%uploadedfile_path%" (
	call :FUNC NOVAR BatchLogWrite 3__UPDATE_SERVER_FILE.BAT__DETECTED__NEW_FILE:%uploadedfile_path%
	set taskresult=NO_FILE
	
	REM // Check if the previous version is already there
	if exist "%serverfile_path%%overwrite_suffix%" (
		del "%serverfile_path%%overwrite_suffix%" && set taskresult=SUCCESS || set taskresult=FAILURE	
		echo DELETING LAST ORIGINAL FILE !taskresult!
		call :FUNC NOVAR BatchLogWrite 3__UPDATE_SERVER_FILE.BAT__DELETE:%serverfile_path%%overwrite_suffix%:RESULT__!taskresult!
		if !taskresult!==FAILURE (
			echo FAILED
			goto :EOF
		)
	)
	
	set taskresult=NO_FILE
	REM // Check if server file is there
	if exist "%serverfile_path%" (
		rename "%serverfile_path%" "%serverfile_name%%overwrite_suffix%"
		if not exist "%serverfile_path%%overwrite_suffix%" (
			call :FUNC NOVAR BatchLogWrite 3__UPDATE_SERVER_FILE.BAT__RENAME_TO_LAST:%serverfile_path%:RESULT__!taskresult!
			echo FAILED
			goto :EOF
		) 
	)
	
	copy "%uploadedfile_path%" "%serverfile_path%"
	if not exist "%serverfile_path%" (
		call :FUNC NOVAR BatchLogWrite 2__UPDATE_SERVER_FILE.BAT__COPY_TO_SERVERFOLDER__FAILED_REVERTING_CHANGES
		
		rename "%serverfile_path%%overwrite_suffix%" "%serverfile_name%" && set taskresult=SUCCESS || set taskresult=FAILURE
		call :FUNC NOVAR BatchLogWrite 3__UPDATE_SERVER_FILE.BAT__REVERT_RENAME:%serverfile_path%:RESULT__!taskresult!
		if !taskresult!==FAILURE (
			call :FUNC NOVAR BatchLogWrite w__UPDATE_SERVER_FILE.BAT__CRITICAL_ERROR__COULD_NOT_REVERT_CHANGES
		)
		echo FAILED
		goto :EOF
	)
) else (
	echo NO_NEW_FILE
)

goto :EOF

:FUNC
set currentDir=%CD%
cd "%armapath%/batch_lib/gbl_func"
rem %1 = return var, %2 = function, %3 = args
set returnvarname=%1
set funcname=%2
set argString=%3
set argString=%argString:__= %
set argString=%argString:"=%
set argString=%argString:(=[%
set argString=%argString:)=]%
set args=%argString%
if "%argString%"=="__=" set args=
if "%argString%"=="" (
	set args=
)
set filename=%funcname%.cmd
set val1=
for /f %%I in ('%filename% "%args%"') do (
	set "val1=%%I"
)
set "%1=%val1%"
cd %currentDir%
goto :EOF