use MyCompany

/*
Display the Id, name, and location of the projects in Cairo or Alex
city.
*/
select p.Pnumber,p.Pname ,p.Plocation
from Project p
where p.Plocation in('cairo','alex')

-------------------------------------------------
/*
Display the Projects full data of the projects with a name starting with
"a" letter.
*/
select *
from Project p
where p.Pname like 'a%'

-------------------------------------------------
/*
display all the employees in department 30 whose salary from 1000 to
2000 LE monthly
*/
select *
from Employee e
where e.Dno=30 and e.Salary between 1000 and 2000