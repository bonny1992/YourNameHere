Name "YourNameHere"

# define name of installer
OutFile "releases/YourNameHere-setup.exe"
 
# define installation directory
InstallDir $APPDATA/YourNameHere
 
RequestExecutionLevel user
 
Section
	File /r "YourNameHere/bin/Release/*"

    # set the installation directory as the destination for the following actions
    SetOutPath $INSTDIR

	CreateShortCut "$SMPROGRAMS\YourNameHere\YourNameHere.lnk" "$INSTDIR\YourNameHere.exe"
 
    # create the uninstaller
    WriteUninstaller "$INSTDIR\uninstall.exe"
 
    # create a shortcut named "new shortcut" in the start menu programs directory
    # point the new shortcut at the program uninstaller
    CreateShortCut "$SMPROGRAMS\YourNameHere\Uninstall.lnk" "$INSTDIR\uninstall.exe"
SectionEnd
 
# uninstaller section start
Section "uninstall"
 
    # first, delete the uninstaller
    Delete /r "$INSTDIR"
 
    # second, remove the link from the start menu
    Delete "$SMPROGRAMS\YourNameHere\Uninstall.lnk"
	Delete "$SMPROGRAMS\YourNameHere\YourNameHere.lnk"
 
# uninstaller section end
SectionEnd