create database iti

use iti
---------------------------

create table students
(
	id int primary key ,
	fname varchar(30) not null,
	lname varchar(30),
	age int ,
	address varchar(50),
	dep_id int
)
---------------------------

create table departments
(
	id int primary key,
	name varchar(30) not null,
	hiring_date date,
	ins_id int
)
---------------------------

alter table students 
add constraint fk_dep_id
foreign key(dep_id) references departments(id)

---------------------------

create table instructors
(
	id int primary key identity,
	name varchar(30) not null,
	address varchar(50),
	bonus dec(7,2),
	salary money ,
	hour_rate time ,
    dep_id int references departments(id)
)

---------------------------

create table courses
(
	id int primary key,
	name varchar(30),
	duration int ,
	descripition varchar(100),
	top_id int
)
---------------------------

create table topics 
(
	id int primary key,
	name varchar(30)
)
---------------------------

alter table courses 
add constraint fk_top_id
foreign key(top_id) references topics(id)

---------------------------

create table stud_course
(
	stud_id int references students(id),
	course_id int references courses(id),
	grade char(1) , 
	primary key (stud_id,course_id)
)

---------------------------
create table course_instructor
(
	course_id int references courses(id),
	ins_id int references instructors(id),
	evaluation varchar(30),
	primary key (course_id,ins_id)
)