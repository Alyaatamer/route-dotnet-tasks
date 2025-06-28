-- single line comment (ctrl + k + c) 

/*
	muliple
	lines
	comments
*/

 --uncomment ( ctrl + k + u )

 --------------------------------------------------------------
 --variables 
 -- Global 
 print @@servername
 print @@error
 print @@version

 --local
 declare @name varchar(10) = 'alyaa'
print @name 

--------------------------------------------------------------
--create dp and table
create database company

use company

create table employee
(
	ssn int primary key,
	fname varchar(30) not null,
	lname varchar(30),
	gender char(1),
	bd date,
	address varchar(20) default 'cairo',
	dep_id int
)

--------------------------------------------------------------
-- alter

alter table employee
add id varchar(30)

alter table employee
alter column id int

alter table employee
drop column id

alter table employee
add foreign key (dep_id) references employee(ssn) 

--------------------------------------------------------------
-- drop

drop table employee

drop database company