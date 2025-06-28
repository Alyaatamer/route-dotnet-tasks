use iti

--Retrieve a number ofstudents who have a value in their age.
select count(s.St_Id)
from Student s
where s.St_Age is not null

--Display student with the followingFormat(use isNullfunction)
select s.St_Id , isnull(s.St_Fname,s.St_Lname) , d.Dept_Namefrom Student s ,Department dwhere s.Dept_Id=d.Dept_Id/*3.Select instructor name and his salary but if there is no salary display value ‘0000’.
“use one of Null Function”
*/
select ins.Ins_Name , isnull(ins.Salary,0000) 
from Instructor ins

--4.Display max and min salary for instructorsselect max(ins.Salary),min(ins.Salary)from Instructor ins--5.Select Average Salary for instructorsselect avg(ins.Salary)from Instructor ins/*6.Display instructors who have salaries less than the average salary of all instructors.*/select ins.Ins_Namefrom Instructor inswhere ins.Salary<(select avg(Salary) from Instructor)/*7.Display the Department name that contains the instructor who receives the
minimum salary
*/
select d.Dept_Name 
from Department d , Instructor ins
where d.Dept_Id=ins.Dept_Id and ins.Salary=(select min(Salary) from Instructor)

--8. Select max two salaries in instructor table.
select top 2 max(salary) 
from Instructor ins


--9. Display number of courses for each topic name
select t.Top_Name,count(c.Top_Id)
from Course c , Topic t
where c.Top_Id=t.Top_Id
group by t.Top_Name


--10. Select Supervisor first name and the count of students who supervises on them
select s1.St_Fname ,count(s2.St_super)
from Student s1, Student s2
where s1.St_Id = s2.St_super
group by s1.St_Fname


