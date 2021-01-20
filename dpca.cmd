
@echo off 
TITLE 标致雪铁龙DMS运行辅助
color 0a
@echo off 
set /p input=请输入数字1或2选择要运行的系统（1表示标致 2表示雪铁龙）： 
if "%input%"=="1" goto 1 
if "%input%"=="2" goto 2 
pause 
exit 

:1
echo 您现在选择的是东风标致DMS
regedit /s 标致DMS系统注册表项.reg 
start "c:\windows\system32\cmd.exe"
pause 
exit 

:2 
echo 您现在选择的是东风雪铁龙DMS 
regedit /s 雪铁龙DMS系统注册表项.reg /s
start "c:\windows\system32\cmd.exe"
pause 
exit 　　


