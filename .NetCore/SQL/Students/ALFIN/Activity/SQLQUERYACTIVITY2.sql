create database studentlist;

create table students(
id  int primary key,
name varchar(50),
course varchar(50),
mark int);

INSERT INTO students VALUES (1,'sanjay','bca',86);
INSERT INTO students VALUES (2,'arya','mca',93);
INSERT INTO students VALUES (3,'mariya','bsc',78);

select * from students;

select name ,mark from students where mark>50;

update students set course ='msc' where id =1;

update students set mark = 95 where name ='sanjay';

delete from students where id =3;

create table StudentBackup (
id int,
name varchar(50),
course varchar(50),
mark int);

insert into StudentBackup select * from students;

create table topstudents(
id int ,
name varchar(50),
course varchar(50),
mark int);

insert into topstudents select * from students where mark >90;

select * from students  ORDER BY mark ASC;

select * from students ORDER BY mark DESC;

select count(name) from students;

select MAX(mark) from students;

select MIN(mark) from students;

select AVG(mark) from students;
select sum (mark) from students;
select  upper (name) from students;

select course from students GROUP BY course;

select * from students where course ='mca';

delete from students;

update students set course ='mca';