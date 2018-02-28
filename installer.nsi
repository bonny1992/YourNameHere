!include "MUI.nsh"

!define MUI_ABORTWARNING # This will warn the user if he exits from the installer.

!insertmacro MUI_PAGE_WELCOME # Welcome to the installer page.
!insertmacro MUI_PAGE_DIRECTORY # In which folder install page.
!insertmacro MUI_PAGE_INSTFILES # Installing page.
!insertmacro MUI_PAGE_FINISH # Finished installation page.

!insertmacro MUI_LANGUAGE "English"

Name "YourNameHere" # Name of the installer (usually the name of the application to install).
OutFile "releases/MyAppInstaller.exe" # Name of the installer's file.
InstallDir "$APPDATA\YourNameHere" # Default installing folder ($PROGRAMFILES is Program Files folder).
ShowInstDetails show # This will always show the installation details.

Section "YourNameHere" # In this section add your files or your folders.
  File /r YourNameHere/bin/Release/*
  # Add your files with "File (Name of the file)", example: "File "$DESKTOP\MyApp.exe"" ($DESKTOP is Desktop folder); or add your folders always with "File (Name of the folder)\*", always add your folders with an asterisk, example: "File /r $DESKTOP\MyApp\*" (this will add its files and (with /r its subfolders)).
SectionEnd