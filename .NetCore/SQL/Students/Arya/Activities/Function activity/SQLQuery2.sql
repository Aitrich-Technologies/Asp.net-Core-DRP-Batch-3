create database subscriptionmanagement;

create table customers(
customerId int primary key,
Name varchar (50),
Email varchar (100)
);

create table Subscriptions(
SubscriptionId int primary key,
Customerid int,
SubscriptionEndDate date,
foreign key (Customerid )
references  customers(customerId)
);

insert into customers
values
(1,'Appu','appu@gmail.com'),
(2,'Ammu','ammu@gmail.com');

insert into Subscriptions
values
(101,1,'2026-05-27'),
(102,2,'2026-05-23');

select * from customers;
select * from Subscriptions;
