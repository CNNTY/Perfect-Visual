use master;
select * from sysdatabases where name='Perfect'
drop database Perfect;
create database Perfect
go
use Perfect;
if exists(select * from sysobjects where name='Pinfo')
drop table Pinfo
create table Pinfo --错误添加表
(
 --ID INT identity(100,1),
 P_ID uniqueidentifier,   
 P_Code VARCHAR(80) primary key,    --错误代码
 P_Info NVARCHAR(400) not null,   --错误信息  
 P_Answer nvarchar(400) not null,  --处理方法
)
insert into Pinfo VALUES(newID(),'0X854894','WERF限制，无法完成该操作','关闭或卸载360安全卫士') --测试数据
go
insert into Pinfo VALUES(newID(),'0X2215645','错误503','查看证书是否安装') --测试数据
go
insert into Pinfo VALUES(newID(),'0X651255','404 算机限制，无法完成该操作','关闭或卸载360安全卫士') --测试数据
go
insert into Pinfo VALUES(newID(),'0X584984','403问网络，错误503','查看证书是否安装') --测试数据
go
select P_Code,P_Info,P_Answer from Pinfo  where P_CODE like '%12%'and P_info like '%%' --模糊查询
select * from Pinfo
