/*
Create a table named ‘ReturnedBooks’ With the
Following Structure :
UserSSN  BookId   DueDate  ReturnDate  fees
*/
create table ReturnedBooks
(
	UserSSN int primary key,
	BookId int ,
	duedate date ,
	ReturnDate date ,
	fees decimal(10,2)
)

/*
then create A trigger that instead of inserting the data
of returned book checks if the return date is the due
date or not if not so the user must pay a fee and it
will be 20% of the amount that was paid before.
*/
create trigger tri
on ReturnedBooks
instead of insert 
as
	if (select i.ReturnDate from inserted i) != (select i.duedate from inserted i)
		select i.fees*0.2 from inserted i



/*
Create a trigger to prevent anyone from Modifying or
Delete or Insert in the Employee table ( Display a
message for user to tell him that he can’t take any
action with this Table)
*/
create trigger trig
on employee
with encryption 
instead of insert , update , delete 
as
	Print 'You Can''t Do Any DML Commands In Employee Table'


/*
Testing Referential Integrity , Mention What Will
Happen When:
Create an index on column (Salary) that allows you
to cluster the data in table Employee.
*/
create clustered index EmpSalary
on employee (salary) --error 
--because table can have only one clustered index


/*
Try to Create Login With Your Name And give
yourself access Only to Employee and Floor tables
then allow this login to select and insert data into
tables and deny Delete and update (Don't Forget To
take screenshot to every step)
*/
create login alyaa
with password = 'alyaa'

create user alyaauser
for login alyaa

grant select , insert on Employee to alyaauser
deny delete , update on Employee to alyaauser