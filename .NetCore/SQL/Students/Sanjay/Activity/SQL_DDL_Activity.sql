create database studentmanagement;

create table Students(id int, name varchar(20), course varchar(20),mark int);

insert into Students values (
1,'Sanjay','Computer Science', 50),
(2,'Alfin','Computer Science', 55),
(3,'Arya','Commerce', 50);

select * from Students;

select name,mark from Students where mark > 50;

update Students SET course = 'Biomaths' where id = 1;

delete from Students where id = 3;

create table StudentBackup(id int, name varchar(20), course varchar(20),mark int);

insert into StudentBackup select * from Students where mark >= 50;

select * from Students order by mark ASC;

select * from Students order by mark DESC;

select Count(name) from Students;

select max(mark) from Students;

select min(mark) from Students;

select avg(mark) from Students;

select course from Students group by course;

select * from Students where course = 'Computer Science';

delete from Students;

update Students SET course = 'MCA';