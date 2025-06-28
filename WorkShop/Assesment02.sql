create function Take_Date(@data date)
returns varchar(20)
begin
	return format(@data ,'MMMM')
end

select dbo.take_date(getdate())

--------------------------------------------------------------

create function take_two_num (@num1 int ,@num2 int)
returns @table table (valuesbetweenthem int)
as
begin
		while @num1<@num2
		begin
			set @num1 += 1
			insert into @table values(@num1)
		end
	 return 
end

select * from take_two_num(1,10)

------------------------------------------------------------------

create view displaystudent
as
	select s.st_fname + ' ' + s.St_Lname [FullName] , c.Crs_Id
	from student s , stud_course sc , course c
	where s.st_id = sc.st_id and c.crs_id =sc.crs_id and sc.grade>50

select * from displaystudent


---------------------------------------------------------------------


create or alter proc sp_show_no_of_students @dept_id int 
as
	select count(s.St_Id) , d.Dept_Name
	from Student s , Department d
	where s.Dept_Id=d.Dept_Id and d.Dept_Id=@dept_id
	group by d.Dept_Name


exec sp_show_no_of_students 20