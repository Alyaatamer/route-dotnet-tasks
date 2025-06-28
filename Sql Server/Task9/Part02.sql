use MyCompany

/*
Create a trigger that prevents the insertion Process for
Employee table in March.
*/
create trigger insertion_in_march
on employee 
with encryption
instead of insert 
as
	if month(getdate()) = 3
		print 'insertion Process for Employee table in March not allowed'
	else 
		insert into Employee(Fname,Lname,Salary)
		values ('aaa','aaa',21332)

