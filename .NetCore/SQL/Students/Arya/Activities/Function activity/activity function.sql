create database retailstoremanagement;

create table sales(
SaleID int primary key,
productName varchar (100),
Category varchar (50),
Quantity int ,
Priceperunit decimal (10,2),
SaleDate date
);

insert into sales(SaleID,productName,Category,Quantity,Priceperunit,SaleDate)
values
(1,'Laptop','Electronics',2,1000.00,'2025-01-10'),
(2,'Smartphone','Electronics',3,800.00,'2025-01-12'),
(3,'Bread','Groceries',5,2.50,'2025-01-13'),
(4,'Milk','Groceries',10,1.50,'2025-01-14')

select avg (Priceperunit) as Average_price from sales;
select sum (Priceperunit * Quantity) as Total_sales from sales;
select count (productName) as TotalNumberofsales from sales;
select max (Priceperunit) as Maximum_price from sales;
select min (Priceperunit) as Minimum_price from sales;













