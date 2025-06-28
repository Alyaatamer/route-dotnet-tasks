use iti

--1. Select max two salaries in the instructor table.
select top(2)ins.Salary
from Instructor ins
order by ins.Salary desc

/*
2. Write a query to select the highest two salaries in Each
Department for instructors who have salaries. “using one of
Ranking Functions”
*/
select * 
from(
select ins.Salary , d.Dept_Id ,  ROW_NUMBER() Over (partition by d.Dept_Id Order by ins.Salary Desc) as RN
from Instructor ins , Department d
where ins.Dept_Id=d.Dept_Id and ins.Salary is not null ) as ranking
where rn<3


/*
3. Write a query to select a random student from each department.
“using one of Ranking Functions”*/select * 
from(
select s.* ,  ROW_NUMBER() Over (partition by s.Dept_Id Order by  NEWID() Desc) as RN
from Student s ) as ranking
where rn=1/*4. Display instructors who have salaries less than the average salary
of all instructors.*/select *from Instructor inswhere ins.Salary < (select avg(salary) from Instructor)