use iti 

------------------join + DML-------------------------

select s.St_Address,sc.Grade
from Student s join Stud_Course sc
on s.St_Id=sc.St_Id
where s.St_Address='cairo'

---update 
update sc
set sc.Grade+=10
from Student s join Stud_Course sc
on s.St_Id=sc.St_Id
where s.St_Address='cairo'

------------------------------
select s.St_Address,sc.Grade
from Student s join Stud_Course sc
on s.St_Id = sc.St_Id
where s.St_Address='alex'


--delete 
delete sc
from Student s join Stud_Course sc
on s.St_Id = sc.St_Id
where s.St_Address='alex'

---------------------Aggragate Functions----------------------------
--count
select count(*)
from Student

select count(salary)
from Instructor 

--sum
select sum(salary) [sum of salaries]
from Instructor 

select distinct dept_id , sum(salary) over (partition by dept_id)
from Instructor ins

--avg
select sum(salary)/count(salary)
from Instructor

select avg(salary)
from Instructor

--max min
select max(salary) , min(salary)
from Instructor

select Dept_Id , max(salary) over (partition by dept_id) [Max] ,
min(salary) over (partition by dept_id) [Min]
from Instructor

---------------------Null Functions----------------------------

--isnull
select s.St_Fname , isnull(s.St_Lname , 'No Data' )
from Student s

select s.St_Fname+' '+isnull(s.st_lname ,' ') [Full Name]
from Student s

select s.St_Fname , isnull(s.St_Lname , isnull(s.St_Address,'no data') )
from Student s

--coalesce 
select s.St_Fname , coalesce(s.St_Lname , s.St_Address,'no data' )
from Student s

---------------------DateTime Functions----------------------------
select getdate()

select GETUTCDATE()

select SYSDATETIME() --datetime2(7) 7-->msec  
select SYSUTCDATETIME()

select day(getdate())
select month(getdate())
select year(getdate())

select eomonth(getdate())

select datename(dayofyear,getdate()) 

select datename(WEEKDAY,getdate()) 

select datepart(WEEKDAY,getdate())

select isdate('2-25-2025')

---------------------Casting Functions----------------------------
--convert (type , expression)
select s.St_Fname+' '+convert(varchar(20),s.St_Age)
from Student s

select convert(varchar(50),getdate(),101)
select convert(varchar(50),getdate(),131)
select convert(nvarchar(50),getdate(),130)

--cast ( expression as type)
select s.St_Fname+' '+cast(s.St_Age as varchar(20))
from Student s

--Parse  try_parse()
Select Parse('Thursday, 14 November 2024' as Date USING 'en-US')

SELECT PARSE('$345,98' AS money USING 'en-US')

Select Try_Parse('$345,98' AS money USING 'de-DE')

---------------------String Functions----------------------------

--upper/lower
select upper(st_fname)
from Student

select lower(st_fname)
from Student

--len
select st_fname,len(st_fname) as length
from Student

--substring
select st_fname,substring(st_fname,1,3) 
from Student

--concat
select concat(st_fname,' ',st_lname)
from Student 

select concat(st_fname,' ',St_Age)
from Student -- null => empty

--concat_ws
select concat_ws('_', st_fname,st_lname)
from Student 

--ascii   
--char
select ascii('a')
select char(97)

select trim('                 Alyaa Tamer             ')
select ltrim('                 Alyaa')
select rtrim('Alyaa             ')

--left/right 
select left(st_fname,2) ,right(st_fname,2)
from Student

---------------------------------------------------
--Format

select format(123456789,'##-###-####')

select format(getdate(),'dd-mm-yyyy')

---------------------group by----------------------------

select ins.Dept_Id , max(ins.Salary)
from Instructor ins
group by ins.Dept_Id


select ins.Dept_Id ,count(ins.Ins_Id)
from Instructor ins
group by dept_id
having count(ins_id)>3