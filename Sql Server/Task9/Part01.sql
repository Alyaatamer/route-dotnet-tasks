use iti 

/*
• Create a trigger to prevent anyone from inserting a new record in the
Department table ( Display a message for user to tell him that he
can’t insert a new record in that table )*/create or alter trigger preventon departmentwith encryption Instead Of Insert as	print 'can’t insert a new record in that table'insert into Department(dept_id,Dept_Name,Dept_Location)values(453,'sql','cairo')/*Create a table named “StudentAudit”. Its Columns are (Server User
Name , Date, Note)
*/
create table StudentAudit
(
	ServerUserName varchar(50) default SUSER_NAME() , 
	Date date default getdate() , 
	Note varchar(300) 
)

insert into StudentAudit(Note)
values('done')

select * from StudentAudit


/*
Create a trigger on student table after insert to add Row in StudentAudit
table
• The Name of User Has Inserted the New Student
• Date
• Note that will be like ([username] Insert New Row with Key =
[Student Id] in table [table name]
*/
create trigger add_to_StudentAudit
on student
with encryption 
after insert
as
	insert into StudentAudit(ServerUserName,Note)
	select i.St_Fname+' '+i.St_Lname ,
	i.St_Fname+' '+i.St_Lname+' Insert New Row with Key = '+cast(i.St_Id as varchar(30)) + ' in table student' 
	from inserted i


insert into Student(St_Id,St_Fname,St_Lname)
values(123,'alyaa','tamer')
	

/*
Create a trigger on student table instead of delete to add Row in
StudentAudit table
○ The Name of User Has Inserted the New Student
○ Date
○ Note that will be like “try to delete Row with id = [Student Id]”
*/
create trigger  addRowinStudentAudit
on student
with encryption
instead of delete 
as
	insert into StudentAudit(ServerUserName,Note)
	select d.St_Fname+' '+d.St_Lname ,
	'try to delete Row with id = '+ cast(d.St_Id as varchar(30)) 
	from deleted d

delete from Student
where St_Id=123 

