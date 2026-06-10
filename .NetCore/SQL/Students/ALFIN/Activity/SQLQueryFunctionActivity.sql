create database RetailStore;

create table customers(
customer_id int primary key,
name VARCHAR (100)
);

create table orders(
order_id int primary key,
customer_id int,
product varchar (100),
order_date date,
foreign key (customer_id) REFERENCES customers(customer_id));

insert into customers values(1,'SANJAY');
insert into customers values(2,'arya');
insert into customers values(3,'mariya');

select * from customers;

insert into orders values(101,1,'laptop','2026-05-20');
insert into orders values(102,2,'mobile','2026-05-18');
insert into orders values (103,3,'headphone','2026-05-10');

select * from orders;

select order_id,name,product,order_date
from orders
join customers
on orders.customer_id=customers.customer_id
where orders.order_date>=dateadd(day,-7,getdate());

create table subscriptioncustomers(
customer_id int primary key,
name VARCHAR(100),
EMAIL VARCHAR(100));

CREATE table subcriptions(
subcription_id int primary key,
customer_id int,
subcriptionenddate date,
foreign key(customer_id) references subscriptioncustomers(customer_id)
);

insert into subscriptioncustomers values(1,'sanjay','sanjay@gmail.com');
insert into subscriptioncustomers values(2,'arya','arya@gmail.com');
insert into subscriptioncustomers values(3,'mariya','mariya@gmail.com');

select * from subscriptioncustomers;

insert into subcriptions values(1,1,'2026-05-27');
insert into subcriptions values(2,2,'2026-05-30');
insert into subcriptions values(3,3,'2026-06-15');

select * from subcriptions;

select name,email,subcriptionenddate
from subscriptioncustomers
join subcriptions
on subscriptioncustomers.customer_id=subcriptions.customer_id
where subcriptions.subcriptionenddate BETWEEN GETDATE()
AND DATEADD(day,5,GETDATE());

create table employees(
employeeid int primary key,
name varchar(100),
joiningdate date);

insert into employees values(1,'sanjay','2020-05-23');
insert into employees values(2,'arya','2022-08-21 ');
insert into employees values(3,'mariya','2021-05-23');
select * from employees;

select employeeid,joiningdate,name
from employees
where month (joiningdate)=month(getdate()) and day (joiningdate)=day(getdate());
select name,joiningdate
from employees
where format (joiningdate,'mm-dd')=format(getdate(),'mm-dd');


create table projects(
projectid int primary key,
projectname varchar(100),
deadlinedate date);

insert into projects values (1,'tour system','2026-05-10');
insert into projects values (2,'mobile app','2026-06-01');
insert into projects values (3,'website development','2026-05-15');

select * from projects;

select projectname ,deadlinedate,datediff(day,deadlinedate,getdate()) as days_overdue
from projects
where deadlinedate<getdate();


create table customerss(
customer_id int primary key,
name varchar(100));

create table orderss(
order_id int primary key,
customer_id int ,
lastorderDate date ,
foreign key (customer_id) references customerss(customer_id));

insert into customerss values(1,'sanjay');
insert into customerss values(2,'arya');
insert into customerss values(3,'mariya');

insert into orderss values(101,1,'2026-02-01');
insert into orderss values(102,2,'2026-05-01');
insert into orderss values(103,3,'2026-12-15');

select customerss.name,max(orderss.lastorderDate) as lastorderDate,datediff(day,max(orderss.lastorderDate),getdate()) as inactive_days
from customerss
join orderss
on customerss.customer_id=orderss.customer_id
group by customerss.name
having datediff(day,max(orderss.lastorderDate),getdate())>90;


create table salesOrders(
oederid int primary key,
orderdate date,
amount int);

insert into salesOrders values(1,'2026-01-10',5000);
insert into salesOrders values(2,'2026-02-15',5000);
insert into salesOrders values(3,'2026-02-20',5000);
insert into salesOrders values(4,'2026-01-10',5000);

select * from salesOrders;

select month(orderdate) as month,
sum(amount) as total_sales
from salesOrders
where year(orderdate)=year(getdate())
group by month(orderdate) order by month(orderdate);


CREATE TABLE customersss(
customerid int primary key,
firstname varchar(50),
lastname varchar(50),
email varchar(100),
username varchar(50));

insert into customersss values(1,'john','doe','john.doe@gmail.com','johndoe');
insert into customersss values(2,'alice','smith','alice.smith@yahoo.com','bobby');
insert into customersss values(3,'bob','brown','bob.brown@hotmail.com','bobby');

select * from customersss;

select upper(firstname),upper(lastname)
from customersss;

select  concat (firstname,'',lastname)
from customersss;

select SUBSTRING(firstname,1,3) 
from customersss;

select email,len(email)as emaillength
from customersss;

update customersss set username=trim(username);
