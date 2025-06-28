use iti

/*
1. Create a view that displays the student's full name,
course name if the student has a grade more than 50.
*/
create view display
as
	select s.St_Fname+' '+s.St_Lname [Full Name] , c.Crs_Name
	from Student s , Stud_Course st , Course c
	where s.St_Id = st.St_Id and c.Crs_Id=st.Crs_Id and st.Grade>50

select * from display

/*
2. Create an Encrypted view that displays instructor names
and the topics they teach.
*/
create view display_instructor_name
with encryption
as 
	select ins.Ins_Name , t.Top_Name
	from Instructor ins , Ins_Course ins_c , Topic t , Course c
	where ins.Ins_Id=ins_c.Ins_Id and c.Crs_Id=ins_c.Ins_Id and t.Top_Id= c.Top_Id

select * from display_instructor_name

/*
3. Create a view that will display Instructor Name,
Department Name for the ‘SD’ or ‘Java’ Department “use
Schema binding” and describe what is the meaning of
Schema Binding
*/

create view dbo.vw_displays 
with schemabinding
as
	select ins.Ins_Name , d.Dept_Name
	from dbo.Instructor ins , dbo.Department d 
	where d.Dept_Id=ins.Dept_Id and (d.Dept_Name='sd' or d.Dept_Name='java')
	
select * from dbo.vw_displays 


/*
4. Create a view “V1” that displays student data for students
who live in Alex or Cairo.
Note: Prevent the users to run the following query
Update V1 set st_address=’tanta’
Where st_address=’alex’;
*/

create view v1 
with encryption
as 
select s.*
from Student s
where s.St_Address='Alex' or s.St_Address='Cairo'
with check option 

select * from v1


/*
Create a view that will display the project name and the number of employees working on it.
(Use Company DB)
*/
use MyCompany

create view show
as
	select p.Pname , count(e.SSN) as num_of_employee
	from Employee e , Project p , Works_for wf
	where e.SSN=wf.ESSn and p.Pnumber=wf.Pno
	group by p.Pname

select * from show



-----------------------------------------------------------------------------------------------------------
use IKEA_Company

/*
Create a view named “v_clerk” that will display employee Number, 
project Number, the date of hiring of all the jobs of the type 'Clerk'.
*/
create or alter view v_clerk
as
	select wo.EmpNo , wo.ProjectNo , wo.Enter_Date
	from Works_on wo 
	where wo.Job ='Clerk'

select * from v_clerk

/*
Create view named  “v_without_budget” that will display all the projects data without budget
*/

create view v_without_budget
as
	select p.*
	from hr.Project p 
	where p.Budget is null

select * from v_without_budget

/*
Create view named  “v_count “ that will display the project name and the Number of jobs in it
*/
create view v_count
as
	select p.ProjectName , count(wo.Job) as no_of_jobs
	from hr.Project p , Works_on wo
	where p.ProjectNo=wo.ProjectNo
	group by p.ProjectName

select * from v_count

/*
 Create a view named” v_project_p2” that will display the emp# s for the project# ‘p2’.
 (use the previously created view  “v_clerk”)
 */
create or alter view v_project_p2
as
	select v.EmpNo as emp , v.ProjectNo as project
	from v_clerk v
	where v.ProjectNo=2

select * from v_project_p2

/*
modify the view named “v_without_budget” to display all DATA in project p1 and p2.
*/
create view v_without_budge
as
	select p.*
	from hr.Project p
	where p.ProjectNo=1 or p.ProjectNo=2

select * from v_without_budge

--Delete the views  “v_ clerk” and “v_count”

delete wo
from Works_on wo inner join  hr.Employee e
on e.EmpNo = wo.EmpNo inner JOIN hr.Project p 
oN p.ProjectNo = wo.ProjectNo
where wo.Job = 'Clerk'


delete from v_clerk
delete from v_count


/*
Create view that will display the emp# and emp last name who works on deptNumber is ‘d2’
*/
create view displayss
as
	select e.EmpFname, e.EmpLname
	from hr.Employee e , company.Department d
	where e.DeptNo=d.DeptNo and d.DeptName = 'd2'

select * from displayss

/*
Display the employee  lastname that contains letter “J” (Use the previous view created in Q#7)
*/
select EmpLname
from displayss
where EmpLname like '%J%'

/*
Create view named “v_dept” that will display the department# and department name
*/
create or alter view v_dept
as
	select d.DeptNo,d.DeptName
	from Department d


select * from v_dept

/*
using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’
*/
select v.DeptNo , v.DeptName
from v_dept v
where v.DeptNo=4 and v.DeptName='Development'

/*
Create view name “v_2006_check” that will display employee Number,
the project Number where he works and
the date of joining the project which must be from the first of January and
the last of December 2006.this view will be used to insert data 
so make sure that the coming new data must match the condition
*/

create view v_2006_check
as
	select e.EmpNo , p.ProjectNo , wo.Enter_Date
	from hr.Employee e , Works_on wo , hr.Project p
	where e.EmpNo=wo.EmpNo and p.ProjectNo=wo.ProjectNo and
	wo.Enter_Date between '2006-01-01' and '2006-12-31'

select * from v_2006_check
