@echo off

echo FastLPI engine user decompiler executor
echo Date of writing : 14.05.2022
echo Version : 1.1
echo ^^
echo H - help
echo V - version
echo D - decompilation
echo DR - decompilation (skip resources)
echo E - exit
echo ^^
echo ^^

SET OUTPUT_TYPE = "-od"
SET SKIP_RESOURSES = ""

echo Select action.
SET /p ACTION=
goto :ActionManager

:ActionManager
IF "%ACTION%" == "E" goto :Exit
IF "%ACTION%" == "V" goto :Action_Version
IF "%ACTION%" == "H" goto :Action_Help
IF "%ACTION%" == "D" goto :Action_Decompilation
IF "%ACTION%" == "DR" goto :Action_Decompilation_SkipResources
echo "%ACTION%" - unknown command!
goto :End

:Action_Version
java -jar jd-cli.jar -v
goto :End

:Action_Help
java -jar jd-cli.jar -h
goto :End

:Action_Decompilation
SET OUTPUT_TYPE = "-od"
goto :UserInput

:Action_Decompilation_SkipResources
SET OUTPUT_TYPE = "-od"
SET SKIP_RESOURSES = "-sr"
goto :UserInput

:UserInput
echo Select file path.
SET /p FILEPATH=

echo Select output file path.
SET /p OUTPATH=


echo =="%OUTPATH%"==


IF exist "%FILEPATH%" goto :Decompile
IF not exist "%FILEPATH%" goto :FileNotExistError
goto :End


:FileNotExistError
echo File "%FILEPATH%" not exist !
goto :End


:Decompile
echo Decompilation processing...
IF "%OUTPATH%" == "" goto :ToCurentFolderDecompile
IF not "%OUTPATH%" == "" goto :ToSelectFolderDecompile
goto :End


:ToSelectFolderDecompile
java -jar jd-cli.jar "%OUTPUT_TYPE%" "%OUTPATH%" "%FILEPATH%" "%SKIP_RESOURSES%"
goto :End
:ToCurentFolderDecompile
java -jar jd-cli.jar "%FILEPATH%" "%SKIP_RESOURSES%"
goto :End


:End
pause

:Exit
exit