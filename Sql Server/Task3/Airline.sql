create database Airline

use Airline

 ---------------------------
create table airline
(
	id int primary key identity,
	name varchar(20) not null,
	address varchar(100),
	cont_person varchar(20)
)
---------------------------

create table airline_phones
(
	id int references airline(id),
	phone nvarchar(20) ,
	primary key(id,phone)
)
---------------------------

create table aircraft
(
	id int primary key,
	capacity int not null,
	model varchar(50),
	maj_pilot varchar(50),
	assistant varchar(50),
	host1 varchar(50),
	host2 varchar(50),
	al_id int references airline(id)
)
---------------------------

create table transactions
(
	id int primary key,
	description varchar(100),
	amount int,
	date date,
	al_id int references airline(id)
)
---------------------------

create table employee
(
	id int primary key,
	name varchar(20),
	address varchar(50),
	gender char(1),
	position varchar(10),
	year int ,
	month int,
	day int,
	al_id int references airline(id)
)
---------------------------

create table qualifications
(
	emp_id int references employee(id),
	qualifications varchar(50),
	primary key(emp_id,qualifications)
)
---------------------------

create table route
(
	id int primary key ,
	distance dec(10,4),
	destination varchar(30),
	origin dec(10,4),
	classification varchar(100)
)
---------------------------

create table aircraft_route
(
	ac_id int references aircraft(id),
	route_id int references route(id),
	departure varchar(50),
	numodpass int ,
	price dec(7,2),
	arrival time ,
	primary key (ac_id,route_id,departure)

)