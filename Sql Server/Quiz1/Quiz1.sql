use MyCompany

--1. Display the employee First name, last name, Salary and Department number
select e.Fname, e.Lname , e.Salary ,e.Dno
from Employee e 

use iti
--2. Display max and min salary for instructors
select max(ins.Salary) , max(ins.Salary)
from Instructor ins

/*
3. Display instructor Name and Department Name Note: display all the instructors
if they are attached to a department or not.*/select ins.Ins_Name , d.Dept_Namefrom Instructor ins left outer join Department don d.Dept_Id=ins.Dept_Id --4. Display the instructors who teach more than 3 courses.select ins.Ins_Namefrom Instructor ins , Ins_Course ins_c , Course cwhere ins.Ins_Id=ins_c.Ins_Id and c.Crs_Id = ins_c.Crs_Id and c.Crs_Id>3/*5. Find the departments with the highest number of students. (by descending order)*/select d.Dept_Id , count(s.St_Id)from Student s , Department dwhere d.Dept_Id=s.Dept_Id group by d.Dept_Idorder by count(s.St_Id) desc--6. List all the courses and the number of students enrolled in each. select c.Crs_Name , s.St_Fnamefrom Course c , Student s , Stud_Course stwhere c.Crs_Id=st.Crs_Id and s.St_Id=st.St_Id/*7. Write a query that displays Full name of a Student who has more than 3 letters in
his/her First Name*/select s.St_Fname+' '+s.St_Lname as [Full name]from Student swhere len(s.St_Fname)>3