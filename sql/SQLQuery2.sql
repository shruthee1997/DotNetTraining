use EmployeeDB

select * from Employee
select * from EmpID

select max (salary ) [max salary ] , min (salary) 


select DepID, sum (salary) 'total salary' from Employee
group by DepId 
order by DepId;

select top (5) * from Employee

select DepID, sum (salary) 'total salary' from Employee
group by DepID having sum(salary) >= 5000
order by DepID

select top(5) with ties salary from Employee 
order by salary;

insert into Employee values ( 8, 'khan', 5436, 70000, 658 );

INSERT INTO Employee
VALUES (7, 'ram',  1234, 20000, 906);

INSERT INTO Employee
VALUES (7, 'ram',  1234, 20000, 906);

alter table Employee 
add [DOB] varchar (10);

update Employee set DOB=29-09-1997
where EmpID = 7

select * from Department
select * from Employee

alter table Department 
ADD DepStudent varchar (30);

update Department set DepStudent = 'ram'
where DepID = 123 ;

update Employee set EmpID = 123 
where EmpID = 7


SELECT EmpID,EmpName
FROM Employee                                           
left JOIN Department
ON Employee.EmpID = Department.DepID;

 alter table Department
 add DepRoom int

update Department set DepRoom = 5
where DepID=123;

delete from Department where DepRoom= 5




select getdate() 

select day (getdate () ) as 'day';
select month (getdate()) as 'month';
select year (getdate ()) as 'year';







