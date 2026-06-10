create database prrojectmanagement;

create table Projects(
projectid int primary key,
projectName varchar(60),
DeadlineDate date
);

insert into Projects
values
(1,'Website','2026-05-10'),
(2,'Billing system','2026-05-01'),
(3,'Gaming App','2026-05-01');

select * from Projects;

select*,
DATEDIFF(day,DeadlineDate,GETDATE())
as daysoverdue from Projects
where DeadlineDate < GETDATE();
