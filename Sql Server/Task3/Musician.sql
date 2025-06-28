create database musician

use musician

---------------------------
create table musician
(
	id int primary key,
	name varchar(20),
	ph_number nvarchar(20),
	city varchar(20),
	street varchar(30)
)

---------------------------
create table instrument
(
	name varchar(30) primary key,
	key_ins int 
)

---------------------------
create table album
(
	id int primary key,
	title varchar(30),
	date date,
	mus_id int references musician(id)
)

---------------------------
create table song
(
	title varchar(20) primary key ,
	author varchar(30)
)

---------------------------
create table album_song
(
	album_id int references album(id),
	song_title varchar(20) references song(title) primary key
)

---------------------------
create table mus_song 
(
	mus_id int references musician(id),
	song_title varchar(20)references song(title),
	primary key(mus_id,song_title)
)

---------------------------
create table mus_instrument
(
	mus_id int references musician(id),
	ins_name varchar(30) references instrument(name) ,
	primary key(mus_id,ins_name)
)

