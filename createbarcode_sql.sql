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
RW01034	varchar(50)
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
RW91034	varchar(50)
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

---------------------
create proc [dbo].[PROC_GETID]
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