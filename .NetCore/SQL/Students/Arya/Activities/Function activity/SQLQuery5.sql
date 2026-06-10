create database Customermanagements;

create table Customers(
    CustomerId int primary key,
    Name varchar(50)
);

create table Orders(
    OrderId int primary key,
    CustomerId int,
    LastOrderDate date,
    foreign key(CustomerId)
    references Customers(CustomerId)
);

insert into Customers
values
(1,'Raju'),
(2,'Maya');

insert into Orders
values
(101,1,'2026-01-10'),
(102,2,'2026-05-01');

select *,
datediff(day,LastOrderDate,getdate())
as InactiveDays
from Orders
where LastOrderDate <
dateadd(day,-90,getdate());
