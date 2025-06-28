use Library

/*
1. Write a query that displays Full name of an employee who has more than
3 letters in his/her First Name
*/
select e.Fname+' '+e.Lname [FullName]
from Employee e
where len(e.Fname)>3 


/*
2. Write a query to display the total number of Programming books
available in the library with alias name ‘NO OF PROGRAMMING
BOOKS’
*/
select count(b.Id) [NO OF PROGRAMMING BOOKS]
from Book b
where b.Title='Programming'


/*
3. Write a query to display the number of books published by
(HarperCollins) with the alias name 'NO_OF_BOOKS'.
*/
select count(b.Id) [NO_OF_BOOKS]
from Book b join Publisher p
on p.Id=b.Publisher_id
where p.Name = 'HarperCollins'


/*
4. Write a query to display the User SSN and name, date of borrowing and due date of
the User whose due date is before July 2022.
*/
select u.SSN , u.User_Name , b.*
from Users u join Borrowing b
on u.SSN=b.User_ssn
where b.Due_date < '2022-07-01'


/*
5. Write a query to display book title, author name and display in the
following format,
' [Book Title] is written by [Author Name].
*/
select b.Title+' is written by '+a.Name
from Book b , Author a , Book_Author ba
where b.Id=ba.Book_id and a.Id=ba.Author_id


/*
6. Write a query to display the name of users who have letter 'A' in their
names.
*/
select u.User_Name
from Users u
where u.User_Name like '%a%'


/*
7. Write a query that display user SSN who makes the most borrowing
*/
select top(1) u.SSN 
from Users u , Borrowing b
where u.SSN=b.User_ssn 
group by u.SSN
order by count(u.SSN) desc


/*
8. Write a query that displays the total amount of money that each user paid
for borrowing books.
*/
select u.User_Name , sum(b.Amount)
from Users u , Borrowing b
where u.SSN=b.User_ssn
group by u.User_Name



/*
9. write a query that displays the category which has the book that has the
minimum amount of money for borrowing. 
*/
select c.Cat_name
from Book b , Category c , Borrowing bw
where c.Id=b.Cat_id and b.Id=bw.Book_id 
and bw.Amount = (
						select  min(bw.Amount)
						from Book b , Borrowing bw
						where b.Id=bw.Book_id
				)


/*
10.write a query that displays the email of an employee if it's not found,
display address if it's not found, display date of birthday
*/
select coalesce(e.Email , e.Address , cast(e.DOB as varchar(30)) ) 
from Employee e


/*
11.Write a query to list the category and number of books in each category
with the alias name 'Count Of Books'.
*/
select c.Cat_name , count(b.Id) [Count Of Books]
from Category c , Book b
where c.Id=b.Cat_id
group by c.Cat_name


/*
12.Write a query that display books id which is not found in floor num = 1
and shelf-code = A1.
*/
select b.Id 
from Book b , Floor f , Shelf s
where s.Code=b.Shelf_code and f.Number=s.Floor_num and not (f.Number=1 and s.Code='A1')



/*
13.Write a query that displays the floor number , Number of Blocks and
number of employees working on that floor
*/
select f.Number , f.Num_blocks , count(e.Id)
from Floor f , Employee e
where f.Number=e.Floor_no
group by f.Number , f.Num_blocks


/*
14.Display Book Title and User Name to designate Borrowing that occurred
within the period ‘3/1/2022’ and ‘10/1/2022’.
*/
select b.Title , u.User_Name
from Book b , Users u , Borrowing bw
where b.Id=bw.Book_id and u.SSN=bw.User_ssn
and bw.Due_date between '3/1/2022' and '10/1/2022'

/*
15.Display Employee Full Name and Name Of his/her Supervisor as
Supervisor Name.
*/
select e1.Fname+' '+e1.Lname [Full Name] , e2.Fname+' '+e2.Lname [Supervisor Name]
from Employee e1 , Employee e2
where e1.Super_id=e2.Id

/*
16.Select Employee name and his/her salary but if there is no salary display
Employee bonus.
*/
select e.Fname+' '+e.Lname , isnull(e.Salary,e.Bouns)
from Employee e


--17.Display max and min salary for Employees
select max(e.Salary) , min(e.Salary)
from Employee e


/*
18.Write a function that take Number and display if it is even or odd
*/
 create function CheckEvenOrOdd (@number int)
 returns varchar(30)
 begin
	declare @result varchar(20)

		if @number % 2 =0
			set @result = 'The Number is Even'
		else 
			set @result = 'The Number is Even'
		return @result
 end

 select dbo.checkevenorodd (2)


/*
19.write a function that take category name and display Title of books in that
category 
*/
create function DisplayTitleOfBook (@cat_name varchar(30))
returns varchar(30)
begin
	declare @title varchar(30)
		select @title= b.Title
		from Category c , Book b
		where c.Id=b.Cat_id and c.Cat_name=@cat_name
	return @title
end

select dbo.DisplayTitleOfBook('programming ')


/*
20. write a function that takes the phone of the user and displays Book Title ,
user-name, amount of money and due-date.
*/
create function DisplayData(@phone varchar(11))
returns table
as
	return
	(
		select b.Title , u.User_Name , bw.Amount , bw.Due_date
		from Book b , User_phones up , Users u , Borrowing bw
		where b.Id=bw.Book_id and u.SSN=up.User_ssn and u.SSN=bw.User_ssn and up.Phone_num=@phone
	)

select * from dbo.DisplayData('0102302155')

/*
21.Write a function that take user name and check if it's duplicated
return Message in the following format ([User Name] is Repeated
[Count] times) if it's not duplicated display msg with this format [user
name] is not duplicated,if it's not Found Return [User Name] is Not
Found
*/
create function CheckDuplicate (@name varchar(30))
returns varchar(30)
begin
		declare @msg varchar(100), @cnt int

		select @cnt=count(u.User_Name)
		from Users u
		where u.User_Name=@name
		
		if @cnt > 1 
			set @msg = @name+' is Repeated '+cast(@cnt as varchar(10))+' times'
		else if @cnt = 1
			set @msg = @name+' is not duplicated'
		else 
			set @msg = @name+ ' is Not Found'
	return @msg
end

select dbo.CheckDuplicate('Amr Ahmed')

/*
22.Create a scalar function that takes date and Format to return Date With
That Format.
*/
create function DisplayDate(@date date , @formet int)
returns date
begin
		declare @result varchar(100) 
		set @result = (select convert(varchar(50) , @date , @formet )) 
		
	return @result 
end 

select dbo.DisplayDate(getdate() , 101)


/*
23.Create a stored procedure to show the number of books per Category
*/
create proc SP_NumberOfBook 
as
	select c.Cat_name , count(b.Id)
	from Book b , Category c
	where c.Id=b.Cat_id
	group by c.Cat_name

SP_NumberOfBook 


/*
24.Create a stored procedure that will be used in case there is an old manager
who has left the floor and a new one becomes his replacement. The
procedure should take 3 parameters (old Emp.id, new Emp.id and the
floor number) and it will be used to update the floor table.
*/
create proc SP_Replace (@old int , @new int , @floornumber int)
as
	update Floor
	set MG_ID=@new
	where MG_ID=@old and Number=@floornumber

exec sp_replace 3 , 2 , 1

/*
25.Create a view AlexAndCairoEmp that displays Employee data for users
who live in Alex or Cairo.
*/
create view AlexAndCairoEmp
as
		select  e.*
		from Employee e , Users u
		where e.Id = u.Emp_id and (e.Address = 'Alex' or e.Address = 'Cairo')


select * from AlexAndCairoEmp


/*
26.create a view "V2" That displays number of books per shelf
*/
create view V2
as
		select s.Code , count(b.Title) [number of books]
		from Book b , Shelf s
		where s.Code=b.Shelf_code
		group by s.Code

select * from v2

/*
27.create a view "V3" That display the shelf code that have maximum
number of books using the previous view "V2"
*/
create view V3
as
	select *
	from V2
	where [number of books] = (select max([number of books]) from V2)


select * from v3


sp_help users;
--28.Create a table named ‘ReturnedBooks’ With the Following Structure : 
create table ReturnedBooks
(
	id int primary key identity ,
	user_ssn varchar(50) foreign key references users(ssn) ,
	book_id int foreign key references book(id) ,
	due_date date ,
	return_date date,
	fees decimal(10,2)
)
/*
then create A trigger that instead of inserting the data of returned book
checks if the return date is the due date or not if not so the user must pay
a fee and it will be 20% of the amount that was paid before.
*/
create trigger trig_check
on ReturnedBooks
instead of insert 
as
	if (select i.return_date from inserted i) != (select i.due_date from inserted i)
		select i.fees*0.2 from inserted i



/*
29.In the Floor table insert new Floor With Number of blocks 2 , employee
with SSN = 20 as a manager for this Floor,The start date for this manager
is Now. Do what is required if you know that : Mr.Omar Amr(SSN=5)
moved to be the manager of the new Floor (id = 7), and they give Mr. Ali
Mohamed(his SSN =12) His position .
*/
insert into Floor
values(7,2,20,getdate())

update Floor
set MG_ID=5
where Number=7

update Employee
set Id=20
where Fname = 'Ali' and Lname='Mohamed' and Id=12 --can't update identity column 


/*
30.Create view name (v_2006_check) that will display Manager id, Floor
Number where he/she works , Number of Blocks and the Hiring Date
which must be from the first of March and the end of May 2022.this view
will be used to insert data so make sure that the coming new data must
match the condition then try to insert this 2 rows and 
*/
create view v_2006_check
as
	select f.*
	from Floor f
	where f.Hiring_Date between '2022-03-01' and '2022-05-31'
with check option 


insert into v_2006_check
values(2, 6, 2, '2023-08-07') --error because not match condtion 

insert into v_2006_check
values(4, 7, 1, '2022-08-04') --error because not match condtion 

/*
31.Create a trigger to prevent anyone from Modifying or Delete or Insert in
the Employee table ( Display a message for user to tell him that he can’t
take any action with this Table)
*/
create trigger Cannot_Change
on employee
instead of update , delete , insert
as
	print 'can’t take any action with this Table'



/*
32.Testing Referential Integrity , Mention What Will Happen When:
*/

--A. Add a new User Phone Number with User_SSN = 50 in User_Phones Table
insert into User_phones(user_ssn)
values(50) --(error) Cannot insert the value NULL into column 'Phone_num'


--B. Modify the employee id 20 in the employee table to 21
update Employee
set Id=21
where Id=20 --can’t take any action with this Table

--C. Delete the employee with id 1
delete from Employee
where Id=1 --can’t take any action with this Table

--D. Delete the employee with id 12
delete from Employee
where id=12 --can’t take any action with this Table

/*
E. Create an index on column (Salary) that allows you to cluster the
data in table Employee. 
*/
create clustered  index idx_salary
on employee(salary) --Cannot create more than one clustered index on table Student


/*
33.Try to Create Login With Your Name And give yourself access Only to
Employee and Floor tables then allow this login to select and insert data
into tables and deny Delete and update (Don't Forget To take screenshot
to every step)
*/
create login alyaalogin
with password = 'alyaa'

create user alyaauser
for login alyaalogin

grant select , insert on Employee to alyaauser
grant select , insert on Floor to alyaauser

deny delete , update on Employee to alyaauser
deny delete , update on Floor to alyaauser