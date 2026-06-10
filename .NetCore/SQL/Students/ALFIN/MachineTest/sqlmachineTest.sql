create database customer_orders;

use customer_orders;

create table customer(
customerID INT primary key,
customername varchar(50),
city varchar(50));

insert into customer values(1,'alice','new york');
insert into customer values(2,'bob','chicago');
insert into customer values(3,'charlie','los angeles');
insert into customer values(4,'david','houston');

select * from customer;

create table orders(
orderid int primary key,
customerid int,
orderdate date,
totalamount decimal(10,2),
foreign key (customerid) references customer(customerID)
);

insert into orders values (101,1,'2024-02-15',500);
insert into orders values (102,2,'2024-02-16',700);
insert into orders values (103,1,'2024-03-01',200);
insert into orders values (104,3,'2024-03-05',900);
insert into orders values (105,2,'2024-03-07',450);

select * from orders;

select
c.customerID,
c.customername,
sum(o.totalamount) as totalspent
from customer c
join orders o
on c.customerID = o.customerid
group by c.customerID, c.customername;

select 
c.customerID,
c.customername,
c.city
from customer c
left join orders o
on c.customerID = o.customerid
where o.orderid is null;

select
c.customerID,
c.customername,
max(o.orderdate) as mostrecentorder
from customer c
join orders o
on c.customerID =  o.customerid
group by c.customerID ,c.customername;

select 
c.customerID,
c.customername ,
sum (o. totalamount) as totalspent
from customer c
join orders o
on c.customerID = o.customerid
group by c.customerID,c.customername
order by totalspent desc;

select 
count (orderid) as numberoforders
from orders
where month(orderdate)=3 and year (orderdate)=2024

