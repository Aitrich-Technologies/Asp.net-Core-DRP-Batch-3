create database employeemanagement;

create table Employees(
Employeeid int primary key,
Name varchar (50),
JoiningDate date
);

insert into Employees
values
(1,'Arya','2020-05-24'),
(2,'Sanjay','2021-11-10'),
(3,'Alfin','2019-05-24');

select * from Employees
where day(JoiningDate)=day(getdate())
and month(JoiningDate)=MONTH(getdate());

