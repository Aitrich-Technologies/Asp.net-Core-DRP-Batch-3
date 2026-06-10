create database salesmanagement;

create table customers(
CustomerId int primary key,
Name varchar (60));

create table Orders(
OrderId int primary key,
customerid int,
foreign key (customerid) references customers(CustomerId),
product varchar (50),
orderdate date);

insert into customers
values
(1,'sanjay'),
(2,'Alfin');

insert into Orders
values
(100,1,'laptop','2026-05-11'),
(101,2,'phone','2026-05-25'),
(102,1,'Mouse','2026-05-03');

select * from customers;
select * from Orders;

