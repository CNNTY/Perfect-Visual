
@echo off 
TITLE ����ѩ����DMS���и���
color 0a
@echo off 
set /p input=����������1��2ѡ��Ҫ���е�ϵͳ��1��ʾ���� 2��ʾѩ�������� 
if "%input%"=="1" goto 1 
if "%input%"=="2" goto 2 
pause 
exit 

:1
echo ������ѡ����Ƕ������DMS
regedit /s ����DMSϵͳע�����.reg 
start "c:\windows\system32\cmd.exe"
pause 
exit 

:2 
echo ������ѡ����Ƕ���ѩ����DMS 
regedit /s ѩ����DMSϵͳע�����.reg /s
start "c:\windows\system32\cmd.exe"
pause 
exit ����


