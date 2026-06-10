create database jobportals;

create table Jobs(
JobId int primary key,
company_name varchar(50)Not Null,
job_role varchar (50),
salary int check(salary>0),
email varchar(100)unique
);

insert into Jobs(JobId,company_name,job_role,salary,email)
values
(1,'Infosys','Developer',35000,'hr@infosys.com'),
(2,'TCS','Tester',30000,'hr@tcs.com');

select * from Jobs;

alter table Jobs
ADD Location varchar(50);

update Jobs
set Location = 'kochi'
where JobId  = 1;

Exec sp_rename 'Jobs', 'JobDetails';

select * from JobDetails;

TRUNCATE TABLE JobDetails;

DROP TABLE JobDetails;

CREATE TABLE companies(
company_id int PRIMARY KEY,
company_name VARCHAR (50)
);

select * from companies;

INSERT INTO companies values(101,'penguin');
INSERT INTO companies values(102,'ibm');

CREATE TABLE jobs(
job_id int PRIMARY KEY,
job_ROLE  VARCHAR(50),
salary int,
company_id int,
FOREIGN KEY (company_id) REFERENCES companies (company_id)
);

INSERT INTO jobs values (1,'developer',45000,101);
INSERT INTO jobs values (2,'hr',40000,102);

SELECT * FROM  jobs; 
SELECT * FROM  jobs WHERE company_id = 101;

ALTER TABLE jobs ADD location VARCHAR(50);

UPDATE jobs SET location ='kochi' WHERE job_id = 1;

EXEC SP_rename 'jobs','jobdetails';

TRUNCATE TABLE jobdetails;

DROP TABLE jobdetails;