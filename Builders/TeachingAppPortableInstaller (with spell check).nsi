; Script generated by the HM NIS Edit Script Wizard.

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "Teaching App"
!define PRODUCT_VERSION "2.3.0"
!define PRODUCT_PUBLISHER "John M. Andre"
!define PRODUCT_WEB_SITE "http://educators.JohnMAndre.com"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\Teaching.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"




; MUI 1.67 compatible ------
!include "MUI.nsh"

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_ICON "..\Attendence\App.ico"
!define MUI_UNICON "${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"

; Language Selection Dialog Settings
!define MUI_LANGDLL_REGISTRY_ROOT "${PRODUCT_UNINST_ROOT_KEY}"
!define MUI_LANGDLL_REGISTRY_KEY "${PRODUCT_UNINST_KEY}"
!define MUI_LANGDLL_REGISTRY_VALUENAME "NSIS:Language"

; Welcome page
!insertmacro MUI_PAGE_WELCOME
; License page
!insertmacro MUI_PAGE_LICENSE "..\Attendence\eula.rtf"
; Directory page
!insertmacro MUI_PAGE_DIRECTORY
; Instfiles page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
!define MUI_FINISHPAGE_RUN "$INSTDIR\Teaching App Launcher.exe"
!define MUI_FINISHPAGE_SHOWREADME "$INSTDIR\getting-started.rtf"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"

; MUI end ------

Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "TeachingAppSetup.exe"
InstallDir "\TeachingApp"
InstallDirRegKey HKLM "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails hide

Function .onInit
  !insertmacro MUI_LANGDLL_DISPLAY
FunctionEnd

Section "MainSection" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite on
  File "..\TeachingLauncher\bin\x86\Debug\Teaching App Launcher.exe"
  File "..\TeachingLauncher\bin\x86\Debug\Teaching App Launcher.exe.config"
  File "..\Attendence\getting-started.rtf"
  SetOutPath "$INSTDIR\App"
  SetOverwrite on
  File "..\Attendence\bin\Debug\Teaching.exe"
  File "..\Attendence\bin\Debug\Teaching.exe.config"
  File "..\Attendence\bin\Debug\TeachingUpdater.exe"
  File "..\Attendence\bin\Debug\TeachingUpdater.exe.config"
  File "..\Attendence\bin\Debug\UpdaterReplacer.exe"
  File "..\Attendence\bin\Debug\UpdaterReplacer.exe.config"
  File "..\Attendence\bin\Debug\C1.Data.2.dll"
  File "..\Attendence\bin\Debug\C1.Win.C1Editor.2.dll"
  File "..\Attendence\bin\Debug\C1.Win.C1Input.2.dll"
  File "..\Attendence\bin\Debug\C1.Win.C1SpellChecker.2.dll"
  File "..\Attendence\bin\Debug\ComponentFactory.Krypton.Toolkit.dll"
  File "..\Attendence\bin\Debug\Ionic.Zip.dll"
  File "..\Attendence\bin\Debug\ObjectListView.dll"
  File "..\Attendence\English (US).dct"
  File "..\Attendence\English (GB).dct"
  File "..\Attendence\English (AU).dct"
  File "..\Attendence\English (CA).dct"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\App\uninst.exe"
  WriteRegStr HKLM "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\Teaching.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\App\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\Teaching.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) was successfully removed from your computer."
FunctionEnd

Function un.onInit
!insertmacro MUI_UNGETLANGUAGE
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Are you sure you want to completely remove $(^Name) and all of its components?" IDYES +2
  Abort
FunctionEnd

Section Uninstall
  Delete "$INSTDIR\Teaching App Launcher.exe"
  Delete "$INSTDIR\Teaching App Launcher.exe.config"
  Delete "$INSTDIR\getting-started.rtf"
  Delete "$INSTDIR\App\uninst.exe"
  Delete "$INSTDIR\App\Teaching.exe"
  Delete "$INSTDIR\App\Teaching.exe.config"
  Delete "$INSTDIR\App\TeachingUpdater.exe"
  Delete "$INSTDIR\App\TeachingUpdater.exe.config"
  Delete "$INSTDIR\App\UpdaterReplacer.exe"
  Delete "$INSTDIR\App\UpdaterReplacer.exe.config"
  Delete "$INSTDIR\App\C1.Data.2.dll"
  Delete "$INSTDIR\App\C1.Win.C1Editor.2.dll"
  Delete "$INSTDIR\App\C1.Win.C1Input.2.dll"
  Delete "$INSTDIR\App\C1.Win.C1SpellChecker.2.dll"
  Delete "$INSTDIR\App\ComponentFactory.Krypton.Toolkit.dll"
  Delete "$INSTDIR\App\Ionic.Zip.dll"
  Delete "$INSTDIR\App\ObjectListView.dll"
  Delete "$INSTDIR\App\English (US).dct"
  Delete "$INSTDIR\App\English (UK).dct"
  Delete "$INSTDIR\App\English (CA).dct"
  Delete "$INSTDIR\App\English (AU).dct"

  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey HKLM "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd
