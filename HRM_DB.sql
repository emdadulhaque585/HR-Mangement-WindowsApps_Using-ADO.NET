Use master 
if exists (select name from sys.sysdatabases where name='HR_MDB')
Drop database HR_MDB
GO
create database HR_MDB
GO
use HR_MDB
GO
create table tblGender
(
	genderId int primary key identity,
	genderName varchar(50) not null
);
select * from tblGender
go
create table tblReligion
(
	religionId int primary key identity,
	religionName varchar(50) not null
);
select * from tblReligion
go
create table tblSection
(
	sectionId int primary key identity,
	sectionName varchar(50) not null
);
select * from tblSection
go
create table tblDepartment
(
	departmentId int primary key identity,
	departmentName varchar(50) not null
);
select * from tblDepartment
go
create table tblCountry
(
	countryId int primary key identity,
	countryName varchar(50) not null
);
select * from tblCountry
go
create table tblCity
(
	cityId int primary key identity,
	cityName varchar(50) not null,
	countryId int foreign key references tblCountry(countryId)
);
select * from tblCity
go
create table tblDesignation
(
	designationId int primary key identity,
	designationName varchar(50) not null,
	departmentId int foreign key references tblDepartment(departmentId)
);
Go
Insert into tblDesignation values('Labour',4)
GO
select * from tblDesignation
go
create table tblEmployee
(
	employeeId int primary key identity,
	employeeName varchar(50) not null,
	employeeAddress varchar(200),
	employeeDOB date not null,
	employeePhone int not null,
	employeeEmail varchar(50),
	employeeCurrentSalary money not null,
	employeeJoiningDate date not null,
	designationId int foreign key references tblDesignation(designationId),
	sectionId int foreign key references tblSection(sectionId),
	departmentId int foreign key references tblDepartment(departmentId),
	genderId int foreign key references tblGender(genderId),
	religionId int foreign key references tblReligion(religionId),
	cityId int foreign key references tblCity(cityId),
	countryId int foreign key references tblCountry(countryId),
);
select * from tblEmployee
go
Update tblEmployee set employeeName='',employeeAddress='',employeeDOB='',employeePhone='',employeeEmail='',employeeCurrentSalary= 1,employeeJoiningDate='',designationId=1,sectionId=1,departmentId=1,genderId=1,religionId=1,cityId=1,countryId=1 where employeeId=1
select * from tblReligion
GO
Delete tblReligion where religionId=10
GO
select * from tblEmployee where employeeId=1
Go
create table tblUser
(
	id Int Primary KEy Identity,
	userName Varchar(50) not null,
	email varchar(30) not null,
	password Varchar(50) not null,
	contactNo Varchar(20) not null,
)
GO
select * from tblUser
GO
 Insert Into tblUser Values('imran','imran@gmail.com','123','01677355887')
 GO
 Select * from tblCity where countryId='1'
 GO
 select e.employeeName,e.employeeAddress,e.employeeDOB,e.employeePhone,e.employeeEmail,e.employeeCurrentSalary,e.employeeJoiningDate,dg.designationId,s.sectionId,de.departmentId,g.genderId,r.religionId,ci.cityId,c.countryId from tblEmployee e  join tblCity ci on e.cityId=ci.cityId  join tblCountry c on e.countryId=c.countryId  join tblDepartment de on e.departmentId=de.departmentId join tblDesignation dg on e.designationId=dg.designationId join tblGender g on e.genderId=g.genderId  join tblReligion r on e.religionId=r.religionId  join tblSection s on e.sectionId=s.sectionId   where e.employeeId=1
 GO
 
 Select distinct e.employeeName,dg.designationName from tblEmployee e 
 Inner join tblDesignation dg on e.designationId=dg.designationId
 where dg.designationId=4
 GO
 select e.employeeId,e.employeeName,e.employeeAddress,e.employeeDOB,e.employeePhone,e.employeeEmail,e.employeeCurrentSalary,e.employeeJoiningDate,dg.designationName,s.sectionName,de.departmentName,g.genderName,r.religionName,ci.cityName,c.countryName from tblEmployee e  join tblCity ci on e.cityId=ci.cityId  join tblCountry c on e.countryId=c.countryId  join tblDepartment de on e.departmentId=de.departmentId join tblDesignation dg on e.designationId=dg.designationId join tblGender g on e.genderId=g.genderId  join tblReligion r on e.religionId=r.religionId  join tblSection s on e.sectionId=s.sectionId