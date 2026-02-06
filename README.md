# 🎓 BridgeLabz Training Journey

> A comprehensive log of my learning journey at BridgeLabz, documenting daily progress, concepts learned, and projects completed.

---

## 📅 Progress Log

### **02-Feb-2026** | IPL Censorship Analyzer - Project Configuration & Sample Data Setup

#### 📚 Topic Covered
**NuGet Package Management, Project Configuration & Sample Data Integration**

---

#### ✅ Tasks Completed

| # | Task | Description | Implementation | Status |
|---|------|-------------|----------------|--------|
| 1 | **NuGet Configuration** | Created project.assets.json and project.nuget.cache for NuGet package management | [ipl-censorship-analyser.csproj](io-csharp-practice/gcr-code-base/ipl-censorship-analyser/ipl-censorship-analyser.csproj) | ✅ Done |
| 2 | **NuGet Support Files** | Added NuGet properties and targets files to support project restoration | [ipl-censorship-analyser.csproj.nuget.g.props](io-csharp-practice/gcr-code-base/ipl-censorship-analyser/obj/ipl-censorship-analyser.csproj.nuget.g.props) | ✅ Done |
| 3 | **Sample Data Integration** | Added sample CSV and JSON files with match data for testing and analysis | [sample.csv](io-csharp-practice/gcr-code-base/ipl-censorship-analyser/sample.csv) & [sample.json](io-csharp-practice/gcr-code-base/ipl-censorship-analyser/sample.json) | ✅ Done |
| 4 | **JSON Library Integration** | Integrated Newtonsoft.Json package version 13.0.4 for JSON handling | [project.assets.json](io-csharp-practice/gcr-code-base/ipl-censorship-analyser/obj/project.assets.json) | ✅ Done |

**Total Completed:** 4/4 Tasks ✅

---

#### 🎯 Key Learnings
- NuGet package management and dependency resolution
- Project configuration and build restoration process
- Working with project.assets.json and cache management
- Integration of third-party libraries (Newtonsoft.Json)
- Sample data creation for IPL match statistics
- Project structure organization for data analysis
- CSV and JSON data format handling for IPL data

---

#### 🛠️ Technologies Used
- **Language**: C# (.NET)
- **Libraries**: Newtonsoft.Json 13.0.4
- **Concepts**: NuGet Management, Project Configuration, Data Handling
- **Tools**: Visual Studio Code, .NET SDK, NuGet Package Manager
- **Data Formats**: CSV, JSON

---

### **01-Feb-2026** | JSON Handling - Data Processing & Validation

#### 📚 Topic Covered
**JSON File Operations, Parsing, Validation & Object Conversion**

---

#### ✅ Tasks Completed

| # | Task | Description | Implementation | Status |
|---|------|-------------|----------------|--------|
| 1 | **Create JSON** | Create and write objects to JSON files | [CreateJson.cs](io-csharp-practice/gcr-code-base/json-data-handling/practice-problem/basic-json-handling/CreateJson.cs) | ✅ Done |
| 2 | **Convert C# Object to JSON** | Convert strongly-typed C# objects into JSON format | [ConvertCsharpObjectToJson.cs](io-csharp-practice/gcr-code-base/json-data-handling/practice-problem/basic-json-handling/ConvertCsharpObjectToJson.cs) | ✅ Done |
| 3 | **Read JSON** | Read and parse JSON files using JsonConvert | [ReadJson.cs](io-csharp-practice/gcr-code-base/json-data-handling/practice-problem/basic-json-handling/ReadJson.cs) | ✅ Done |
| 4 | **Merge JSON Objects** | Merge two JSON objects into a single combined object | [MergeJson.cs](io-csharp-practice/gcr-code-base/json-data-handling/practice-problem/intermediate-json-handling/MergeJson.cs) | ✅ Done |
| 5 | **Validate JSON Object** | Validate JSON against a defined schema and structure | [ValidateJsonScehma.cs](io-csharp-practice/gcr-code-base/json-data-handling/practice-problem/basic-json-handling/ValidateJsonScehma.cs) | ✅ Done |

**Total Completed:** 5/5 Tasks ✅

---

#### 🎯 Key Learnings
- Newtonsoft.Json (JSON.NET) library for JSON operations
- Serialization and deserialization of objects
- JsonConvert.SerializeObject() and JsonConvert.DeserializeObject()
- Handling nested JSON structures
- Schema validation and error handling
- LINQ queries on JSON data
- Performance considerations with large JSON files
- Object mapping and type conversion

---

#### 🛠️ Technologies Used
- **Language**: C# (.NET)
- **Libraries**: Newtonsoft.Json, System.Text.Json
- **Concepts**: JSON Parsing, Serialization, Validation, LINQ
- **Tools**: Visual Studio Code, .NET SDK

---

### **30-Jan-2026** | Address Book System - CSV File I/O Implementation

#### 📚 Topic Covered
**CSV File Read/Write Operations, Data Persistence & Role-Based Access Control**

---

#### ✅ Tasks Completed

| # | Task | Description | Implementation | Status |
|---|------|-------------|----------------|--------|
| 1 | **Address Book Management** | Create multiple address books with unique names | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 2 | **Contact Operations** | Add, edit, delete and display contacts with full details | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 3 | **Duplicate Prevention** | Prevent duplicate contacts based on first name | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 4 | **Search by City** | Search and display contacts across all address books by city | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 5 | **Search by State** | Search and display contacts across all address books by state | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 6 | **Count by City** | Count contacts by city with breakdown per address book | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 7 | **Count by State** | Count contacts by state with breakdown per address book | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 8 | **Alphabetical Sorting** | Sort and display contacts alphabetically by first name using LINQ | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 9 | **Role-Based Access** | Admin and User roles with different permissions | [AddressBookOperations.cs](io-csharp-practice/scenario-base/AddressBook/AddressBookOperations.cs) | ✅ Done |
| 10 | **Write to CSV File** | Export all address books and contacts to CSV file with headers using StreamWriter | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |
| 11 | **Read from CSV File** | Import address books and contacts from CSV file using StreamReader with validation | [ContactImpl.cs](io-csharp-practice/scenario-base/AddressBook/ContactImpl.cs) | ✅ Done |

**Total Completed:** 11/11 Tasks ✅

---

#### 🎯 Key Learnings
- **CSV File I/O Operations**: StreamWriter for writing and StreamReader for reading CSV files
- **CSV Data Structure**: Creating properly formatted CSV files with headers (AddressBookName, FirstName, LastName, Address, City, State, ZIPCode, PhoneNumber, Email)
- **Data Persistence**: Saving multiple address books with all contact details to CSV format for long-term storage
- **CSV Parsing**: Reading and parsing comma-separated values to reconstruct objects
- **Error Handling**: Try-catch blocks for file operations (file not found, access denied, etc.) with user-friendly messages
- **Data Validation**: File existence checks, CSV structure validation, and user confirmation before overwriting
- **Role-Based Access Control**: Admin (full access) vs User (read-only) permissions
- **LINQ Operations**: OrderBy for sorting, Where for filtering, FirstOrDefault for searching
- **Dictionary Collections**: Managing multiple address books with key-value pairs
- **Object-Oriented Design**: Interface implementation and separation of concerns
- **Input Validation**: Duplicate detection and data integrity checks

---

#### 🛠️ Technologies Used
- **Language**: C# (.NET)
- **Concepts**: File I/O, Stream Processing, LINQ, Collections (Dictionary, List), OOP, Interfaces
- **Tools**: Visual Studio Code, .NET SDK
- **Data Format**: CSV (Comma-Separated Values)

---

#### 📋 Features Implemented

**Core Address Book Features:**
- ✅ Multiple address book management
- ✅ Contact CRUD operations (Create, Read, Update, Delete)
- ✅ Duplicate contact prevention
- ✅ Alphabetical sorting of contacts
- ✅ Search contacts by city or state across all address books
- ✅ Count contacts by city or state with detailed breakdown

**CSV File I/O Features:**
- ✅ **Write to CSV File**: Export all address books and contacts to CSV format with proper headers
- ✅ **Read from CSV File**: Import address books and contacts from CSV file with data validation
- ✅ **CSV Structure**: Organized format (AddressBookName,FirstName,LastName,Address,City,State,ZIPCode,PhoneNumber,Email)
- ✅ Data persistence across application sessions
- ✅ User-friendly file naming (auto .csv extension)
- ✅ Confirmation prompts before data replacement operations
- ✅ Comprehensive error handling for file operations

**Access Control:**
- ✅ **Admin Role** (ABC@gmail.com): Full access to all features
- ✅ **User Role** (Others): Read-only access (view, search, count)

---

#### 📁 Project Structure

```
AddressBook/
├── AddressBook.cs                 # Main entry point
├── AddressBookOperations.cs       # Menu system & role management
├── ContactDetails.cs              # Contact model with properties
├── ContactImpl.cs                 # Core business logic & file I/O
├── IContact.cs                    # Interface definition
└── AddressBook.csproj            # Project configuration
```

---

### **29-Jan-2026** | Stream I/O - CSV Data Handling

#### 📚 Topic Covered
**Stream I/O Operations & CSV File Manipulation**

---

#### ✅ Tasks Completed

<details open>
<summary><strong>🟢 Basic Level</strong></summary>

| Task | Description | Implementation |
|------|-------------|----------------|
| **Read CSV** | Read and display data from a CSV file | [ReadCSV.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/basic/ReadCSV.cs) |
| **Write CSV** | Create and write data to a CSV file | [WriteCSV.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/basic/WriteCSV.cs) |
| **Count Rows** | Read CSV file and count total number of rows | [ReadAndCountRows.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/basic/ReadAndCountRows.cs) |

</details>

<details open>
<summary><strong>🟡 Intermediate Level</strong></summary>

| Task | Description | Implementation |
|------|-------------|----------------|
| **Filter Records** | Filter and display records based on specific criteria (salary) | [FilterRecord.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/intermediate/FilterRecord.cs) |
| **Search Records** | Search for specific employee records by name | [SearchRecord.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/intermediate/SearchRecord.cs) |
| **Modify CSV** | Update salary for IT department employees (10% increment) | [ModifyCSV.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/intermediate/ModifyCSV.cs) |
| **Sort CSV** | Sort employees by salary and display top 5 highest earners | [SortCSV.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/intermediate/SortCSV.cs) |

</details>

<details open>
<summary><strong>🔴 Advanced Level</strong></summary>

| Task | Description | Implementation |
|------|-------------|----------------|
| **Detect Duplicates** | Read CSV file and detect duplicate entries based on ID column | [DeleteDuplicate.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/advance/DeleteDuplicate.cs) |
| **Validate CSV** | Validate email and phone number formats using regex patterns | [ValidateCSV.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/advance/ValidateCSV.cs) |
| **Merge CSV** | Merge two CSV files based on common Age column | [MergeCSV.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/advance/MergeCSV.cs) |
| **CSV to Objects** | Convert CSV data into C# objects (Student class) | [ConvertCSVDataintoCsharpObject.cs](io-csharp-practice/gcr-code-base/csv-data-hadling/advance/ConvertCSVDataintoCsharpObject.cs) |

</details>

---

#### 🎯 Key Learnings
- `StreamReader` and `StreamWriter` for file I/O operations
- CSV parsing using `Split()` method
- LINQ operations for filtering, sorting, and grouping data
- Regular expressions for data validation
- Dictionary and List collections for data manipulation
- Object-oriented approach to CSV data handling

---

#### 🛠️ Technologies Used
- **Language**: C# (.NET)
- **Concepts**: File I/O, Stream Processing, LINQ, Regex, Collections
- **Tools**: Visual Studio Code, .NET SDK

---

## 📊 Overall Progress

| Category | Date | Skills Acquired | Tasks Completed |
|----------|------|-----------------|-----------------|
| **Address Book System** | 30-Jan-2026 | CSV File I/O, data persistence, role-based access, LINQ operations | 11/11 ✅ |
| **IPL Censorship Analyzer** | 02-Feb-2026 | NuGet management, project configuration, data integration | 4/4 ✅ |
| **JSON Handling** | 01-Feb-2026 | Object conversion, reading, merging, validation | 5/5 ✅ |
| **Stream I/O** | 29-Jan-2026 | File reading, writing, and manipulation | 12 |
| **Data Processing** | 29-Jan-2026 | Filtering, sorting, searching, validation | - |
| **Advanced Operations** | 29-Jan-2026 | Duplicate detection, merging, object mapping | - |

---

*Last Updated: 30-Jan-2026*