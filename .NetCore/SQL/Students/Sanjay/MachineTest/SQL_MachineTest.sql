CREATE DATABASE Employ_Management;

CREATE TABLE Departments
(Dept_id int PRIMARY KEY,
Dept_name VARCHAR(30),
)
INSERT INTO Departments VALUES 
(10,'HR'),
(20,'IT'),
(30,'Sales'),
(40,'Finance')


CREATE TABLE Employees
(
Emp_id int PRIMARY KEY,
Name VARCHAR(20),
Dept_id int null,
Salary DECIMAL,
Hire_date datetime,
)
drop table Employees

INSERT INTO Employees VALUES 
(1,'Alice',10,50000,'2021-01-15'),
(2,'Bob',20,60000,'2020-04-20'),
(3,'Charlie',10,45000,'2019-07-10'),
(4,'David',30,70000,'2022-03-01'),
(5,'Eva',null,55000,'2023-06-12')

SELECT * FROM Employees


SELECT E.* , D.Dept_name
FROM Employees E
INNER JOIN  Departments D
ON E.Dept_id = D.Dept_id;


SELECT Name, Salary
FROM Employees
WHERE Salary >
(
    SELECT AVG(Salary)
    FROM Employees
);


SELECT D.Dept_name,
COUNT(E.Emp_id) 
FROM Departments D
INNER JOIN Employees E
ON D.Dept_id = E.Dept_id
GROUP BY D.Dept_name
HAVING COUNT(E.Emp_id) > 1;


SELECT E.Name ,D.Dept_id, D.Dept_name
FROM Departments D
LEFT JOIN  Employees E
ON E.Dept_id = D.Dept_id;


SELECT * INTO Employees_Copy
FROM Employees;

SELECT * FROM Employees_Copy;


SELECT D.Dept_name,
COUNT(E.Emp_id) AS EmployeeCount
FROM Departments D
LEFT JOIN Employees E
ON D.Dept_id = E.Dept_id
GROUP BY D.Dept_name
ORDER BY EmployeeCount DESC;



SELECT TOP 2 E.Name,E.Salary
FROM Employees E
INNER JOIN Departments D
ON E.Dept_id = D.Dept_id
WHERE D.Dept_name = 'IT';


UPDATE E
SET Salary = Salary * 1.10
FROM Employees E
INNER JOIN Departments D
ON E.Dept_id = D.Dept_id
WHERE D.Dept_name = 'HR';



SELECT Name, Salary
FROM Employees
WHERE Salary >
(
    SELECT AVG(E.Salary)
    FROM Employees E
    INNER JOIN Departments D
    ON E.Dept_id = D.Dept_id
    WHERE D.Dept_name = 'Sales'
);


SELECT D.Dept_name,E.name,E.Salary
FROM Employees E
INNER JOIN Departments D
ON E.Dept_id = D.Dept_id
WHERE E.Salary =
(
    SELECT MAX(Salary)
    FROM Employees E1
    WHERE E1.Dept_id = E.Dept_id
);