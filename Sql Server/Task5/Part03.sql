use MyCompany

--1. Display the Department id, name and id and the name of its manager.
select d.Dnum , d.Dname , e.SSN , e.Fname
from Departments d , Employee e
where e.SSN = d.MGRSSN

/*
2. Display the name of the departments and the name of the projects under its control.
*/
select d.Dname ,p.Pname
from Departments d , Project p
where d.Dnum=p.Dnum

/*
3. Display the full data about all the dependence associated with the name
of the employee they depend on.
*/
select d.* ,e.Fname
from Dependent d , Employee e
where e.SSN=d.ESSN

/*
4. Retrieve the names of all employees in department 10 who work more
than or equal 10 hours per week on the "AL Rabwah" project.
*/
select e.Fname 
from Employee e , Works_for wf , Project p
where e.SSN=wf.ESSn and p.Pnumber=wf.Pno and
e.Dno=10 and wf.Hours>=10 and p.Pname='AL Rabwah'

/*
5. Find the names of the employees who were directly supervised by
Kamel Mohamed*/select e2.Fname from Employee e1 ,Employee e2where e1.SSN=e2.Superssn and e1.Fname+' '+e1.Lname = 'Kamel Mohamed'--Display All Data of the managersselect e.*from Employee e , Departments dwhere e.SSN = d.MGRSSN/*Retrieve the names of all employees and the names of the projects they
are working on, sorted by the project name.
*/
select e.Fname ,p.Pname 
from Employee e ,Project p , Works_for wf
where e.SSN=wf.ESSn and p.Pnumber=wf.Pno
order by p.Pname 

/*
For each project located in Cairo City, find the project number, the
controlling department name, the department manager’s last name,
address and birthdate.
*/
select p.Pnumber , d.Dname , e.Lname , e.Address ,e.Bdate
from Project p , Departments d , Employee e
where p.Plocation='cairo' and d.Dnum=p.Dnum and e.SSN=d.MGRSSN


/*
Display All Employees data and the data of their dependents even if
they have no dependents.
*/      
select e.* ,d.*
from Employee e , Dependent d
where e.SSN=d.ESSN