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
| **IPL Censorship Analyzer** | 02-Feb-2026 | NuGet management, project configuration, data integration | 4/4 ✅ |
| **JSON Handling** | 01-Feb-2026 | Object conversion, reading, merging, validation | 5/5 ✅ |
| **Stream I/O** | 29-Jan-2026 | File reading, writing, and manipulation | 12 |
| **Data Processing** | 29-Jan-2026 | Filtering, sorting, searching, validation | - |
| **Advanced Operations** | 29-Jan-2026 | Duplicate detection, merging, object mapping | - |

---

*Last Updated: 02-Feb-2026*