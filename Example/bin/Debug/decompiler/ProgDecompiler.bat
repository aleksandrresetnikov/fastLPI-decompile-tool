@echo off

rem echo FastLPI engine user decompiler executor
rem echo Date of writing : 14.05.2022
rem echo Version : 1.0
rem echo ^^

SET FILEPATH=$$$FILEPATH$$$
SET OUTPATH=$$$OUTPATH$$$


IF exist "%FILEPATH%" goto :Decompile
IF not exist "%FILEPATH%" goto :FileNotExistError
goto :End


:FileNotExistError
rem echo File "%FILEPATH%" not exist !
goto :End


:Decompile
rem echo Decompilation processing...
IF "%OUTPATH%" == "" goto :ToCurentFolderDecompile
IF not "%OUTPATH%" == "" goto :ToSelectFolderDecompile
goto :End


:ToSelectFolderDecompile
java -jar $$$DECOMPILERJARPATH$$$ $$$OPTIONS$$$
goto :End
:ToCurentFolderDecompile
java -jar $$$DECOMPILERJARPATH$$$ "%FILEPATH%"
goto :End


:End
exit