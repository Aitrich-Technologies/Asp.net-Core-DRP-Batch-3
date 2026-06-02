create table Companies(
company_id int PRIMARY KEY,
company_name varchar(20)
);

insert into Companies(company_id,company_name)
values(2,'TCS');

select * from Companies;

create table Jobs(
job_id int PRIMARY KEY,
job_role varchar(20),
salary int,
company_id int,
FOREIGN KEY (company_id) REFERENCES Companies(company_id)
);
 
 insert into Jobs(job_id,job_role,salary,company_id)
 values(105,'Tester',70000,2);

 select * from Jobs;

 select * from Jobs where company_id = 1;

 ALTER TABLE Jobs ADD location varchar(20);

 UPDATE Jobs SET location = 'Kochi' WHERE job_id = 1;

 EXEC sp_rename 'Jobs',
'JobDetails';

TRUNCATE TABLE JobDetails;

DROP table JobDetails;


create table Jobs(
job_id int PRIMARY KEY, 
company_name varchar(30) NOT NULL,
job_role varchar(30),
salary int CHECK(salary > 0),
email varchar(100) UNIQUE
);


INSERT INTO Jobs(job_id, company_name, job_role, salary, email)
VALUES (1, 'Infosys', 'Developer', 35000, 'hr@infosys.com');

INSERT INTO Jobs(job_id, company_name, job_role, salary, email)
VALUES (2, 'TCS', 'Tester', 30000, 'hr@tcs.com');

 select * from JobDetails;

ALTER TABLE Jobs ADD Location varchar(50);

 UPDATE Jobs SET location = 'Kochi' WHERE job_id = 1;

  EXEC sp_rename 'Jobs',
'JobDetails';

TRUNCATE TABLE JobDetails;

DROP table JobDetails;