use company

-----------------------------------------------------------
--insert 

--insert all col
insert into employee
values(1,'alyaa','tamer','f','1-13-2005','maadi',null)

--insert specific col
insert into employee(ssn,fname,gender)
values(2,'aliaa','f')


-----------------------------------------------------------
--row constructor
insert into employee(ssn,fname,gender)
values
(3,'aliaa','f')
,(4,'aliaa','f')
,(5,'aliaa','f')

-----------------------------------------------------------
--update

update employee
set lname ='tamer'
where ssn=2
 

 alter table employee
 add salary dec(6,2) 

 update employee
 set salary = 8000
 where gender='f'

update employee
set salary +=salary*0.1 
where gender='m'

-----------------------------------------------------------
--delete

delete from employee
where gender = 'm'

-----------------------------------------------------------

-----DQL

Select *
from employee

select fname,lname
from employee
-----------------------------------------------------------
---Alias Name
select fname as [first name] ,lname as last
from employee

select s.fname First , s.lname Last 
from employee s
-----------------------------------------------------------
--concat
select e.fname+' '+e.lname as FullName
from employee e
-----------------------------------------------------------
--condition
select e.fname 
from employee e
where e.ssn>1

select e.fname 
from employee e
where e.ssn>1 and gender is null


select e.fname,e.address
from employee e
where e.address in ('cairo','alex')

-----------------------------------------------------------
--order by

--asc
select e.lname 
from employee e
order by e.lname

--desc
select e.lname 
from employee e
order by e.lname desc


select e.lname , e.fname
from employee e
order by 2 , 1

-----------------------------------------------------------
--distinct
select distinct e.fname
from employee e

select distinct e.fname , e.lname
from employee e

-----------------------------------------------------------
--like

select e.fname
from employee e
where e.fname like '_a%'

-----------------------------------------------------------
use iti
--joins

--cross join
select s.fname , d.name
from students s ,departments d

select s.fname , d.name
from students s cross join departments d

--inner join
select s.fname , d.name
from students s , departments d
where d.id = s.dep_id

select s.fname , d.name
from students s inner join departments d
on d.id = s.dep_id 

select s.fname , d.name
from students s join departments d
on d.id = s.dep_id


--outer join 
--left outer join 

select s.fname , d.name
from students s left outer join departments d
on d.id=s.dep_id

select s.fname , d.name
from students s left join departments d
on d.id=s.dep_id

--right outer join
select s.fname , d.name
from students s right outer join departments d
on d.id=s.dep_id

select s.fname , d.name
from students s right join departments d
on d.id=s.dep_id

--full outer join
select s.fname , d.name
from students s full outer join departments d
on d.id=s.dep_id

select s.fname , d.name
from students s full join departments d
on d.id=s.dep_id

--self join
select s1.fname , s2.fname 
from students s1 , students s2
where s1.id = s2.superid

--multiple join 
select s.fname,d.name , sc.grade
from students s , departments d , stud_course sc
where d.id=s.dep_id and s.id=sc.stud_id


