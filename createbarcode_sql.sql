create database BarcodeQP
go
use BarcodeQP
go

create table ID01
(
ID01001	int primary key identity(1000,1),
ID01002	varchar(50),
ID01003	varchar(50),
ID01004	int,
ID01005	int
)

create table CF01
(
CF01001	int primary key identity(1000,1),
CF01002	varchar(50),
CF01003	nvarchar(100),
CF01004	varchar(50),
CF01005	varchar(50)
)

create table GD01
(
GD01001	int primary key identity(1000,1),
GD01002	varchar(50),
GD01003	numeric(15,3),
GD01004	int,
GD01005	varchar(50)
)
create table GD02
(
GD02001	int primary key identity(1000,1),
GD02002	varchar(50),
GD02003	varchar(10),
GD02004	varchar(50),
GD02005	datetime
)
create table UR01
(
UR01001	varchar(50) primary key,
UR01002	varchar(50),
UR01003	varchar(50),
UR01004	nvarchar(50),
UR01005	nvarchar(50),
UR01006	varchar(50),
UR01007	datetime,
UR01008	int
)
create table UR02
(
UR02001	varchar(50) primary key,
UR02002	nvarchar(50),
UR02003	nvarchar(50)
)
--drop table UR03
create table UR03
(
UR03001	int primary key identity(1000,1),
UR03002	nvarchar(50),
UR03003	varchar(100),
UR03004	varchar(50),
UR03005	int
)
create table UR04
(
UR04001	int primary key identity(1000,1),
UR04002	nvarchar(50),
UR04003	int
)
--drop table UR05
create table UR05
(
UR05001	varchar(50) primary key,
UR05002	nvarchar(50),
UR05003	datetime,
UR05004	datetime,
UR05005	int,
UR05006	varchar(50),
UR05007	varchar(50),
UR05008	varchar(10)
)
--drop table RW01
create table RW01
(
RW01001	varchar(30) primary key,
RW01002	varchar(50),
RW01003	nvarchar(100),
RW01004	nvarchar(100),
RW01005	nvarchar(10),
RW01006	numeric(15,3),
RW01007	varchar(50),
RW01008	varchar(10),
RW01009	varchar(10),
RW01010	datetime,
RW01011	datetime,
RW01012	varchar(50),
RW01013	nvarchar(100),
RW01014	varchar(50),
RW01015	varchar(10),
RW01016	varchar(10),
RW01017	varchar(10),
RW01018	nvarchar(100),
RW01019	nvarchar(100),
RW01020	varchar(50),
RW01021	nvarchar(100),
RW01022	varchar(50),
RW01023	nvarchar(100),
RW01024	varchar(50),
RW01025	nvarchar(100),
RW01026	int,
RW01027	varchar(50),
RW01028	varchar(50),
RW01029	nvarchar(100),
RW01030	varchar(50),
RW01031	varchar(50),
RW01032	int,
RW01033	varchar(50),
RW01034	varchar(50),
RW01035	varchar(255),
RW01036	varchar(50),
RW01037	datetime,
RW01038	datetime,
RW01039	varchar(10),
RW01040	numeric(15,3),
RW01041	varchar(10),
RW01042	varchar(30),
RW01043	varchar(10)
RW01044	numeric(15,3),
RW01045	numeric(15,3)
)
--drop table RW91
create table RW91
(
RW91001	varchar(30) primary key,
RW91002	varchar(50),
RW91003	nvarchar(100),
RW91004	nvarchar(100),
RW91005	nvarchar(10),
RW91006	numeric(15,3),
RW91007	varchar(50),
RW91008	varchar(10),
RW91009	varchar(10),
RW91010	datetime,
RW91011	datetime,
RW91012	varchar(50),
RW91013	nvarchar(100),
RW91014	varchar(50),
RW91015	varchar(10),
RW91016	varchar(10),
RW91017	varchar(10),
RW91018	nvarchar(100),
RW91019	nvarchar(100),
RW91020	varchar(50),
RW91021	nvarchar(100),
RW91022	varchar(50),
RW91023	nvarchar(100),
RW91024	varchar(50),
RW91025	nvarchar(100),
RW91026	int,
RW91027	varchar(50),
RW91028	varchar(50),
RW91029	nvarchar(100),
RW91030	varchar(50),
RW91031	varchar(50),
RW91032	int,
RW91033	varchar(50),
RW91034	varchar(50),
RW01035	varchar(255),
RW01036	varchar(50),
RW01037	datetime,
RW01038	datetime
)
create table RW02
(
RW02001	int primary key identity(1000,1),
RW02002	varchar(50),
RW02003	datetime,
RW02004	varchar(50),
RW02005	nvarchar(50),
RW02006	varchar(50),
RW02007	nvarchar(50),
RW02008	varchar(50),
RW02009	nvarchar(50),
RW02010	varchar(50),
RW02011	nvarchar(100)
)
create table RW03
(
RW03001	varchar(30) primary key,
RW03002	datetime,
RW03003	varchar(50),
RW03004	nvarchar(50),
RW03005	varchar(50),
RW03006	nvarchar(50),
RW03007	varchar(50),
RW03008	varchar(50)
)
create table RW04
(
RW04001	int primary key identity(1000,1),
RW04002	datetime,
RW04003	varchar(50),
RW04004	varchar(50),
RW04005	varchar(50)
)
create table RW05
(
RW05001	varchar(30) primary key,
RW05002	datetime,
RW05003	varchar(50),
RW05004	varchar(50)
)
create table RW06
(
RW06001	int primary key identity(1000,1),
RW06002	datetime,
RW06003	varchar(50),
RW06004	varchar(50),
RW06005	int,
RW06006	varchar(50),
RW06007	varchar(50),
RW06008	varchar(50),
RW06009	varchar(50)
)
create table RW07
(
RW07001	varchar(30) primary key,
RW07002	datetime,
RW07003	varchar(50),
RW07004	nvarchar(50),
RW07005	int,
RW07006	varchar(50),
RW07007	int,
RW07008 int
)

create table RW08
(
RW08001	varchar(30) primary key,
RW08002	datetime,
RW08003	varchar(50),
RW08004	nvarchar(50),
RW08005	datetime,
RW08006	int,
RW08007	nvarchar(100),
RW08008	int,
RW08009	varchar(50),
RW08010	nvarchar(50),
RW08011	varchar(50),
RW08012	nvarchar(50)
)
create table RW09
(
RW09001	int primary key identity(1000,1),
RW09002	int,
RW09003	varchar(50),
RW09004	datetime,
RW09005	varchar(50),
RW09006	nvarchar(50),
RW09007	varchar(50),
RW09008	nvarchar(50),
RW09009	numeric(15,3),
RW09010	nvarchar(10),
RW09011	numeric(15,3),
RW09012	numeric(15,3),
RW09013	numeric(15,3),
RW09014	numeric(15,3)
)
create table RW10
(
RW10001	int primary key identity(1000,1),
RW10002	datetime,
RW10003	varchar(50),
RW10004	nvarchar(50),
RW10005	varchar(50),
RW10006	varchar(50),
RW10007	varchar(50)
)
create table RW11
(
RW11001	varchar(30) primary key,
RW11002	datetime,
RW11003	varchar(50),
RW11004	nvarchar(50),
RW11005	int
)
create table RW12
(
RW12001	int primary key identity(1000,1),
RW12002	datetime,
RW12003	varchar(50),
RW12004	nvarchar(50),
RW12005	varchar(50),
RW12006	varchar(50)
)
create table RW13
(
RW13001	int primary key identity(1000,1),
RW13002	datetime,
RW13003	varchar(50),
RW13004	varchar(50),
RW13005	varchar(50),
RW13006	varchar(50),
RW13007	varchar(50),
RW13008	nvarchar(50),
RW13009	nvarchar(50),
RW13010	varchar(50),
RW13011	varchar(50),
RW13012	datetime,
RW13013	datetime,
RW13014	numeric(15,3),
RW13015	nvarchar(5),
RW13016	nvarchar(5),
RW13017	varchar(50),
RW13018	varchar(50),
RW13019	nvarchar(50),
RW13020	numeric(15,3),
RW13021	numeric(15,3),
RW13022	varchar(50)
)
--drop table RW18
create table RW18
(
RW18001	varchar(30) primary key,
RW18002	datetime,
RW18003	varchar(50),
RW18004	nvarchar(50),
RW18005	int,
RW18006	varchar(50),
RW18007	nvarchar(50),
RW18008	varchar(30),
RW18009	varchar(30)
)
--drop table RW19
create table RW19
(
RW19001	int primary key identity(1000,1),
RW19002	varchar(10),
RW19003	varchar(50),
RW19004	datetime,
RW19005	varchar(50),
RW19006	nvarchar(50),
RW19007	varchar(50),
RW19008	nvarchar(50),
RW19009	numeric(15,3),
RW19010	nvarchar(10),
RW19011	numeric(15,3),
RW19012	numeric(15,3),
RW19013	varchar(30),
RW19014	varchar(30)
)
--drop table RW20
create table RW20
(
RW20001	int primary key identity(1000,1),
RW20002	datetime,
RW20003	varchar(50),
RW20004	nvarchar(50),
RW20005	varchar(50),
RW20006	varchar(50),
RW20007	varchar(50)
)


--drop table WK01
create table WK01
(
WK01001	varchar(30) primary key,
WK01002	varchar(30),
WK01003	nvarchar(50),
WK01004	numeric(15,3),
WK01005	datetime,
WK01006	datetime,
WK01007	float,
WK01008	int
)
--drop table WK02
create table WK02
(
WK02001	int primary key identity(1000,1),
WK02002	varchar(30),
WK02003	varchar(30),
WK02004	nvarchar(50),
WK02005	numeric(15,3),
WK02006	varchar(5),
WK02007	varchar(5),
WK02008	datetime,
WK02009	numeric(15,3),
WK02010	varchar(30),
WK02011	int,
WK02012	varchar(30),
WK02013	varchar(30),
WK02014	varchar(10)
)
--drop table WK03
create table WK03
(
WK03001	int primary key identity(1000,1),
WK03002	varchar(30),
WK03003	nvarchar(50),
WK03004	varchar(5),
WK03005	varchar(5),
WK03006	varchar(5),
WK03007	varchar(5),
WK03008	varchar(5),
WK03009	int,
WK03010	numeric(15,3)
)
--drop table WK04
create table WK04
(
WK04001	varchar(30),
WK04002	varchar(30),
WK04003	datetime,
WK04004	datetime
)
--drop table WK05
create table WK05
(
WK05001	int primary key identity(1000,1),
WK05002	varchar(50),
WK05003	varchar(50),
WK05004	varchar(50),
WK05005	varchar(50),
WK05006	numeric(15,3),
WK05007	varchar(10),
WK05008	datetime,
WK05009	int,
WK05010 int
)


select * from 



-----------------------
alter proc [dbo].[PROC_GETID]
@TABLE VARCHAR(50),
@NEWID VARCHAR(50) OUTPUT
AS
BEGIN
DECLARE @ID INT
DECLARE @T VARCHAR(30)
DECLARE @L INT
IF NOT EXISTS(SELECT * FROM ID01 WHERE ID01002=@TABLE)
INSERT INTO ID01 VALUES(@TABLE,@TABLE,8,0)

SELECT @ID=ID01005+1,@T=ID01003,@L=ID01004 FROM ID01 WHERE ID01002=@TABLE
UPDATE ID01 SET ID01005=ID01005+1 WHERE ID01002=@TABLE
SET @NEWID='000000000000000000000000'+CONVERT(VARCHAR(50),@ID)
set @T=replace(@T,'[Y]',year(getdate()))
set @T=replace(@T,'[y]',year(getdate())%100)
declare @m varchar(2)
declare @d varchar(2)
set @m=convert(varchar(2),month(getdate()))
set @d=convert(varchar(2),day(getdate()))
if len(@m)=1
set @m='0'+@m
if len(@d)=1
set @d='0'+@d
set @T=replace(@T,'[M]',@m)
set @T=replace(@T,'[D]',@d)
SET @NEWID=@T+SUBSTRING(@NEWID,LEN(@NEWID)-@L+1,@L)
END




alter view viewLoginHistory
as
select UR05.*,UR01005,UR01003,UR01002 from UR05 inner join UR01 on UR05002=UR01001


create view viewUser
as
select UR01.*,UR02002 from UR01 left join UR02 on UR02001=UR01006

alter view viewBillDetails
as
SELECT * FROM RW04 inner join RW01 ON RW04004=RW01001



create view view_RW_pandian
as
select RW12002,RW12003,RW12004,RW12006,RW01001,RW01002,RW01003,RW01012,RW01013,RW01014,RW01015,RW01006,RW01035,RW01008,RW01009,RW01034,
case when RW01001 is not null and RW12001 is not null then N'¡Ì' when RW01001 is null then N'-' when RW12001 is null then N'¡Á' end pdstatus
from RW01
full outer join RW12 on RW12006=RW01001 where RW01032=2 OR RW01032 is null


create view view_USBarcodeGroup
as
select RW13003,RW13005,RW13006,RW13007,RW13008,RW13009,RW13011,RW13015,RW13016,RW13018,RW13019,SUM(RW13014) RW13014 from RW13
group by RW13003,RW13005,RW13006,RW13007,RW13008,RW13009,RW13011,RW13015,RW13016,RW13018,RW13019

select * from FG09





select * from WK01
SELECT * FROM WK02