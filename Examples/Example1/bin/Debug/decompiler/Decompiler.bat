@echo off

echo FastLPI engine user decompiler executor
echo Date of writing : 14.05.2022
echo Version : 1.0
echo ^^

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
java -jar jd-cli.jar -od "%OUTPATH%" "%FILEPATH%"
goto :End
:ToCurentFolderDecompile
java -jar jd-cli.jar "%FILEPATH%"
goto :End


:End
pause