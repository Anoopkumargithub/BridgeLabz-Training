# 🎓 BridgeLabz-Training - DBMS Learning Journey

Welcome to my Database Management Systems (DBMS) learning repository! This contains my progress, notes, and practice exercises as I master database concepts and SQL.

---

## �📚 Table of Contents
- [What is DBMS?](#-what-is-dbms)
- [Types of DBMS](#-types-of-dbms)
- [SQL Language Categories](#-sql-language-categories)
- [Normalization](#-normalization)
- [Joins](#-joins)
- [Performance Optimization](#-performance-optimization)
- [Security & Administration](#-security--administration)
- [Tools & Environment](#-tools--environment)

---

## 🗄️ What is DBMS?

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

## 🔧 Types of DBMS

| Type | Description | Examples |
|------|-------------|----------|
| **Relational DBMS (RDBMS)** | Data stored in tables with relationships | MySQL, PostgreSQL, **MSSQL**, Oracle |
| **NoSQL DBMS** | Non-relational, flexible schema | MongoDB, Cassandra, Redis |
| **Object-Oriented DBMS** | Data stored as objects | ObjectDB, db4o |
| **Hierarchical DBMS** | Tree-like structure | IBM IMS |
| **Network DBMS** | Graph structure with multiple relationships | IDMS, TurboIMAGE |
| **Columnar DBMS** | Column-oriented storage | Apache Cassandra, HBase |

---

## 💻 SQL Language Categories

```
┌─────────────────────────────────────────────┐
│                    SQL COMMANDS                                                                     │
├─────────────────────────────────────────────┤
│  DDL  │  DML  │  DQL  │  DCL  │  TCL                                                        │
│ (Structure) (Data) (Query) (Access) (Trans)                                                  │
└─────────────────────────────────────────────┘
```

### 1️⃣ DDL (Data Definition Language)
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

### 2️⃣ DML (Data Manipulation Language)
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

### 3️⃣ DQL (Data Query Language)
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

### 4️⃣ DCL (Data Control Language)
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

### 5️⃣ TCL (Transaction Control Language)
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

## 📐 Normalization

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

## 🔗 Joins

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

## ⚡ Performance Optimization

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

## 🔐 Security & Administration

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

### My Learning Stack:

#### 💾 Microsoft SQL Server (MSSQL)
- **Purpose**: Primary RDBMS for learning and practice
- **Edition**: Developer Edition / Express
- **Features**: T-SQL, Stored Procedures, Triggers, Views

#### 💻 Visual Studio Code
- **Extensions Used**:
  - `mssql` - Microsoft SQL Server extension
  - `SQL Server (mssql)`
  - `SQLTools`
  - `Database Client`

```json
// Recommended VS Code Settings
{
  "mssql.format.alignColumnDefinitionsInColumns": true,
  "mssql.intelliSense.enableIntelliSense": true,
  "editor.formatOnSave": true
}
```

#### 🐳 Docker
**Why Docker?** Isolated, portable, and easy to set up - no mess on your local machine!

Running SQL Server in a container for development:

```bash
# Step 1: Pull MSSQL Docker image
docker pull mcr.microsoft.com/mssql/server:2022-latest

# Step 2: Run SQL Server container
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong@Password" \
  -p 1433:1433 --name mssql-server \
  -d mcr.microsoft.com/mssql/server:2022-latest

# Step 3: Verify container is running
docker ps

# Step 4: Connect to container
docker exec -it mssql-server /opt/mssql-tools/bin/sqlcmd \
  -S localhost -U SA -P "YourStrong@Password"

# Useful Docker Commands:
docker stop mssql-server     # Stop the container
docker start mssql-server    # Start the container
docker logs mssql-server     # View logs
```

**Docker Compose Setup:**
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

---

## 📖 Learning Resources

- 📚 [Microsoft SQL Server Documentation](https://docs.microsoft.com/en-us/sql/)
- 🎥 [SQL Tutorial Videos](https://www.youtube.com/results?search_query=sql+tutorial)
- 💡 [W3Schools SQL](https://www.w3schools.com/sql/)
- 🏆 [HackerRank SQL Practice](https://www.hackerrank.com/domains/sql)
- 📝 [LeetCode Database Problems](https://leetcode.com/problemset/database/)

---

## 📂 Repository Structure

```
BridgeLabz-Training/
│
├── README.md                    # This file - Your DBMS learning guide
├── dbms-practice/               # Practice exercises and examples
│   ├── gcr-code-base/
│   │   └── Joins.sql           # SQL joins practice
│   ├── ddl-examples/           # Data Definition Language examples
│   ├── dml-examples/           # Data Manipulation Language examples
│   ├── normalization/          # Normalization exercises
│   └── performance/            # Query optimization practice
└── projects/                    # Real-world database projects
```

---

## 📝 Notes

> **"Data is the new oil, but databases are the refineries."**

This repository documents my journey in mastering database management. Feel free to explore the code examples and practice files!

---

**Last Updated:** February 6, 2026  
**Currently Learning:** SQL Joins & Performance Optimization

---


## � Tech Stack

<div align="center">

### 💾 Database
![MSSQL](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

### 💻 Development Tools
![VS Code](https://img.shields.io/badge/Visual%20Studio%20Code-007ACC?style=for-the-badge&logo=visual%20studio%20code&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)

</div>

**Technologies I'm Using:**
- **Microsoft SQL Server (MSSQL)**: Enterprise-grade relational database management system
- **Visual Studio Code**: Lightweight but powerful code editor with SQL extensions
- **Docker**: Containerization platform for running SQL Server in isolated environments

---


### 🤝 Connect & Collaborate

If you're also learning DBMS, feel free to connect and share knowledge!

Happy Learning! 🚀