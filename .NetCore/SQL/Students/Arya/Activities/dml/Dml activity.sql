create database studentmanagement;

create table students(
StudentId int primary key,
Name varchar (50),
cource varchar (50),
mark int 
);

insert into students(StudentId,Name,cource,mark)
values
(1,'Anjitha','Bcom',100),
(2,'Archa','Mca',70),
(3,'Eli','Cma',80);

select * from students;


select * from students
WHERE mark > 80;

update students
set cource = 'Mcom'
where StudentId = 1;

update students
set mark = 95
where Name= 'Eli';

delete from students
where StudentId = 3;

create table StudentBackup(
    id int,
    name varchar(50),
    course varchar(50),
    mark int
);

insert into StudentBackup
select * from Students;

create table HighMarkStudents (
    id int,
    Name varchar(60),
    course varchar(60),
    mark int
);

insert into HighMarkStudents
select * from Students
Where mark > 90;

Select * from Students
order by mark ASC;

Select * from Students
order by mark DESC;

Select count(*) as total_students
from Students;

select max(mark) as  Maximum_Mark
from Students;

select min(mark) as  Minimum_Mark
from Students;

select Avg(mark) as  Average_Mark
from Students;

Select cource, COUNT(*) AS Total_Students
From Students
group by  cource;

select * from Students
Where cource = 'MCA';

delete from Students;

update Students
Set cource = 'MCA';



