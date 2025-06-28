use [“RouteCompany”]

create table deparrment
(
	DeptNo int primary key ,
	DeptName varchar(50) ,	Location varchar(50)
)

create table Employee
(
	EmpNo int primary key ,
	Fname varchar(50) not null ,
	Lname  varchar(50) not null ,
	DeptNo int foreign key references deparment(deptNo) , 
	salary unique decimal(10,2)
)

--------------------------------Testing Referential Integrity---------------------------------
--1-Add new employee with EmpNo =11111 In the works_on table [what will happen]
--2-Change the employee number 10102 to 11111 in the works on table [what will happen]	
--3-Modify the employee number 10102 in the employee table to 22222. [what will happen]
--error because  EmpNo =11111 and EmpNo=22222 not in employee table 

--4-Delete the employee with id 10102
--work on table has relation (id =10102)


-------------------------------------Table Modification-----------------------
--1-Add TelephoneNumber column to the employee table[programmatically]
alter table employee
add TelephoneNumber varchar(20)

--2-drop this column[programmatically]
alter table employee
drop column TelephoneNumber

/*
2. Create the following schema and transfer the following tables to it
	a. Company Schema
		i. Department table
		ii. Project table
	b. Human Resource Schema
		i. Employee table
*/
create schema Company

alter schema HumanResource 
transfer dbo.Employee


create schema HumanResource

alter schema Company 
transfer dbo.Department

alter schema Company 
transfer dbo.Project

/*
3. Increase the budget of the project where the manager number is 10102 by
10%.*/
update Company.Project
set budget = budget * 0.1
where Company.Project.projectno = 10102

/*
4. Change the name of the department for which the employee named James
works.The new department name is Sales
*/
update Company.Department
set DeptName = 'Sales'
where deptno in 
(
    select deptno
    from HumanResource.Employee
    where Fname = 'James'
)


/*
5. Change the enter date for the projects for those employees who work in
project p1 and belong to department ‘Sales’. The new date is 12.12.2007.*/
update works_on
set enter_date = '2007-12-12'
where projectno = 1
  and empno in (
    select employee.empno
    from HumanResource.Employee inner join  Company.Department
	on HumanResource.Employee.DeptNo= Company.Department.deptno
    where Company.Department.deptname = 'sales'
  )

  sp_help employee;

/*6. Delete the information in the works_on table for all employees who work
for the department located in KW.
*/

delete from works_on
where empno in (
  select employee.empno
  from employee
  join department on employee.deptid = department.deptid
  where department.location = 'kw'
)
