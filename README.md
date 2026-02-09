# 🎓 BridgeLabz-Training - DBMS Learning Journey

Welcome to my Database Management Systems (DBMS) learning repository! This contains my progress, notes, and practice exercises as I master database concepts and SQL.

---

## 📚 Table of Contents
- [What is DBMS?](#-what-is-dbms)
- [Types of DBMS](#-types-of-dbms)
- [SQL Language Categories](#-sql-language-categories)
- [Normalization](#-normalization)
- [Aggregate Functions & Subqueries](#-aggregate-functions--subqueries)
- [Joins](#-joins)
- [Performance Optimization](#-performance-optimization)
- [Security & Administration](#-security--administration)
- [Tools & Environment](#-tools--environment)

---

## 🎯 Project Progress & Learning Timeline

Here's a chronological overview of my learning journey and project implementations.

---

### February 9, 2026 - HealthCare Project Update

**Project Name:** `HealthCare`
**Status:** ✅ In Progress
**Technology Stack:** C#, ADO.NET, SQL Server, .NET Framework

**Key Achievements:**
- Started a new HealthCare project to manage patient and doctor information.
- Implemented the Patient module with full CRUD (Create, Read, Update, Delete) operations.
  - Implemented `AddPatient`, `UpdatePatient`, `search by keyword`, and `GetById` functionalities.
  - Connected the Patient module to the SQL Server database using ADO.NET.
  - Created initial SQL scripts for patient schema and setup.
  - Incorporated custom exception handling and applied Object-Oriented Programming (OOP) principles.
- Implemented the Doctor module with full CRUD operations.
- Implemented the Speciality module with CRUD and search operations.
- Designed and created encapsulated classes, interfaces, repositories (for database interaction), services (for business logic and user input handling), and menu classes for both Doctor and Speciality modules.

---

### February 7, 2026 - ADO.NET & Employee Management System

**Project Name:** `DataBaseConnection` (Employee Management with ADO.NET)
**Status:** ✅ COMPLETED
**Technology Stack:** C#, ADO.NET, SQL Server, .NET Framework

**Key Achievements:**
- Comprehensive learning and implementation of ADO.NET (ActiveX Data Objects .NET) architecture and components.
  - Gained understanding of the Connected Layer (`SqlConnection`, `SqlCommand`, `SqlDataReader`).
  - Gained understanding of the Disconnected Layer (`DataSet`, `SqlDataAdapter`).
- Built a complete Employee Management System demonstrating ADO.NET for database connectivity.

**CRUD Operations Implemented:**
- ✅ **CREATE (INSERT)**: Implemented parameterized INSERT queries to add new employee records securely.
- ✅ **READ (SELECT)**: Implemented SELECT queries with `SqlDataReader` for efficient, forward-only data retrieval.
- ✅ **UPDATE**: Implemented UPDATE operations to modify existing employee information.
- ✅ **DELETE**: Implemented DELETE operations to remove employee records.

**Best Practices Applied:**
- **SQL Injection Prevention**: Utilized parameterized queries to safeguard against SQL injection attacks.
- **Resource Management**: Employed `using` statements to ensure proper disposal and closure of database connections.
- **Separation of Concerns**: Isolated data access logic into dedicated repository classes for maintainability.
- **Error Handling**: Implemented robust exception management for various database operations.
- **Connection Pooling**: Leveraged automatic connection pooling through `SqlConnection` for performance optimization.

---

### February 7, 2026 - TechVille Smart City Management System (Module 1)

**Project Name:** `TechVille_SmartCity_DB` (Module 1: Citizen Registration Portal)
**Status:** 🚀 In Development
**Start Date:** February 7, 2026

**Key Achievements:**
- Designed Module 1: Citizen Registration Portal for managing smart city citizen data.
- Created the `Citizens` table with a computed column for automated age calculation.
- Developed the `EligibilityDetails` table for tracking service eligibility based on various criteria.
- Designed the `CitizenDetailsExtended` table to store comprehensive citizen demographic information.
- Defined core business rules and eligibility criteria for citizen services.
- Implemented sample SQL queries for common operations, such as retrieving eligible citizens and calculating statistics.

---

### Upcoming Learning Goals & Project Phases:

**Intermediate Concepts:**
- [ ] Learn CTEs (Common Table Expressions)
- [ ] Master window functions

**Advanced Topics:**
- [ ] Learn query optimization techniques (beyond basic indexing)
- [ ] Implement advanced indexing strategies
- [ ] Study stored procedures and functions (creation, execution, best practices)
- [ ] Work with triggers and views (implementation and use cases)

**Expert Level:**
- [ ] Master transaction management (ACID properties, isolation levels)
- [ ] Learn advanced database security best practices
- [ ] Performance tuning and execution plan analysis (in-depth)
- [ ] Practice with real-world scenarios and complex database challenges

**Ongoing Development:**
- [ ] **Next Phase for TechVille Smart City:** Module 2 - Service Request Management
- [ ] Build a complete, end-to-end database project
- [ ] Document learnings and create detailed notes
- [ ] Solve challenging SQL problems on platforms like HackerRank/LeetCode

---

## 🗄️ DBMS Fundamentals

### What is DBMS?

A **Database Management System (DBMS)** is software that enables users to create, manage, and manipulate databases efficiently. It provides an interface between the database and end-users or application programs.

### 🎯 Why DBMS?
Imagine storing thousands of customer records in Excel files - chaos, right? DBMS solves this by:
- 📦 Organizing data in structured formats
- 🔒 Ensuring data security and privacy
- ⚡ Providing fast and efficient data access
- 🔄 Handling multiple users simultaneously
- 🛡️ Preventing data loss and corruption

### Key Features:
- ✅ **Data Storage & Retrieval** - Store and fetch data efficiently
- ✅ **Data Security & Access Control** - Protect sensitive information
- ✅ **Data Integrity & Consistency** - Maintain accurate data
- ✅ **Concurrent Access Management** - Multiple users, no conflicts
- ✅ **Backup & Recovery** - Never lose your data
- ✅ **Transaction Management** - ACID properties guaranteed

---

### 🔧 Types of DBMS

| Type | Description | Examples |
|------|-------------|----------|
| **Relational DBMS (RDBMS)** | Data stored in tables with relationships | MySQL, PostgreSQL, **MSSQL**, Oracle |
| **NoSQL DBMS** | Non-relational, flexible schema | MongoDB, Cassandra, Redis |
| **Object-Oriented DBMS** | Data stored as objects | ObjectDB, db4o |
| **Hierarchical DBMS** | Tree-like structure | IBM IMS |
| **Network DBMS** | Graph structure with multiple relationships | IDMS, TurboIMAGE |
| **Columnar DBMS** | Column-oriented storage | Apache Cassandra, HBase |

---

## 💻 SQL Core Concepts

### SQL Language Categories

```
┌─────────────────────────────────────────────┐
│                    SQL COMMANDS                                                                     │
├─────────────────────────────────────────────┤
│  DDL  │  DML  │  DQL  │  DCL  │  TCL                                                        │
│ (Structure) (Data) (Query) (Access) (Trans)                                                  │
└─────────────────────────────────────────────┘
```

#### 1️⃣ DDL (Data Definition Language)
**Purpose:** Defines and manages database schema and structure.
**Think of it as:** The architect that designs the building structure.

| Command | Purpose | Example |
|---------|---------|---------|
| `CREATE` | Create database objects | `CREATE TABLE users (id INT, name VARCHAR(50));` |
| `ALTER` | Modify existing objects | `ALTER TABLE users ADD email VARCHAR(100);` |
| `DROP` | Delete database objects | `DROP TABLE users;` |
| `TRUNCATE` | Remove all records | `TRUNCATE TABLE users;` |

```sql
-- Example: Creating a table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10,2)
);
```

#### 2️⃣ DML (Data Manipulation Language)
**Purpose:** Manipulates data within database objects.
**Think of it as:** The workers who add, modify, or remove items from the building.

| Command | Purpose | Example |
|---------|---------|---------|
| `INSERT` | Add new records | `INSERT INTO users VALUES (1, 'John');` |
| `UPDATE` | Modify existing records | `UPDATE users SET name='Jane' WHERE id=1;` |
| `DELETE` | Remove records | `DELETE FROM users WHERE id=1;` |

```sql
-- Example: Data manipulation
INSERT INTO Employees (EmployeeID, FirstName, LastName, Department, Salary)
VALUES (101, 'John', 'Doe', 'IT', 75000);

UPDATE Employees 
SET Salary = 80000 
WHERE EmployeeID = 101;
```

#### 3️⃣ DQL (Data Query Language)
**Purpose:** Retrieves data from the database.
**Think of it as:** The search engine that finds what you need.

| Command | Purpose | Example |
|---------|---------|---------|
| `SELECT` | Retrieve data | `SELECT * FROM users WHERE age > 18;` |

```sql
-- Example: Querying data
SELECT FirstName, LastName, Department 
FROM Employees 
WHERE Salary > 50000
ORDER BY LastName;
```

#### 4️⃣ DCL (Data Control Language)
**Purpose:** Controls access and permissions.
**Think of it as:** The security guard who decides who can enter and what they can do.

| Command | Purpose | Example |
|---------|---------|---------|
| `GRANT` | Give user privileges | `GRANT SELECT ON users TO user1;` |
| `REVOKE` | Remove user privileges | `REVOKE SELECT ON users FROM user1;` |

```sql
-- Example: Access control
GRANT SELECT, INSERT ON Employees TO DataAnalyst;
REVOKE DELETE ON Employees FROM DataAnalyst;
```

#### 5️⃣ TCL (Transaction Control Language)
**Purpose:** Manages database transactions.
**Think of it as:** The checkpoint system that can save progress or undo mistakes.

| Command | Purpose | Example |
|---------|---------|---------|
| `COMMIT` | Save transaction changes | `COMMIT;` |
| `ROLLBACK` | Undo transaction changes | `ROLLBACK;` |
| `SAVEPOINT` | Set a transaction savepoint | `SAVEPOINT sp1;` |

```sql
-- Example: Transaction management
BEGIN TRANSACTION;
    UPDATE Employees SET Salary = Salary * 1.10 WHERE Department = 'IT';
    SAVEPOINT salary_update;
    DELETE FROM Employees WHERE EmployeeID = 999;
COMMIT;
```

---

### 📐 Normalization

**Normalization** is the process of organizing data to minimize redundancy and improve data integrity.

> 💡 **Simple Explanation:** Think of normalization as decluttering your closet - removing duplicate items and organizing everything efficiently!

### Why Normalize?
- ❌ **Without Normalization:** Data duplication, inconsistencies, waste of storage
- ✅ **With Normalization:** Clean data, no redundancy, efficient queries

### Normalization Forms:

| Form | Rule | Example Issue Solved |
|------|------|---------------------|
| **1NF** (First Normal Form) | Each column contains atomic values; no repeating groups | Eliminates duplicate columns |
| **2NF** (Second Normal Form) | 1NF + No partial dependencies | All non-key attributes depend on entire primary key |
| **3NF** (Third Normal Form) | 2NF + No transitive dependencies | Non-key attributes depend only on primary key |
| **BCNF** (Boyce-Codd) | 3NF + Every determinant is a candidate key | Handles special cases of 3NF |

### Example:

**Unnormalized Table:**
```
Orders: OrderID, CustomerName, CustomerAddress, Product1, Product2, Product3
```

**After Normalization:**
```sql
-- Customers Table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    CustomerAddress VARCHAR(200)
);

-- Orders Table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- OrderDetails Table
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);
```

---

### 🔗 Joins

**Joins** combine rows from two or more tables based on related columns.

> 💡 **Simple Explanation:** Joins are like matching puzzle pieces from different boxes to create a complete picture!

### Visual Guide:
```
  Table A          Table B
┌─────────┐      ┌─────────┐
│  ID │ Name│    │  ID │ City│
├─────────┤      ├─────────┤
│  1  │ John│    │  1  │ NYC │
│  2  │ Jane│    │  2  │ LA  │
│  3  │ Bob │    │  4  │ TX  │
└─────────┘      └─────────┘

INNER JOIN → Only matching IDs (1, 2)
LEFT JOIN  → All from A + matches from B (1, 2, 3)
RIGHT JOIN → All from B + matches from A (1, 2, 4)
FULL JOIN  → Everything from both (1, 2, 3, 4)
```

### Types of Joins:

```
┌─────────────────────────────────────────────────────┐
│                  JOIN TYPES                         │
├─────────────────────────────────────────────────────┤
│  INNER JOIN    │  LEFT JOIN    │  RIGHT JOIN        │
│  FULL JOIN     │  CROSS JOIN   │  SELF JOIN         │
└─────────────────────────────────────────────────────┘
```

| Join Type | Description | Visual |
|-----------|-------------|--------|
| **INNER JOIN** | Returns matching records from both tables | A ∩ B |
| **LEFT JOIN** | All from left + matching from right | A + (A ∩ B) |
| **RIGHT JOIN** | All from right + matching from left | B + (A ∩ B) |
| **FULL OUTER JOIN** | All records from both tables | A ∪ B |
| **CROSS JOIN** | Cartesian product of both tables | A × B |
| **SELF JOIN** | Table joined with itself | A ⟷ A |

### Examples:

```sql
-- INNER JOIN
SELECT e.FirstName, e.LastName, d.DepartmentName
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID;

-- LEFT JOIN
SELECT c.CustomerName, o.OrderID
FROM Customers c
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID;

-- RIGHT JOIN
SELECT e.FirstName, p.ProjectName
FROM Employees e
RIGHT JOIN Projects p ON e.ProjectID = p.ProjectID;

-- FULL OUTER JOIN
SELECT e.FirstName, d.DepartmentName
FROM Employees e
FULL OUTER JOIN Departments d ON e.DepartmentID = d.DepartmentID;

-- SELF JOIN (Find employees with same manager)
SELECT e1.FirstName AS Employee, e2.FirstName AS Manager
FROM Employees e1
INNER JOIN Employees e2 ON e1.ManagerID = e2.EmployeeID;
```

---

### 📊 Aggregate Functions & Subqueries

**Aggregate Functions** perform calculations on data sets, and **Subqueries** are queries inside queries - incredibly powerful for complex analysis!

> 💡 **Simple Explanation:** Aggregate functions are like calculators that summarize data, and subqueries are like zooming in to find specific details!

### Common Aggregate Functions:

| Function | Purpose | Example |
|----------|---------|---------|
| `COUNT()` | Count rows | `SELECT COUNT(*) FROM Employees;` |
| `SUM()` | Sum values | `SELECT SUM(Salary) FROM Employees;` |
| `AVG()` | Calculate average | `SELECT AVG(Salary) FROM Employees;` |
| `MAX()` | Find maximum value | `SELECT MAX(Salary) FROM Employees;` |
| `MIN()` | Find minimum value | `SELECT MIN(Salary) FROM Employees;` |
| `GROUP_CONCAT()` | Combine values | `SELECT GROUP_CONCAT(FirstName) FROM Employees;` |

### Practical Examples: Employees & Departments

#### Database Schema:
```sql
-- Create Departments Table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName VARCHAR(100) NOT NULL,
    Location VARCHAR(100),
    BudgetAmount DECIMAL(15,2)
);

-- Create Employees Table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(101,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DepartmentID INT NOT NULL,
    Salary DECIMAL(10,2),
    HireDate DATE,
    JobTitle VARCHAR(50),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- Insert Sample Data
INSERT INTO Departments (DepartmentName, Location, BudgetAmount)
VALUES 
    ('IT', 'New York', 500000),
    ('HR', 'Boston', 300000),
    ('Sales', 'Chicago', 400000),
    ('Finance', 'New York', 350000);

INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, HireDate, JobTitle)
VALUES 
    ('John', 'Doe', 1, 75000, '2022-01-15', 'Senior Developer'),
    ('Jane', 'Smith', 1, 70000, '2022-03-20', 'Developer'),
    ('Bob', 'Johnson', 2, 60000, '2021-06-10', 'HR Manager'),
    ('Alice', 'Williams', 3, 65000, '2023-02-01', 'Sales Manager'),
    ('Charlie', 'Brown', 1, 72000, '2022-11-05', 'Database Admin'),
    ('Diana', 'Davis', 4, 68000, '2023-05-12', 'Financial Analyst');
```

#### Aggregate Function Examples:

```sql
-- Total salary cost per department
SELECT 
    d.DepartmentName,
    COUNT(e.EmployeeID) AS EmployeeCount,
    SUM(e.Salary) AS TotalSalary,
    AVG(e.Salary) AS AverageSalary,
    MAX(e.Salary) AS HighestSalary,
    MIN(e.Salary) AS LowestSalary
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
GROUP BY d.DepartmentID, d.DepartmentName
ORDER BY TotalSalary DESC;

-- Employees earning above average salary
SELECT 
    FirstName,
    LastName,
    Salary
FROM Employees
WHERE Salary > (SELECT AVG(Salary) FROM Employees)
ORDER BY Salary DESC;

-- Departments with more than 1 employee
SELECT 
    d.DepartmentName,
    COUNT(e.EmployeeID) AS EmployeeCount
FROM Departments d
INNER JOIN Employees e ON d.DepartmentID = e.DepartmentID
GROUP BY d.DepartmentID, d.DepartmentName
HAVING COUNT(e.EmployeeID) > 1;
```

#### Advanced Subquery Examples:

```sql
-- Find employees in the highest-paying department
SELECT FirstName, LastName, Salary, JobTitle
FROM Employees
WHERE DepartmentID = (
    SELECT DepartmentID
    FROM Employees
    GROUP BY DepartmentID
    ORDER BY AVG(Salary) DESC
    LIMIT 1
);

-- List all employees with salary greater than their department's average
SELECT 
    e.FirstName,
    e.LastName,
    e.Salary,
    d.DepartmentName,
    (SELECT AVG(Salary) FROM Employees WHERE DepartmentID = d.DepartmentID) AS DeptAvgSalary
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > (
    SELECT AVG(Salary) 
    FROM Employees 
    WHERE DepartmentID = d.DepartmentID
);

-- Find departments where total salary exceeds budget
SELECT 
    d.DepartmentName,
    d.BudgetAmount,
    SUM(e.Salary) AS ActualSalary,
    (SUM(e.Salary) - d.BudgetAmount) AS BudgetOverage
FROM Departments d
INNER JOIN Employees e ON d.DepartmentID = e.DepartmentID
GROUP BY d.DepartmentID, d.DepartmentName, d.BudgetAmount
HAVING SUM(e.Salary) > d.BudgetAmount;
```

---

## ⚡ Advanced DBMS Topics

### Performance Optimization

> 💡 **Simple Explanation:** Optimization is like organizing a library with a card catalog - finding books becomes lightning fast!

### Why Optimize?
- 🐌 **Before:** Queries take minutes, users frustrated
- ⚡ **After:** Instant results, happy users!

### 1. Indexing
**What is an Index?** Like a book's index - jump directly to what you need instead of reading every page!
```sql
-- Create index for faster queries
CREATE INDEX idx_employee_department ON Employees(Department);
CREATE UNIQUE INDEX idx_employee_email ON Employees(Email);
```

### 2. Query Optimization Techniques

| Technique | Description | Example |
|-----------|-------------|---------|
| **Use Indexes** | Speed up data retrieval | Create indexes on frequently queried columns |
| **Avoid SELECT *** | Request only needed columns | `SELECT FirstName, LastName` instead of `SELECT *` |
| **Use WHERE Wisely** | Filter early | Apply filters in WHERE clause |
| **Avoid Functions on Columns** | Prevent index usage | `WHERE OrderDate >= '2024-01-01'` not `WHERE YEAR(OrderDate) = 2024` |
| **Use JOINS over Subqueries** | Better performance | Prefer JOIN when possible |
| **Limit Results** | Reduce data transfer | Use `TOP` or `LIMIT` |

```sql
-- ❌ Bad Practice
SELECT * FROM Employees WHERE YEAR(HireDate) = 2024;

-- ✅ Good Practice
SELECT EmployeeID, FirstName, LastName, Department 
FROM Employees 
WHERE HireDate >= '2024-01-01' AND HireDate < '2025-01-01';
```

### 3. Execution Plan Analysis
```sql
-- View execution plan in MSSQL
SET SHOWPLAN_ALL ON;
GO
SELECT * FROM Employees WHERE Department = 'IT';
GO
SET SHOWPLAN_ALL OFF;
```

---

### 🔐 Security & Administration

> 💡 **Remember:** A database breach can cost millions! Security is NOT optional.

### 🛡️ The Security Triangle:
```
        Confidentiality
             △
            / \
           /   \
          /     \
         /       \
    Integrity ─── Availability
```

### Security Best Practices:

| Practice | Implementation |
|----------|---------------|
| **Principle of Least Privilege** | Grant minimum necessary permissions |
| **Use Strong Authentication** | Implement strong passwords & MFA |
| **Encrypt Sensitive Data** | Use TDE, Always Encrypted |
| **Regular Backups** | Automated backup schedules |
| **Audit & Monitoring** | Enable SQL Server Audit |
| **SQL Injection Prevention** | Use parameterized queries |

### User Management:
```sql
-- Create login and user
CREATE LOGIN AppUser WITH PASSWORD = 'StrongP@ssw0rd!';
CREATE USER AppUser FOR LOGIN AppUser;

-- Grant permissions
GRANT SELECT, INSERT, UPDATE ON Employees TO AppUser;
DENY DELETE ON Employees TO AppUser;

-- Create role
CREATE ROLE DataReader;
GRANT SELECT ON SCHEMA::dbo TO DataReader;
ALTER ROLE DataReader ADD MEMBER AppUser;
```

### Backup & Recovery:
```sql
-- Full backup
BACKUP DATABASE CompanyDB 
TO DISK = 'C:\Backups\CompanyDB_Full.bak'
WITH FORMAT, COMPRESSION;

-- Restore database
RESTORE DATABASE CompanyDB 
FROM DISK = 'C:\Backups\CompanyDB_Full.bak'
WITH REPLACE;
```

---

## 🛠️ Tools & Environment

Here are the tools and technologies I'm using in my DBMS learning journey:

<div align="center">

### 💾 Database
![MSSQL](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
- **Microsoft SQL Server (MSSQL)**: Primary RDBMS for learning and practice.
  - **Edition**: Developer Edition / Express
  - **Features**: T-SQL, Stored Procedures, Triggers, Views

### 💻 Development Tools
![VS Code](https://img.shields.io/badge/Visual%20Studio%20Code-007ACC?style=for-the-badge&logo=visual%20studio%20code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)
- **Visual Studio Code**: Lightweight code editor with powerful SQL extensions for database scripting.
  - **Extensions Used**: `mssql` (Microsoft SQL Server extension), `SQL Server (mssql)`, `SQLTools`, `Database Client`
  - **Recommended VS Code Settings**:
    ```json
    {
      "mssql.format.alignColumnDefinitionsInColumns": true,
      "mssql.intelliSense.enableIntelliSense": true,
      "editor.formatOnSave": true
    }
    ```
- **Visual Studio**: Full-featured IDE for C# development with integrated ADO.NET capabilities.
- **Docker**: Containerization platform used for running SQL Server in isolated and portable environments, simplifying setup and avoiding local machine clutter.
  - **Running SQL Server in a container for development:**
    ```bash
    # Step 1: Pull MSSQL Docker image
    docker pull mcr.microsoft.com/mssql/server:2022-latest

    # Step 2: Run SQL Server container
    docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Password" \\
      -p 1433:1433 --name mssql-server \\
      -d mcr.microsoft.com/mssql/server:2022-latest

    # Step 3: Verify container is running
    docker ps

    # Step 4: Connect to container
    docker exec -it mssql-server /opt/mssql-tools/bin/sqlcmd \\
      -S localhost -U SA -P "YourStrong@Password"

    # Useful Docker Commands:
    docker stop mssql-server     # Stop the container
    docker start mssql-server    # Start the container
    docker logs mssql-server     # View logs
    ```
  - **Docker Compose Setup Example:**
    ```yaml
    version: '3.8'
    services:
      mssql:
        image: mcr.microsoft.com/mssql/server:2022-latest
        container_name: mssql-dev
        environment:
          - ACCEPT_EULA=Y
          - SA_PASSWORD=YourStrong@Password
          - MSSQL_PID=Developer
        ports:
          - "1433:1433"
        volumes:
          - mssql-data:/var/opt/mssql
    volumes:
      mssql-data:
    ```

### 💻 Programming Languages & Frameworks
![CSharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![SQL](https://img.shields.io/badge/SQL-336791?style=for-the-badge&logo=sql&logoColor=white)
- **C# (.NET)**: Modern, object-oriented programming language used for building data-driven applications.
- **ADO.NET**: Microsoft .NET Framework component providing robust data access services from various databases.
  - **Purpose**: A set of software components for accessing data and data services from a database.
  - **Features**:
    - **Data Providers**: Connect to various data sources (SQL Server, Oracle, MySQL, etc.)
    - **DataSet**: In-memory cache of data, independent of the data source.
    - **Connected Layer**: `Connection`, `Command`, `DataReader` for direct database interaction.
    - **Disconnected Layer**: `DataSet`, `DataAdapter` for working with data offline.
  - **Use Case**: Essential for building powerful and flexible data access layers in .NET applications.
  - **Key ADO.NET Components**:
    | Component | Purpose | Example |
    |-----------|---------|---------|
    | **SqlConnection** | Establishes connection to SQL Server database | `new SqlConnection(connectionString);` |
    | **SqlCommand** | Executes SQL queries or stored procedures | `cmd.CommandText = "SELECT * FROM Employees";` |
    | **SqlDataReader** | Reads data in forward-only, read-only mode (fast) | `while (reader.Read()) { }` |
    | **SqlDataAdapter** | Fills DataSet with data and updates database | `adapter.Fill(dataSet);` |
    | **DataSet** | In-memory representation of database tables | Works offline, then sync with DB |
    | **SqlParameter** | Prevents SQL injection attacks | `cmd.Parameters.AddWithValue("@id", 1);` |
  - **ADO.NET Connection String Example**:
    ```csharp
    // SQL Server Connection String
    string connectionString = "Data Source=localhost;Initial Catalog=CompanyDB;User ID=sa;Password=YourPassword;";
    SqlConnection connection = new SqlConnection(connectionString);
    ```

</div>

---

## 📖 Learning Resources

- 📚 [Microsoft SQL Server Documentation](https://docs.microsoft.com/en-us/sql/) - Official documentation for MSSQL.
- 🎥 [SQL Tutorial Videos](https://www.youtube.com/results?search_query=sql+tutorial) - Video tutorials for SQL learning.
- 💡 [W3Schools SQL](https://www.w3schools.com/sql/) - Interactive SQL tutorials and references.
- 🏆 [HackerRank SQL Practice](https://www.hackerrank.com/domains/sql) - Platform for practicing SQL challenges.
- 📝 [LeetCode Database Problems](https://leetcode.com/problemset/database/) - LeetCode problems focused on database concepts.

---

## 📝 Notes

> **"Data is the new oil, but databases are the refineries."**

This repository documents my journey in mastering database management. Feel free to explore the code examples and practice files!

---

Last Updated: February 9, 2026

---

### 🤝 Connect & Collaborate

If you're also learning DBMS, feel free to connect and share knowledge!

Happy Learning! 🚀