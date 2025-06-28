use iti

/*
Create an index on column (Hiredate) that allows you
to cluster the data in table Department. What will
happen?
*/

-- error because in table shoud be one Clustered Index(primary key in table)



/*
Create an index that allows you to enter unique ages
in the student table. What will happen?
*/
create unique index unique_ages
on student(st_age) --error because duplicate ages 
-- no two students have the same age 

/*
Try to Create Login Named(RouteStudent) who can
access Only student and Course tables from ITI DB
then allow him to select and insert data into tables
and deny Delete and update
*/
create login RouteStudent
with password = '123'

create user RouteStudentUser
for login RouteStudent

grant select , insert on student to RouteStudentUser
grant select , insert on course to RouteStudentUser

deny delete , update on student to RouteStudentUser
deny delete , update on course to RouteStudentUser


