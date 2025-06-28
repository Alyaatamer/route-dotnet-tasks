use MyCompany

---Display all the employees Data
select *
from employee
-------------------------------------------------

---Display the employee First name, last name, Salary and Department number
select e.Fname,e.Lname,e.Salary,e.Dno
from Employee E

-------------------------------------------------

/*
If you know that the company policy is 
to pay an annual commission for each employee with specific percent equals 10% 
of his/her annual salary 
.Display each employee full name 
and his annual commission in an ANNUAL COMM column (alias)
*/

select e.Fname+' '+e.Lname as FullName
, e.Salary*12*0.1 as [ANNUAL COMM]
from Employee e

-------------------------------------------------

/*
Display the employees Id, 
name who earns more than 1000 LE monthly.
*/
select e.Fname
from Employee e
where e.Salary>1000

-------------------------------------------------

/*
Display the employees Id, 
name who earns more than 10000 LE
annually.
*/
select e.Fname
from Employee e
where e.Salary*12>10000

-------------------------------------------------

/*
Display the names and 
salaries of the female employees
*/

select e.Fname+' '+e.Lname as FullName , e.Salary
from Employee e
where e.Sex = 'F'
-------------------------------------------------
/*
Display each department id, name which is managed by a manager
with id equals 968574.
*/
select d.Dnum ,d.Dname
from Departments d
where d.MGRSSN=968574

-------------------------------------------------
/*
Display the ids, names and locations of the projects which are
controlled with department 10. 
*/

select p.Pnumber ,p.Pname , p.Plocation
from Project p
where p.Dnum=10