CREATE  DATABASE RETAILMANAGEMENT;

CREATE TABLE customer(
customerid int primary key,
name varchar(100),
city varchar(100));

create table orderss(
orderid int primary key,
customerid int,
product varchar(100),
amount decimal);

insert into customer values(1,'john','new york');
insert into customer values(2,'alice','los angels');
insert into customer values(3,'bob','chicago');

insert into orderss values(101,1,'laptop',1200);
insert into orderss values(102,1,'smartphone',800);
insert into orderss values(103,2,'headphone',150);
insert into orderss values(104,4,'tablet',300);

select customer.name,orderss.product,orderss.amount
from customer
right join orderss
on customer.customerid = orderss.customerid;

select customer.name , orderss.product,orderss.amount
from customer
inner join orderss
on customer.customerid = orderss.customerid;

select customer.name,orderss.product,orderss.amount
from customer
left join orderss
on customer.customerid = orderss.customerid;

select customer.name,orderss.product,orderss.amount
from customer
full outer join orderss
on customer.customerid =orderss.customerid;


select name,count(orders)as totalorderss
from customer
join orderss
on customer.customerid=orderss.customerid
group by customer.name
having count(orderss.orders)>=1;