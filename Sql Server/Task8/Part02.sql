use iti 

/*
1. Create a stored procedure to show the number of students per
department.[use ITI DB]
*/

create proc sp_show 
as
	select d.Dept_Id , count(s.St_Id)
	from Student s , Department d
	where d.Dept_Id=s.Dept_Id
	group by d.Dept_Id

sp_show 


use MyCompany
/*
2. Create a stored procedure that will check for the Number of employees
in the project 100 if they are more than 3 print message to the user
“'The number of employees in the project 100 is 3 or more'” if they are
less display a message to the user “'The following employees work for
the project 100'” in addition to the first name and last name of each one.
[MyCompany DB]
*/
create proc sp_check 
as
	declare @count int = (
		select count(e.SSN) 
		from Employee e , Works_for wf , Project p 
		where p.Pnumber=wf.Pno and e.SSN = wf.ESSn and p.Pnumber=100
	)

	if @count >= 3
		print 'The number of employees in the project 100 is 3 or more'
	else
		print 'The following employees work for the project 100'
			select e.Fname , e.Lname
     		from Employee e 
			where @count<3

sp_check
		

/*
3. Create a stored procedure that will be used in case an old employee has
left the project and a new one becomes his replacement. The procedure
should take 3 parameters (old Emp. number, new Emp. number and the
project number) and it will be used to update works_on table.
[MyCompany DB]
*/
create proc sp_replace @old int , @new int , @project_number int
as
	update Works_for
	set ESSn=@new
	where essn=@old and Pno=@project_number

sp_replace 669955 ,669955 , 400