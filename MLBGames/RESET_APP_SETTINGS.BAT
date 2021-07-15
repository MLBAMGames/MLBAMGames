@ECHO OFF
ECHO Reset MLBGames to its default settings.
ECHO If you continue, it will remove all user settings from any MLBGames current or older versions on your system.
PAUSE
DEL /S /q "%userprofile%\AppData\Local\MLBGames\*"
PAUSE
