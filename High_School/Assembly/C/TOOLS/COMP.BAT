@echo off
set tasm=tasm.exe
set tlink=tlink.exe
set tasmParam=
set tlinkParam=

if not [%1] == [] goto :endif1
	echo "Usage: %0 <file name> [/d|/h]"
	goto :end
:endif1

if not [%1] == [/h] goto :else1
	echo "Usage: %0 <file name> [/d|/h]"
	echo "/d - include debug information"
	echo "/h - show help menu"
	goto :end
:else1
	if not [%2] == [/h] goto :endif3
		echo "Usage: %0 <file name> [/d|/h]"
		echo "/d - include debug information"
		echo "/h - show help menu"
		goto :end
	:endif3
:endif2

if not [%2] == [/d] goto :else2
	set tasmParam=/zi
	set tlinkParam=/v
	goto :endif4
:else2
	if [%2] == [] goto :endif5
		echo "Invalid switch"
		goto :end
	:endif5
:endif4

rem run command
:run
if not exist %1.asm goto :else3
	%tasm% %tasmParam% %1.asm
	%tlink% %tlinkParam% %1.obj
	goto :endif6
:else3
	echo "File not found"
	goto :end
:endif6


:end
echo "Program is complete"
@echo on