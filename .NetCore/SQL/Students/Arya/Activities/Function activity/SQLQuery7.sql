create database ecommerceplatform;

create table Customers(
    CustomerId int primary key,
    FirstName varchar(50),
    LastName varchar(50),
    Email varchar(100),
    Username varchar(50)
);

insert into Customers
values
(1,'Arya','v.a','arya2@gmail.com','arya'),
(2,'devika','b.r','devika@gmail.com','devu'),
(3,'jency','k.j','jency@gmail.com','jency');

select upper(FirstName),upper(LastName)from Customers;
select concat(FirstName,' ',LastName) as FullName from Customers;
select left(Username,3) from Customers;
select len(Email) as EmailLength from Customers;
select trim(Username) as CleanUsername from Customers;