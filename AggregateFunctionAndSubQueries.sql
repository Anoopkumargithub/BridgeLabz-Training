-- Create Employees Table
CREATE TABLE Employees (
EmployeeID INT PRIMARY KEY,
Name VARCHAR(50),
DepartmentID INT,
Salary INT
);
-- Create Departments Table
CREATE TABLE Departments (
DepartmentID INT PRIMARY KEY,
DepartmentName VARCHAR(50)
);

-- Insert Data into Employees
INSERT INTO Employees (EmployeeID, Name, DepartmentID, Salary) VALUES
(1, 'Alice', 1, 60000),
(2, 'Bob', 2, 50000),
(3, 'Charlie', 1, 70000),
(4, 'David', 3, 45000),
(5, 'Eve', 2, 65000);

-- Insert Data into Departments
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance');

-- Aggreates Function 
-- 1. Sum()
-- Find the total salary of all employees.
SELECT SUM(Salary) AS TotalSalary FROM Employees;

-- 2. AVG()
-- Find the average salary of all employees.
SELECT AVG(Salary) AS AverageSalary FROM Employees;

-- 3. COUNT()
-- Find the total number of employees.
SELECT COUNT(*) AS TotalEmployees FROM Employees;

-- 4. MIN() and MAX()
-- Find the lowest and highest salary.
SELECT MIN(Salary) AS MinSalary, MAX(Salary) AS MaxSalary FROM Employees;

-- 5. Group BY
-- Find the total salary per department.
SELECT d.DepartmentName, SUM(e.Salary) AS TotalSalary
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentName;

-- 6. HAVING
-- Find departments with total salary greater than 100000.
SELECT d.DepartmentName, SUM(e.Salary) AS TotalSalary
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentName
HAVING SUM(e.Salary) > 100000;

-- 7. STDDEV() and VAR() - Standard Deviation & Variance
-- Find the standard deviation and variance of salaries.
SELECT STDEV(Salary) AS SalaryStdDev, VAR(Salary) AS SalaryVariance   FROM Employees;

-- SubQuerries

-- Single-Row Subquery
-- Find employees who have the highest salary.
SELECT Name, Salary
FROM Employees
WHERE Salary = (SELECT MAX(Salary) FROM Employees);


-- Multi-Row Subquery
-- Find employees who work in departments with IT or HR.
SELECT Name, DepartmentID
FROM Employees
WHERE DepartmentID IN (SELECT DepartmentID FROM Departments WHERE
DepartmentName IN ('IT', 'HR'));

-- Correlated Subquery
--  Find employees whose salary is higher than the average salary in their department.
SELECT Name, Salary, DepartmentID
FROM Employees e1
WHERE Salary > (SELECT AVG(Salary) FROM Employees e2 WHERE
e1.DepartmentID = e2.DepartmentID);

-- Nested Subquery
--  Find employees who work in the department where 'Charlie' works.
SELECT Name
FROM Employees
WHERE DepartmentID = (
SELECT DepartmentID FROM Employees WHERE Name = 'Charlie');

--  Subquery in SELECT Clause
--  Display each employee's salary along with the department name.
SELECT e.Name, e.Salary,
(SELECT d.DepartmentName FROM Departments d WHERE
d.DepartmentID = e.DepartmentID) AS Department
FROM Employees e;

-- Subquery in FROM Clause (Derived Table)
-- Find the average salary of each department and filter departments with an average salary> 55000.
SELECT DepartmentID, AvgSalary
FROM (SELECT DepartmentID, AVG(Salary) AS AvgSalary FROM Employees
GROUP BY DepartmentID) AS DeptAvg
WHERE AvgSalary > 55000;