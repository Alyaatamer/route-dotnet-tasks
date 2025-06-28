use MyCompany

/*
1. Display the data of the department which has the smallest
employee ID over all employees' ID.
*/
select d.* 
from Departments d , Employee e
where d.Dnum=e.Dno and e.SSN = (select top(1)ssn from Employee)

--2. List the last name of all managers who have no dependents

select e.Lname
from Employee e , Dependent d
where e.Superssn = d.ESSN and e.Superssn is not null and e.ssn!=d.ESSN

/*
3. Display the employee number and name if he/she has at least one
dependent (use exists keyword)self-study.
*/
select e.SSN , e.Fname
from Employee e 
where exists(
    select 1
	from Dependent d
	where e.SSN = d.ESSN
)

/*
4. For each department-- if its average salary is less than the
average salary of all employees display its number, name and
number of its employees.
*/
select e.Salary , e.Fname , e.SSN
from Employee e , Departments d
where e.Dno=d.Dnum and Salary < (select avg(salary) from Employee)
order by e.Dno
