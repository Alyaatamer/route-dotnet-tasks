use MyCompany

/*
1. Display the data of the department which has the smallest employee ID
over all employees' ID.*/select d.* from Departments d ,Employee ewhere d.MGRSSN=(select min(ssn) from Employee)--2. List the lastname of all managers who have no dependents
select e.Lname 
from Employee e ,Departments d , Dependent ds
where e.SSN=d.MGRSSN and d.MGRSSN!=ds.ESSN


--3. Display the employee number and name if he/she has at least one dependent
select e.SSN , e.Fname 
from Employee e , Dependent d
where e.SSN=d.ESSN


--(use exists keyword)self-study.
SELECT e.Superssn
FROM Employee e
WHERE EXISTS
(SELECT d.ESSN FROM Dependent d WHERE e.Superssn=512463);

/*
4. For each project, list the project name and the total hours per week (for
all employees) spent on that project.
*/
select e.Fname,p.Pname , wf.Hours
from Project p , Works_for wf, Employee e
where p.Pnumber=wf.Pno and e.SSN=wf.ESSn


/*
5. For each department, retrieve the department name and the maximum,
minimum and average salary of its employees
*/
select d.Dname , max(salary),min(salary),avg(salary)
from Departments d , Employee e
group by d.Dname

/*
6. For each department if its average salary is less than the average salary
of all employees display its number, name and number of its employees.*/select d.Dnum ,d.Dname , count(e.SSN)from Departments d , Employee ewhere d.Dnum=e.Dno and avg(salary)<(select avg(salary) from Employee) order by d.Dnum , d.Dname