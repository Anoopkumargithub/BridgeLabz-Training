
-- JOINS

CREATE DATABASE EMPLOYEE_DB;
USE EMPLOYEE_DB;

-- Creating Employees Table
CREATE TABLE Employees(
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(50),
    DepartmentID INT
)

-- Create Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(50)
)


-- Insert Data into Employees
INSERT INTO Employees(EmployeeID, Name, DepartmentID) VALUES
(1,'Alice', 1),
(2,'Bob', 2),
(3,'Carlie', 3),
(4,'David', 4),
(5,'Eleven', NULL),
(6,'Flora',2);


-- Insert Data into Departements
INSERT INTO Departments(DepartmentID, DepartmentName) VALUES
(1,'HR'),
(2,'IT'),
(3,'Finance'),
(4,'Marketing'),
(5,'CS');



-- Inner Join (Only Matching Rows)

Select Employees.EmployeeID, Employees.Name, Departments.DepartmentName From Employees INNER JOIN Departments ON Employees.DepartmentID=Departments.DepartmentID;

-- Left Join (ALL Left Rows + Matches Rights table)

Select e.EmployeeID, e.Name, d.DepartmentName
from Employees as e LEFT JOIN Departments as d on e.DepartmentID = d.DepartmentID;


-- Right Join (All Right Table + Matched from Left Table)

Select e.EmployeeID, e.Name, d.DepartmentName
from Employees as e RIGHT JOIN Departments as d ON e.DepartmentID = d.DepartmentID;

-- Full Outer Join (All Records from Both Tables)

Select e.EmployeeID, e.Name , d.DepartmentID
from Employees as e FULL OUTER JOIN Departments as d ON e.DepartmentID = d.DepartmentID;

-- Cross Join (Cartesian Product)

SELECT  e.Name , d.DepartmentName 
from Employees as e CROSS JOIN Departments as d;

-- Self Join (Joining a table with itself)

SELECT e1.Name as Employee1, e2.Name as Employee2, d.DepartmentName from Employees as e1
JOIN Employees e2 ON e1.DepartmentID = e2.DepartmentID AND e1.EmployeeID <> e2.EmployeeID
JOIN Departments d ON e1.DepartmentID = d.DepartmentID;

