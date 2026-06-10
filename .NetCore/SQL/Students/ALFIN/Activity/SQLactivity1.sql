CREATE TABLE companies(
company_id int PRIMARY KEY,
company_name VARCHAR (50)
);
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

EXEC SP_rename 'jobs','jobDEtails';

TRUNCATE TABLE jobDetails;

DROP TABLE jobDetails;


create table Jobs(
job_id int PRIMARY KEY,
company_name VARCHAR(50)NOT NULL,
job_role VARCHAR(50),
salary int CHECK(salary>0),
email VARCHAR (100) UNIQUE
);

INSERT INTO Jobs VALUES(1,'Infosys','developer',35000,'hr@infosys.com');

INSERT INTO Jobs VALUES(2,'TCS','tester',30000,'hr@tcs.com');

select * from jobDetails;

ALTER TABLE Jobs ADD location VARCHAR(50);

UPDATE Jobs SET location = 'kochi'WHERE Job_id =1;

EXEC sp_rename 'Jobs','jobDetails';


TRUNCATE TABLE jobDetails;

DROP TABLE jobDetails;
