use MyCompany

---1) try to get the max 2 salaries (using subquery)
select max(e.Salary)[Max Salary]
from Employee e
union
select max(e.Salary)
from Employee e
where e.Salary < (select max(salary) from Employee)


use iti
--2) Find the department with the highest number of students 
select top 1 d.Dept_Name ,count(s.St_Id)
from Department d join Student s
on d.Dept_Id=s.Dept_Id
group by d.Dept_Name
order by count(s.St_Id) desc


use NORTHWND
/*
3) write a SQL query to list all products along with their price and category,
and assign a rank to each product for each category based on
the unit price in descending order 
*/
select p.ProductID , p.ProductName , p.UnitPrice , p.CategoryID , 
dense_rank() over(partition by  p.CategoryID order by p.UnitPrice desc ) as DR
from Products p


--4) write a function that take number and display if it is even or odd 
create function CheckEvenOrOdd(@Num int)
returns varchar(20)
begin
		declare @Msg varchar(20)
		if @Num % 2 = 0
			select @msg = 'This Number is Even'
		else 
			select @msg = 'This Number is Odd'
	return @msg
end

select dbo.CheckEvenOrOdd(2)