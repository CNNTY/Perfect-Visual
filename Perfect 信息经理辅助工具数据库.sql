use master;
select * from sysdatabases where name='Perfect'
drop database Perfect;
create database Perfect
go
use Perfect;
if exists(select * from sysobjects where name='Pinfo')
drop table Pinfo
create table Pinfo --������ӱ�
(
 --ID INT identity(100,1),
 P_ID uniqueidentifier,   
 P_Code VARCHAR(80) primary key,    --�������
 P_Info NVARCHAR(400) not null,   --������Ϣ  
 P_Answer nvarchar(400) not null,  --������
)
insert into Pinfo VALUES(newID(),'0X854894','WERF���ƣ��޷���ɸò���','�رջ�ж��360��ȫ��ʿ') --��������
go
insert into Pinfo VALUES(newID(),'0X2215645','����503','�鿴֤���Ƿ�װ') --��������
go
insert into Pinfo VALUES(newID(),'0X651255','404 ������ƣ��޷���ɸò���','�رջ�ж��360��ȫ��ʿ') --��������
go
insert into Pinfo VALUES(newID(),'0X584984','403�����磬����503','�鿴֤���Ƿ�װ') --��������
go
select P_Code,P_Info,P_Answer from Pinfo  where P_CODE like '%12%'and P_info like '%%' --ģ����ѯ
select * from Pinfo
