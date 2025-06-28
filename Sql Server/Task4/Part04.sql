use MyCompany

/*
1. In the department table insert a new department called
"DEPT IT”, with id 100, employee with SSN = 112233 as a
manager for this department. The start date for this manager
is '1-11-2006'.
*/

insert into Departments(Dname,Dnum,MGRSSN,[MGRStart Date])
values ('DEPT IT',100,112233,'1-11-2006')

-------------------------------------------------
/*
Do what is required if you know that: Mrs. Oha Mohamed
(SSN=968574) moved to be the manager of the new
department (id = 100), and they give you (your SSN =102672)
her position (Dept. 20 manager)
b. Update your record to be department 20 manager.
c. Update the data of employee number=102660 to be in
your teamwork (he will be supervised by you) (your SSN
=102672)*/--a. First try to update her record in the department table.update Employee set Dno=100 where SSN=968574update Departmentsset  MGRSSN=968574where Dnum=100--b. Update your record to be department 20 manager.update Employee set Dno=20where SSN=102672update Departmentsset  MGRSSN=102672where Dnum=20/*
c. Update the data of employee number=102660 to be in
your teamwork (he will be supervised by you) (your SSN
=102672)*/update employeeset Superssn=102672where ssn=102660-------------------------------------------------/*Unfortunately, the company ended the contract with Mr.
Kamel Mohamed (SSN=223344) so try to delete him from your
database in case you know that you will be temporarily in his
position.
*/
delete from Dependent
where essn=223344

delete from Works_for
where essn = 223344

delete from Employee
where Superssn =223344

delete from Employee
where ssn =223344
