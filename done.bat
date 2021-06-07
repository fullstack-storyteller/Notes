git add .
git commit -m %1
git push origin main
:: This script can be used to automatically push any changes to repo in main branch
rem now we don't want to copy and place this .bat file in every repo. so we can put it at one place
rem and make that location available in the system environment variable in my computer.
rem control panel...system and security ... system...advanced system settings...advanced tab ... Environment variable...system variables...create a varible Path (if not exists)
rem give the path of the done.bat file and save it.

rem to run this simple give in command prompt .\done.bat "some comment" or .\done "some comment"