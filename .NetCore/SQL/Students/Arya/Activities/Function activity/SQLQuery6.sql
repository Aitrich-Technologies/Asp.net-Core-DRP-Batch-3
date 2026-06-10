create database storesales;

create table orders(
orderid int primary key,
orderdate date,
Amount decimal(10,2)
);

insert into orders
values
(101,'2026-01-10',2000),
(102,'2026-01-20',3000),
(103,'2026-02-15',5000),
(104,'2026-03-10',4000);

select
month(orderdate) as Month,
sum(Amount) as TotalSales
from orders
where year(orderdate)=year(getdate())
group by month(orderdate)
order by Month;
