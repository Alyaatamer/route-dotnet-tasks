create database sales 

use sales

---------------------------
create table sales_office
(
	number int primary key,
	location varchar(50)
)
---------------------------

create table employee
(
	id int primary key,
	name varchar(50),
	off_number int references sales_office(number)
)
---------------------------

alter table sales_office
add emp_id int

alter table sales_office 
add constraint fk_emp_id
foreign key(emp_id) references employee(id) 

---------------------------

create table property
(
	id int primary key ,
	address varchar(30),
	city varchar(20),
	state varchar(30),
	code int unique,
	off_number int references sales_office(number)
)
---------------------------

create table owner 
(
	id int primary key,
	name varchar(30)
)

---------------------------

create table prop_owner
(
	own_id int references owner(id),
	prop_id int references property,
	primary key(own_id,prop_id),
	precent dec(4,2)
)