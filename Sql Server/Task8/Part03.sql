--1. Create a stored procedure that calculates the sum of a given range of numbers
create proc sp_calc @num1 int , @num2 int
as
	select @num1+@num2

sp_calc 1 , 2


--2. Create a stored procedure that calculates the area of a circle given its radius
create or alter proc sp_cal_area @radius decimal(10,2)
as
	declare @area decimal(10,2) = (3.14*(POWER(@radius, 2)))
	select @area

sp_cal_area 7


/*
3. Create a stored procedure that calculates the age category based
on a person's age ( Note: IF Age < 18 then Category is Child
and if Age >= 18 AND Age < 60 then Category is Adult
otherwise Category is Senior)
*/

create proc sp_show_category @age int
as
	if @age < 18 
		print 'Category is Child'
	else if @age >=18 and @age<60
		print 'Category is Adult'
	else 
		print 'Category is Senior'

sp_show_category 20


/*
4. Create a stored procedure that determines the maximum,
minimum, and average of a given set of numbers ( Note : set of
numbers as Numbers = '5, 10, 15, 20, 25')
*/

create OR alter proc sp_determines @string varchar(30)
as
begin
    declare @new_table table (number int)

    declare @size int = 0
	declare @new int 
    declare @num varchar(10)

    while charindex(',', @string , @size+1 ) > 0
    begin
        set @new = charindex(',', @string, @size + 1)
        set @num = substring(@string, @size + 1, @new - @size - 1)
        insert into @new_table values (cast(@num as int))
        set @size = @new
    end

    select 
        max(number) as max_value,
        min(number) as min_value,
        avg(cast(number as float)) as average_value
    from 
        @new_table
end


sp_determines '5, 10, 15, 20, 25'


