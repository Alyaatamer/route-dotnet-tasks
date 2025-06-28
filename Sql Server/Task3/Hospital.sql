create database hospital

use hospital
---------------------------

create table patient 
(
	id int primary key ,
	name varchar(30),
	Dob date 
)
---------------------------

create table ward
(
	id int primary key ,
	name varchar(20)
)
---------------------------

alter table patient 
add ward_id int

alter table patient
add constraint fk_ward_id
foreign key(ward_id) references ward(id) 
---------------------------

create table nurse 
(
	number int primary key ,
	name varchar(20),
	address varchar(50),
	ward_id int references ward(id)
)
---------------------------
alter table ward
add nurse_num int

alter table ward 
add constraint fk_nurse_num
foreign key(nurse_num) references nurse(number)
---------------------------

create table consultant
(
	id int primary key,
	name varchar(30)
)
---------------------------

alter table patient
add con_id int

alter table patient 
add constraint fk_con_id
foreign key (con_id) references consultant(id)
---------------------------

create table patient_con
(
	con_id int references consultant(id),
	pat_id int references patient(id),
	primary key(con_id,pat_id)
)
---------------------------

create table drugs
(
	code int primary key,
	dosage int 
)
---------------------------

create table drug_brand
(
	code int references drugs(code),
	brand varchar(50) ,
	primary key (code,brand)
)

---------------------------
create table nurse_drug_patient
(
	nur_num int references nurse(number),
	drug_cod int references drugs(code),
	pat_id int references patient(id),
	dat date,
	tim time,
	dosage int,
	primary key(pat_id,dat,tim)
)