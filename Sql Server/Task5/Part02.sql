use iti 

/*
Display instructor Name and Department Name Note: display all the
instructors if they are attached to a department or not.
*/
select ins.Ins_Name , d.Dept_Name
from Instructor ins left outer join Department d
on ins.Dept_Id = d.Dept_Id

/*
Display student full name and the name of the course he is taking for only
courses which have a grade.
*/
select concat(s.St_Fname,' ',s.St_Lname) [Full name], c.Crs_Name
from Student s , Course c , Stud_Course sc
where s.St_Id=sc.St_Id and c.Crs_Id=sc.Crs_Id and sc.Grade is not null


--Select Student first name and the data of his supervisor.select s1.St_Fname , s2.*from Student s1 , Student s2where s1.St_Id=s2.St_super--4. Display student with the following Format.select s.St_Id as [Student ID] , 
concat(s.St_Fname,' ',s.St_Lname) [Student Full Name],s.Dept_Id as [Department name]from Student s