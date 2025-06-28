use iti

/*
1. Create a scalar function that takes a date and returns the
Month name of that date.
*/
create function GetMonth(@d date)
returns varchar(20)
begin
       declare @m varchar(20)
	   SELECT @m = DATENAME(MONTH, @d) 
	   return @m
end

print dbo.getmonth(getdate())

/*
2. Create a multi-statements table-valued function that takes 2 integers 
and returns the values between them.
*/
create function GetValues(@n1 int , @n2 int)
returns @val table (number int )
as
begin
		declare @s int = @n1 

		while @s <= @n2
		begin
			insert into @val 
			values(@s)

			set @s+=1
		end
	return
end

select * from dbo.GetValues(1,10)

/*
3. Create a table-valued function that takes Student No and
returns Department Name with Student full name.
*/
create function GetNameDept(@id int)
returns @t table (name_D varchar(100) , name_s varchar(100) )
as
begin
        insert into @t
		select d.Dept_Name , s.St_Fname+' '+s.St_Lname as FullName 
		from Student s, Department d
		where s.Dept_Id=d.Dept_Id and @id = s.St_Id
	return
end

select * from dbo.GetNameDept(10)

/*
4. Create a scalar function that takes Student ID and returns
a message to user.
a. If first name and Last name are null, then display 'First
name & last name are null.'
b. If First name is null, then display 'first name is null'
c. If Last name is null, then display 'last name is null.'
d. Else display 'First name & last name are not null'
*/
create function Massage(@id int)
returns varchar(100)
begin
       declare @f varchar(20) , @s varchar(20) , @m varchar(100)
	   select @f=s.St_Fname , @s=s.St_Lname
	   from Student s
	   where s.St_Id=@id

	   if @f is null and @s is null
			set @m = 'First name & last name are null.'
	   else if @f is null
			set @m = 'first name is null'
       else if @s is null
			set @m = 'last name is null.'
	   else 
			set @m = 'First name & last name are not null'
	return @m
end

select dbo.massage(10)

/*
5. Create a function that takes an integer which represents the
format of the Manager hiring date and displays department
name, Manager Name and hiring date with this format.
*/
create function GetDateFormat (@format int)
returns @t table ( name_d varchar(30) ,name_m varchar(30) , d date )
as
begin
        insert into @t
		select d.Dept_Name , ins.Ins_Name , format(d.Manager_hiredate, convert(varchar(50),d.Manager_hiredate,@format))
		from Instructor ins , Department d
		where ins.Ins_Id=d.Dept_Manager
	return
end

select * from dbo.GetDateFormat(101)


/*
6. Create a multi-statement table-valued function that takes a
string.
a. If string='first name' returns student first name
b. If string='last name' returns student last name
c. If string='full name' returns Full Name from student
table
Note: Use “ISNULL” function
*/
Create Function GetName (@string varchar(20))
Returns @Name Table  (name varchar(50) )
as
begin 
   if @string = 'first name' 
     Insert into @Name
	 Select isnull(s.St_Fname,'no data')
	 From Student s

   else if @string = 'last name'
     Insert into @Name
	 Select isnull(s.St_Lname,'no data')
	 From Student s

   else if @string = 'full name'
     Insert into @Name
	 Select CONCAT_WS(' ' , isnull(St_Fname,' ') , isnull(St_Lname,' '))
	 From Student

  Return
end

select * from GetName('first name' )

/*
7. Create function that takes project number and display all
employees in this project (Use MyCompany DB)
*/

use MyCompany

create function GetAllEmployee(@projNo int)
returns @table table ( [Employee Name] varchar(50) )
as
begin
		insert into @table
		select CONCAT(E.Fname , E.Lname)
		from Employee E, Project P, Works_for W
		where P.Pnumber = W.Pno 
				and E.SSN = W.ESSn
				and P.Pnumber = @projNo
	return 
end

select * from GetAllEmployee(100)


