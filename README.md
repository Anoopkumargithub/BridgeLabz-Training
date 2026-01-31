# 🎓 BridgeLabz-Training

## 🚀 Collection Framework & Advanced C# Practice

> **A comprehensive mastery guide to C# Collections Framework, Reflection API, Regex, and Real-world System Design**
> 
> Includes 56+ implementations covering data structures, reflection, attributes, regex processing, and banking systems

---

### 🎯 Quick Stats
- **Total Implementations:** 56+
- **Completion Rate:** 100% ✅
- **Topics Covered:** 4 Major Areas
- **Framework:** .NET 8.0+
- **Language:** C# 9.0+

---

## Assignment Progress Tracker

### 📅 January 28, 2026 - ✅ COMPLETED

**Assignment:** Reflection in C# - Advanced Concepts, Custom Attributes & Banking System

**Status:** ✅ COMPLETED & TESTED

#### Tasks Completed Today:

| # | Task | File(s) | Status |
|---|------|---------|--------|
| 1 | Dependency Injection Container | `reflection/DIContainer.cs` | ✅ Done |
| 2 | JSON Generator | `reflection/JsonGenerator.cs` | ✅ Done |
| 3 | Logger Proxy | `reflection/LoggerProxy.cs` | ✅ Done |
| 4 | Method Timer | `reflection/MethodTimer.cs` | ✅ Done |
| 5 | Object Mapper | `reflection/ObjectMapper.cs` | ✅ Done |
| 6 | Access Private Field | `reflection/AccessPrivateField.cs` | ✅ Done |
| 7 | Class Info | `reflection/ClassInfo.cs` | ✅ Done |
| 8 | Dynamic Object | `reflection/DynamicObject.cs` | ✅ Done |
| 9 | Invoke Private Method | `reflection/InvokePrivateMethod.cs` | ✅ Done |
| 10 | Attribute Demo | `reflection/AttributeDemo.cs` | ✅ Done |
| 11 | Dynamic Invoke | `reflection/DynamicInvoke.cs` | ✅ Done |
| 12 | Modify Static | `reflection/ModifyStatic.cs` | ✅ Done |
| 13 | CacheResult Attribute | `attributes/CacheResult.cs` | ✅ Done |
| 14 | TaskInfo Attribute | `attributes/TaskInfo.cs` | ✅ Done |
| 15 | ImportantMethod Attribute | `attributes/ImportantMethod.cs` | ✅ Done |
| 16 | MaxLength Attribute | `attributes/MaxLength.cs` | ✅ Done |
| 17 | BugReport Attribute | `attributes/BugReport.cs` | ✅ Done |
| 18 | RoleAllowed Attribute | `attributes/RoleAllowed.cs` | ✅ Done |
| 19 | Todo Attribute | `attributes/Todo.cs` | ✅ Done |
| 20 | Suppress Warnings Attribute | `attributes/SuppressWarnings.cs` | ✅ Done |
| 21 | Implement BankAccount Class | `BankAccount/BankAccount.cs` | ✅ Done |
| 22 | Unit Tests for BankAccount | `BankAccount.Tests/Test1.cs` | ✅ Done |

**Total:** 22/22 Tasks Completed ✅

**Learnings:**
- Explored C# Reflection API for runtime type inspection
- Implemented Dependency Injection container using reflection
- Created dynamic object creation and method invocation
- Worked with attributes and metadata
- Accessed and modified private members using reflection
- Built proxies and decorators with reflection
- Performance measurement using MethodTimer
- Custom serialization with JsonGenerator
- **Designed and implemented custom attributes from scratch**
- **Applied attributes to classes, methods, properties, and parameters**
- **Used reflection to read and process custom attributes at runtime**
- **Built attribute-based validation and caching mechanisms**
- **Created security-related attributes for role-based access control**
- **Implemented documentation attributes for runtime API documentation**
- **Implemented BankAccount class with financial operations**
- **Created comprehensive unit tests using NUnit framework**

---

## Banking System Implementation ✨

### BankAccount Class - Financial Operations Module

**Overview:** A robust banking system implementation demonstrating object-oriented principles with comprehensive testing.

#### Key Features:

```csharp
public class BankAccount
{
    public decimal Balance { get; set; }

    // Constructor with initial balance
    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    // Deposit funds with validation
    public void Deposit(decimal amount)
    {
        if(amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative");
        }
        Balance += amount;
    }

    // Withdraw funds with balance check
    public void Withdraw(decimal amount)
    {
        if(amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        Balance -= amount;
    }
}
```

#### Core Functionalities:

| Feature | Description | Exception |
|---------|-------------|-----------|
| Deposit | Add funds to account | ArgumentException for negative amounts |
| Withdraw | Remove funds from account | InvalidOperationException for insufficient balance |
| Balance Tracking | Real-time balance updates | - |

#### Unit Tests - NUnit Framework

**Test Coverage:**

1. ✅ **Deposit Positive Amount** - Validate balance increases correctly
2. ✅ **Withdraw Valid Amount** - Verify balance decreases correctly
3. ✅ **Withdraw More Than Balance** - Ensure exception is thrown
4. ✅ **Deposit Negative Amount** - Ensure validation catches invalid input

**Example Test:**
```csharp
[Test]
public void TestDeposit()
{
    BankAccount account = new BankAccount(1000);
    account.Deposit(500);
    Assert.That(account.Balance, Is.EqualTo(1500));
}
```

---

## Custom Attributes and Annotations (8 Tasks - ✅ All Completed)

Master attribute creation and usage with reflection-driven functionality:

### 1. CacheResult.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Cache method results with configurable TTL (Time-To-Live)

**Key Concept:** Method interception and decorator pattern with caching
```csharp
[CacheResult(DurationSeconds = 60)]
public string FetchData(string key) { /* ... */ }
```
**Features:**
- Automatic result caching
- Configurable cache duration
- Cache invalidation after TTL
- Performance optimization

**Run:** `dotnet run attributes/CacheResult.cs`

---

### 2. TaskInfo.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Document task metadata with status tracking

**Key Concept:** Metadata annotation for documentation and runtime lookup
```csharp
[TaskInfo(
    Title = "Implement Login",
    Status = "In Progress",
    Priority = 2,
    AssignedTo = "Developer Name"
)]
public class LoginService { /* ... */ }
```
**Features:**
- Task title and description
- Status tracking (Pending, In Progress, Completed)
- Priority levels (1-5)
- Assignment tracking

**Run:** `dotnet run attributes/TaskInfo.cs`

---

### 3. ImportantMethod.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Mark critical methods for monitoring and logging

**Key Concept:** Aspect-oriented programming with method interception
```csharp
[ImportantMethod(RequiresAudit = true)]
public void ProcessPayment(decimal amount) { /* ... */ }
```
**Features:**
- Mark methods as critical
- Enable audit logging
- Enforce exception handling
- Track execution metrics

**Run:** `dotnet run attributes/ImportantMethod.cs`

---

### 4. MaxLength.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Validate property/parameter length constraints

**Key Concept:** Data validation attribute with reflection-based validation
```csharp
[MaxLength(100)]
public string Username { get; set; }

[MaxLength(256)]
public string EmailAddress { get; set; }
```
**Features:**
- String length validation
- Custom error messages
- Property-level constraints
- Runtime validation

**Run:** `dotnet run attributes/MaxLength.cs`

---

### 5. BugReport.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Track known bugs and issues in code

**Key Concept:** Documentation attribute for bug tracking
```csharp
[BugReport(
    BugId = "BUG-123",
    Description = "Off-by-one error in pagination",
    Severity = "High",
    ReportedBy = "QA Team",
    Status = "Pending Fix"
)]
public int GetPageNumber(int offset) { /* ... */ }
```
**Features:**
- Bug ID tracking
- Severity levels
- Resolution status
- Reporter information
- Optional: Compile-time warnings for unfixed bugs

**Run:** `dotnet run attributes/BugReport.cs`

---

### 6. RoleAllowed.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Enforce role-based access control (RBAC) on methods

**Key Concept:** Security attribute with runtime authorization checks
```csharp
[RoleAllowed("Admin", "Manager")]
public void DeleteUser(int userId) { /* ... */ }

[RoleAllowed("User")]
public void ViewProfile() { /* ... */ }
```
**Features:**
- Role-based access control
- Multiple roles support
- Runtime authorization enforcement
- Audit trail logging
- Exception handling for unauthorized access

**Run:** `dotnet run attributes/RoleAllowed.cs`

---

### 7. Todo.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Mark incomplete work items for developers

**Key Concept:** Development annotation attribute
```csharp
[Todo("Refactor this method for better performance")]
public void CalculateMetrics() { /* ... */ }

[Todo("Add error handling", Priority = "High")]
public void ProcessData() { /* ... */ }
```
**Features:**
- Task description
- Priority levels
- Assignment to developers
- Due date tracking
- Compile-time detection

**Run:** `dotnet run attributes/Todo.cs`

---

### 8. SuppressWarnings.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Suppress specific compiler and analysis warnings

**Key Concept:** Control code analysis and warning suppression
```csharp
[SuppressWarnings("CS0618", "Reason: Deprecated method still needed for compatibility")]
public void LegacyMethod() { /* ... */ }
```
**Features:**
- Suppress specific warning codes
- Document suppression reasons
- Category-based suppression
- Validation of warning codes

**Run:** `dotnet run attributes/SuppressWarnings.cs`

---

## Attribute Implementation Guide

### Creating Custom Attributes

```csharp
// Step 1: Define the attribute class
[AttributeUsage(
    AttributeTargets.Class | AttributeTargets.Method,
    AllowMultiple = false,
    Inherited = true
)]
public class MyAttribute : Attribute
{
    public string Name { get; set; }
    public int Value { get; set; }
}

// Step 2: Apply to target
[MyAttribute(Name = "Test", Value = 42)]
public class MyClass { }

// Step 3: Read with reflection
var attr = typeof(MyClass)
    .GetCustomAttribute<MyAttribute>();
Console.WriteLine($"{attr.Name}: {attr.Value}");
```

### Common AttributeUsage Targets

| Target | Description |
|--------|-------------|
| `AttributeTargets.Class` | Can be applied to classes |
| `AttributeTargets.Method` | Can be applied to methods |
| `AttributeTargets.Property` | Can be applied to properties |
| `AttributeTargets.Parameter` | Can be applied to parameters |
| `AttributeTargets.Field` | Can be applied to fields |
| `AttributeTargets.All` | Can be applied anywhere |

### Reading Attributes at Runtime

```csharp
// Get single attribute
var attr = typeof(MyClass)
    .GetCustomAttribute<MyAttribute>();

// Get all attributes
var attrs = typeof(MyClass)
    .GetCustomAttributes<MyAttribute>();

// Get method attributes
var methodAttrs = typeof(MyClass)
    .GetMethod("MyMethod")
    .GetCustomAttributes<MyAttribute>();
```

---

### 📅 January 27, 2026 - ✅ COMPLETED

**Assignment:** Regex Validation, Extraction & String Modification

**Status:** ✅ COMPLETED & TESTED

#### Tasks Completed Today:

| # | Task | File(s) | Status |
|---|------|---------|--------|
| 1 | Validate an IP Address | `regex/advance-problem/ValidateanIPAddress.cs` | ✅ Done |
| 2 | Validate Hex Color Code | `regex/basic-regex-problems/ValidHexColorCode.cs` | ✅ Done |
| 3 | Validate Vehicle Number Plate | `regex/basic-regex-problems/ValidNumberPlate.cs` | ✅ Done |
| 4 | Validate Username | `regex/basic-regex-problems/ValidUsername.cs` | ✅ Done |
| 5 | Extract Capitalized Words | `regex/extraction-problems/CapitalizedWordsfromaSentence.cs` | ✅ Done |
| 6 | Extract Email Addresses | `regex/extraction-problems/ExtractAllEmailAddressesfromaText.cs` | ✅ Done |
| 7 | Extract Dates | `regex/extraction-problems/ExtractDates.cs` | ✅ Done |
| 8 | Extract Webpage URLs | `regex/extraction-problems/ExtractWebpages.cs` | ✅ Done |
| 9 | Censor Bad Words | `regex/replace-modify-string/CensorBadWords.cs` | ✅ Done |
| 10 | Replace Multiple Spaces | `regex/replace-modify-string/MultipleSpacesToSingleSpace.cs` | ✅ Done |
| 11 | Database Connection | `database/DatabaseConnection.cs` | ✅ Done |
| 12 | File Processor | `file/FileProcessor.cs` | ✅ Done |
| 13 | Performance Testing Utilities | `testing/PerformanceTesting.cs` | ✅ Done |
| 14 | Parameterized Tests for Number Validation | `testing/NumberValidationTests.cs` | ✅ Done |
| 15 | Validate Credit Card Numbers | `regex/advance-problem/CreditCardNumber.cs` | ✅ Done |
| 16 | Extract Currency Values | `regex/advance-problem/CurrencyExtraction.cs` | ✅ Done |
| 17 | Detect Repeating Words | `regex/advance-problem/RepeatingWords.cs` | ✅ Done |
| 18 | Identify Programming Languages | `regex/advance-problem/ProgrammingLanguageDetection.cs` | ✅ Done |
| 19 | Validate Social Security Numbers | `regex/advance-problem/SocialSecurityNumber.cs` | ✅ Done |

**Total:** 19/19 Tasks Completed ✅

---

### 📅 January 21, 2026 - ✅ COMPLETED

**Assignment:** Collection Framework Implementation - Data Structures & Real-World Systems

**Status:** ✅ COMPLETED & TESTED

#### Tasks Completed Today:

| # | Task | File(s) | Status |
|---|------|---------|--------|
| 1 | Find Frequency of Elements | `FindFrequencyOfElements.cs` | ✅ Done |
| 2 | Remove Duplicate Elements | `RemoveDuplicateElement.cs` | ✅ Done |
| 3 | Reverse List - ArrayList | `ReverseListUsingArrayList.cs` | ✅ Done |
| 4 | Reverse List - LinkedList | `ReverseListUsingLinkedList.cs` | ✅ Done |
| 5 | Rotate Elements | `RotateElement.cs` | ✅ Done |
| 6 | Invert a Map | `InvertAMap.cs` | ✅ Done |
| 7 | Word Frequency Counter | `WordFrequencyCounter.cs` | ✅ Done |
| 8 | Generate Binary Numbers | `GenerateBinaryNumbers.cs` | ✅ Done |
| 9 | Reverse Queue | `ReverseQueue.cs` | ✅ Done |
| 10 | Check Equal Set | `CheckEqualSet.cs` | ✅ Done |
| 11 | Find Subset | `FindSubset.cs` | ✅ Done |
| 12 | Symmetric Difference | `SymmetricDifference.cs` | ✅ Done |
| 13 | Union & Intersection | `UnionIntersectionOfSet.cs` | ✅ Done |
| 14 | Shopping Cart System | `ShoppingCart.cs` | ✅ Done |
| 15 | Voting System | `VotingSystem.cs` | ✅ Done |

**Total:** 15/15 Tasks Completed ✅

---

### January 27, 2026 - nUnit Testing and New Implementations

**Learnings:**
- Explored nUnit testing framework for unit testing in C#.

**New Implementations:**
- Implemented `ListManager` and `StringUtils` classes with basic functionalities.
- Added corresponding tests for both classes.
- Updated project files for calculator and string utility applications.

**Next Steps:**
- Continue enhancing test coverage and functionalities for the new classes.

---

---

## 📊 Completion Summary - January 28, 2026

| Category | Total Tasks | Completed | Status | Progress |
|----------|-------------|-----------|--------|----------|
| Reflection Operations | 12 | 12 | 100% ✅ | ████████████ |
| Custom Attributes | 8 | 8 | 100% ✅ | ████████████ |
| Banking System | 2 | 2 | 100% ✅ | ████████████ |
| **TOTAL (Jan 28)** | **22** | **22** | **100% ✅** | **████████████** |

---

### 📈 Overall Progress - All Assignments

| Assignment | Date | Tasks | Status | Category |
|-----------|------|-------|--------|----------|
| Collection Framework | Jan 21 | 15/15 | ✅ COMPLETE | Data Structures |
| Regex Operations | Jan 27 | 19/19 | ✅ COMPLETE | String Processing |
| Reflection & Banking | Jan 28 | 22/22 | ✅ COMPLETE | Advanced OOP |
| **GRAND TOTAL** | - | **56/56** | **✅ 100%** | **All Topics** |

---

## Regex Operations (15 Tasks - ✅ All Completed)

Learn powerful text processing with Regex across validation, extraction, and string modification:

### 1. ValidateanIPAddress.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Validate IPv4 addresses

**Key Concept:** Anchored patterns, octet range checks
```
Input: 192.168.1.1
Output: Valid
```
**Run:** `dotnet run regex/advance-problem/ValidateanIPAddress.cs`

---

### 2. ValidHexColorCode.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Validate hex color codes (#RGB, #RRGGBB)

**Key Concept:** Character classes and grouping
```
Input: #1a2B3c
Output: Valid
```
**Run:** `dotnet run regex/basic-regex-problems/ValidHexColorCode.cs`

---

### 3. ValidNumberPlate.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Validate vehicle number plates (format-driven)

**Key Concept:** Position-specific tokens and optional groups
```
Input: MH12 AB 1234
Output: Valid
```
**Run:** `dotnet run regex/basic-regex-problems/ValidNumberPlate.cs`

---

### 4. ValidUsername.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Validate usernames with allowed characters and length

**Key Concept:** Boundaries and quantifiers
```
Input: user_123
Output: Valid
```
**Run:** `dotnet run regex/basic-regex-problems/ValidUsername.cs`

---

### 5. CapitalizedWordsfromaSentence.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Extract capitalized words from sentences

**Key Concept:** Word boundaries and character classes
```
Input: "The Quick brown Fox"
Output: [The, Quick, Fox]
```
**Run:** `dotnet run regex/extraction-problems/CapitalizedWordsfromaSentence.cs`

---

### 6. ExtractAllEmailAddressesfromaText.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Extract email addresses from text

**Key Concept:** Character sets, groups, and escaping special chars
```
Input: "Reach me at a.b@example.com and team@company.org"
Output: [a.b@example.com, team@company.org]
```
**Run:** `dotnet run regex/extraction-problems/ExtractAllEmailAddressesfromaText.cs`

---

### 7. ExtractDates.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Extract dates in common formats

**Key Concept:** Alternation and capturing groups
```
Input: "Today is 21/01/2026 and 2026-01-21"
Output: [21/01/2026, 2026-01-21]
```
**Run:** `dotnet run regex/extraction-problems/ExtractDates.cs`

---

### 8. ExtractWebpages.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Extract webpage URLs (http/https)

**Key Concept:** Optional groups and non-whitespace matching
```
Input: "Visit https://example.com and http://site.org/page"
Output: [https://example.com, http://site.org/page]
```
**Run:** `dotnet run regex/extraction-problems/ExtractWebpages.cs`

---

### 9. CensorBadWords.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Censor offensive words with masking

**Key Concept:** Case-insensitive matching and replacement
```
Input: "This is a badword!"
Output: "This is a ******!"
```
**Run:** `dotnet run regex/replace-modify-string/CensorBadWords.cs`

---

### 10. MultipleSpacesToSingleSpace.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Replace multiple spaces with a single space

**Key Concept:** Quantifiers and global replacement
```
Input: "Hello   world    !"
Output: "Hello world !"
```
**Run:** `dotnet run regex/replace-modify-string/MultipleSpacesToSingleSpace.cs`

---

### 11. Database Connection | `database/DatabaseConnection.cs` ✅
**Status:** Completed on January 27, 2026

**Purpose:** Establish a connection to a database

**Key Concept:** Connection string and configuration
```
Input: "Server=.;Database=TestDB;User=;Password="
Output: Connected
```
**Run:** `dotnet run database/DatabaseConnection.cs`

---

### 12. File Processor | `file/FileProcessor.cs` ✅
**Status:** Completed on January 27, 2026

**Purpose:** Process files (e.g., CSV, JSON)

**Key Concept:** File reading and parsing
```
Input: "data.csv"
Output: Processed rows
```
**Run:** `dotnet run file/FileProcessor.cs`

---

### 13. Performance Testing Utilities | `testing/PerformanceTesting.cs` ✅
**Status:** Completed on January 27, 2026

**Purpose:** Test performance of algorithms

**Key Concept:** Timing and memory usage
```
Input: "Find frequency of elements"
Output: Time taken: 0.001 seconds
```
**Run:** `dotnet run testing/PerformanceTesting.cs`

---

### 14. Parameterized Tests for Number Validation | `testing/NumberValidationTests.cs` ✅
**Status:** Completed on January 27, 2026

**Purpose:** Validate numbers with different parameters

**Key Concept:** Parameterized test cases
```
Input: 123, 456, 789
Output: Valid
```
**Run:** `dotnet run testing/NumberValidationTests.cs`

---

### 15. CreditCardNumber.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Validate credit card numbers using Luhn algorithm with regex

**Key Concept:** Pattern validation and numeric validation
```
Input: 4532 1234 5678 9010
Output: Valid
```
**Run:** `dotnet run regex/advance-problem/CreditCardNumber.cs`

---

### 16. CurrencyExtraction.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Extract currency values and amounts from text

**Key Concept:** Lookahead/lookbehind, decimal numbers
```
Input: "Items cost $19.99, €15.50, and ₹1500"
Output: [$19.99, €15.50, ₹1500]
```
**Run:** `dotnet run regex/advance-problem/CurrencyExtraction.cs`

---

### 17. RepeatingWords.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Detect and extract repeating words in text

**Key Concept:** Backreferences and word boundaries
```
Input: "The the quick brown brown fox"
Output: [the, brown]
```
**Run:** `dotnet run regex/advance-problem/RepeatingWords.cs`

---

### 18. ProgrammingLanguageDetection.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Identify programming languages from code snippets

**Key Concept:** Pattern matching for language-specific syntax
```
Input: "function hello() { console.log('hi'); }"
Output: JavaScript
```
**Run:** `dotnet run regex/advance-problem/ProgrammingLanguageDetection.cs`

---

### 19. SocialSecurityNumber.cs ✅
**Status:** Completed on January 27, 2026

**Purpose:** Validate social security numbers (XXX-XX-XXXX format)

**Key Concept:** Format validation with specific digit patterns
```
Input: 123-45-6789
Output: Valid
```
**Run:** `dotnet run regex/advance-problem/SocialSecurityNumber.cs`

---

## Reflection Operations (12 Tasks - ✅ All Completed)

Master C# Reflection API for runtime type inspection and manipulation:

### 1. DIContainer.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Implement a simple Dependency Injection container using reflection

**Key Concept:** Type registration, resolution, and automatic constructor injection
```
Register<IService, ServiceImpl>()
Resolve<IService>() → Returns ServiceImpl instance
```
**Run:** `dotnet run reflection/DIContainer.cs`

---

### 2. JsonGenerator.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Generate JSON from objects using reflection

**Key Concept:** Property traversal and serialization
```
Input: new Person { Name = "John", Age = 30 }
Output: {"Name":"John","Age":30}
```
**Run:** `dotnet run reflection/JsonGenerator.cs`

---

### 3. LoggerProxy.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Create a logging proxy using reflection

**Key Concept:** Dynamic proxy pattern and method interception
```
Proxy logs method calls before/after execution
```
**Run:** `dotnet run reflection/LoggerProxy.cs`

---

### 4. MethodTimer.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Measure method execution time using reflection

**Key Concept:** Dynamic invocation with performance tracking
```
Method execution time: 150ms
```
**Run:** `dotnet run reflection/MethodTimer.cs`

---

### 5. ObjectMapper.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Map properties between objects using reflection

**Key Concept:** Property matching and value copying
```
Map properties from SourceObject to DestinationObject
```
**Run:** `dotnet run reflection/ObjectMapper.cs`

---

### 6. AccessPrivateField.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Access private fields using reflection

**Key Concept:** BindingFlags for private member access
```
Access and modify private field value
```
**Run:** `dotnet run reflection/AccessPrivateField.cs`

---

### 7. ClassInfo.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Retrieve class metadata information

**Key Concept:** Type introspection and metadata extraction
```
List properties, methods, fields, constructors
```
**Run:** `dotnet run reflection/ClassInfo.cs`

---

### 8. DynamicObject.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Create objects dynamically at runtime

**Key Concept:** Activator.CreateInstance and dynamic instantiation
```
Create instance without compile-time type knowledge
```
**Run:** `dotnet run reflection/DynamicObject.cs`

---

### 9. InvokePrivateMethod.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Invoke private methods using reflection

**Key Concept:** MethodInfo.Invoke with BindingFlags
```
Call private method and retrieve result
```
**Run:** `dotnet run reflection/InvokePrivateMethod.cs`

---

### 10. AttributeDemo.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Work with custom attributes using reflection

**Key Concept:** Attribute definition and retrieval
```
Define custom attributes and read at runtime
```
**Run:** `dotnet run reflection/AttributeDemo.cs`

---

### 11. DynamicInvoke.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Dynamically invoke methods with parameters

**Key Concept:** MethodInfo.Invoke with parameter passing
```
Invoke method with dynamic parameters
```
**Run:** `dotnet run reflection/DynamicInvoke.cs`

---

### 12. ModifyStatic.cs ✅
**Status:** Completed on January 28, 2026

**Purpose:** Modify static fields using reflection

**Key Concept:** Static member access and modification
```
Change static field value at runtime
```
**Run:** `dotnet run reflection/ModifyStatic.cs`

---

### Prerequisites

- .NET 8.0 or higher
- C# 9.0+
- Basic understanding of OOP concepts

---

## List Interface Operations (5 Tasks - ✅ All Completed)

Master list manipulation techniques with these implementations:

### 1. FindFrequencyOfElements.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Count occurrences of elements in a list using generic programming

**Key Concept:** Dictionary-based frequency counting with type safety
```
Input: ["apple", "banana", "apple", "orange", "banana", "apple"]
Output: apple → 3, banana → 2, orange → 1
```
**Run:** `dotnet run FindFrequencyOfElements.cs`

---

### 2. RemoveDuplicateElement.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Remove duplicates while preserving insertion order

**Key Concept:** HashSet for O(1) lookup, maintaining order with List
```
Input: [3, 1, 2, 2, 3, 4]
Output: [3, 1, 2, 4]
```
**Run:** `dotnet run RemoveDuplicateElement.cs`

---

### 3. ReverseListUsingArrayList.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Reverse an ArrayList in-place

**Key Concept:** Two-pointer technique for efficient reversal
```
Input: [1, 2, 3, 4, 5]
Output: [5, 4, 3, 2, 1]
```
**Run:** `dotnet run ReverseListUsingArrayList.cs`

---

### 4. ReverseListUsingLinkedList.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Reverse a LinkedList by traversing backwards

**Key Concept:** LinkedList node navigation (Previous/Next pointers)
```
Input: 1 ↔ 2 ↔ 3 ↔ 4 ↔ 5
Output: 5 ↔ 4 ↔ 3 ↔ 2 ↔ 1
```
**Run:** `dotnet run ReverseListUsingLinkedList.cs`

---

### 5. RotateElement.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Rotate list elements by k positions

**Key Concept:** Modulo operation and index manipulation
```
Input: [10, 20, 30, 40, 50], k=2
Output: [30, 40, 50, 10, 20]
```
**Run:** `dotnet run RotateElement.cs`

---

## Map Interface Operations (2 Tasks - ✅ All Completed)

Explore Dictionary and key-value pair manipulations:

### 1. InvertAMap.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Swap dictionary keys and values

**Key Concept:** Handling multiple keys mapping to same value
```
Input: A→1, B→2, C→1
Output: 1→[A,C], 2→[B]
```
**Run:** `dotnet run InvertAMap.cs`

---

### 2. WordFrequencyCounter.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Analyze text and count word frequencies

**Key Concept:** String parsing and case-insensitive matching
```
Input: "Hello world! Hello everyone."
Output: hello→2, world→1, everyone→1
```
**Run:** `dotnet run WordFrequencyCounter.cs`

---

## Queue Interface Operations (2 Tasks - ✅ All Completed)

Work with FIFO data structures:

### 1. GenerateBinaryNumbers.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Generate first n binary numbers using BFS approach

**Key Concept:** Queue-based level-order generation
```
Input: n=5
Output: 1 10 11 100 101
```
**Run:** `dotnet run GenerateBinaryNumbers.cs`

---

### 2. ReverseQueue.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Reverse a queue using auxiliary stack

**Key Concept:** LIFO/FIFO conversion
```
Input Queue: [1→2→3→4]
Output Queue: [4→3→2→1]
```
**Run:** `dotnet run ReverseQueue.cs`

---

## Set Interface Operations (4 Tasks - ✅ All Completed)

Learn HashSet operations and set theory:

### 1. CheckEqualSet.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Check if two sets are equal

**Key Concept:** SetEquals() method for equality check
```
Set1: {1, 2, 3}
Set2: {3, 2, 1}
Result: true (order doesn't matter)
```
**Run:** `dotnet run CheckEqualSet.cs`

---

### 2. FindSubset.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Determine if one set is a subset of another

**Key Concept:** IsSubsetOf() method
```
Subset: {2, 3}
Superset: {1, 2, 3, 4}
Result: true
```
**Run:** `dotnet run FindSubset.cs`

---

### 3. SymmetricDifference.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Find elements unique to each set

**Key Concept:** SymmetricExceptWith() operation
```
Set1: {1, 2, 3}
Set2: {3, 4, 5}
Result: {1, 2, 4, 5}
```
**Run:** `dotnet run SymmetricDifference.cs`

---

### 4. UnionIntersectionOfSet.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Perform union and intersection operations

**Key Concept:** UnionWith() and IntersectWith() methods
```
Set1: {1, 2, 3}, Set2: {3, 4, 5}
Union: {1, 2, 3, 4, 5}
Intersection: {3}
```
**Run:** `dotnet run UnionIntersectionOfSet.cs`

---

## Real-World System Problems (2 Tasks - ✅ All Completed)

Apply collections to practical scenarios:

### 1. ShoppingCart.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Implement a functional shopping cart system

**Features:**
- Track product prices
- Maintain insertion order
- Sort items by price
- Calculate total amount

**Data Structures Used:**
- `Dictionary<string, double>` for prices
- `OrderedDictionary` for insertion order
- `SortedDictionary` for sorted display

**Run:** `dotnet run ShoppingCart.cs`

**Sample Output:**
```
Items in Cart (Order Added):
Laptop : ₹55000
Mouse : ₹800
Keyboard : ₹1500
Monitor : ₹12000

Items Sorted by Price:
Mouse : ₹800
Keyboard : ₹1500
Monitor : ₹12000
Laptop : ₹55000

Total Amount: ₹69300
```

---

### 2. VotingSystem.cs ✅
**Status:** Completed on January 21, 2026

**Purpose:** Build a voting system with tracking and results

**Features:**
- Count votes per candidate
- Track vote casting order
- Display sorted results

**Data Structures Used:**
- `Dictionary<string, int>` for vote counts
- `OrderedDictionary` for insertion order
- `SortedDictionary` for sorted results

**Run:** `dotnet run VotingSystem.cs`

**Sample Output:**
```
Vote Order:
Vote 1 → Alice
Vote 2 → Bob
Vote 3 → Alice
Vote 4 → Charlie
Vote 5 → Bob

Sorted Results:
Alice : 2
Bob : 2
Charlie : 1
```

---

## How to Run

### Run Individual Programs
```bash
# Navigate to the folder
cd collection-csharp-practice/gcr-code-base/list-interface

# Run a specific program
dotnet run FindFrequencyOfElements.cs
```

### Run All Programs in a Category
```bash
# List interface
cd collection-csharp-practice/gcr-code-base/list-interface
foreach ($file in Get-ChildItem *.cs) { dotnet run $file.Name }
```

### Run Regex Programs
```bash
# Validation (basic-regex-problems)
cd collection-csharp-practice/gcr-code-base/regex/basic-regex-problems
foreach ($file in Get-ChildItem *.cs) { dotnet run $file.Name }

# Extraction (extraction-problems)
cd ../extraction-problems
foreach ($file in Get-ChildItem *.cs) { dotnet run $file.Name }

# Replace/Modify (replace-modify-string)
cd ../replace-modify-string
foreach ($file in Get-ChildItem *.cs) { dotnet run $file.Name }

# Advanced (advance-problem)
cd ../advance-problem
dotnet run ValidateanIPAddress.cs
```

---

## Learning Outcomes

By working through these implementations, you will understand:

✓ **List Operations:**
- Generic programming with constraints
- ArrayList vs LinkedList trade-offs
- Two-pointer techniques
- Rotation algorithms

✓ **Dictionary/Map Operations:**
- Key-value pair management
- Inverting mappings
- Multi-value maps
- Text processing

✓ **Queue Operations:**
- FIFO data structures
- BFS algorithms
- Auxiliary data structures
- Queue-Stack conversions

✓ **Set Operations:**
- Mathematical set operations
- Union, intersection, symmetric difference
- Subset and equality checks
- HashSet performance

✓ **Real-World Design:**
- Entity mapping and relationships
- Order preservation strategies
- State management patterns
- System design considerations

✓ **Reflection Operations:**
- Runtime type inspection and metadata
- Dynamic object creation and instantiation
- Private member access (fields and methods)
- Attribute-based programming
- Dependency injection patterns
- Dynamic proxy and interception
- Custom serialization techniques
- Performance monitoring with reflection

---

## Project Structure
```
collection-csharp-practice/
└── gcr-code-base/
    ├── list-interface/
    │   ├── FindFrequencyOfElements.cs ✅
    │   ├── RemoveDuplicateElement.cs ✅
    │   ├── ReverseListUsingArrayList.cs ✅
    │   ├── ReverseListUsingLinkedList.cs ✅
    │   └── RotateElement.cs ✅
    ├── map-interface/
    │   ├─flection/
    │   ├── DIContainer.cs ✅
    │   ├── JsonGenerator.cs ✅
    │   ├── LoggerProxy.cs ✅
    │   ├── MethodTimer.cs ✅
    │   ├── ObjectMapper.cs ✅
    │   ├── AccessPrivateField.cs ✅
    │   ├── ClassInfo.cs ✅
    │   ├── DynamicObject.cs ✅
    │   ├── InvokePrivateMethod.cs ✅
    │   ├── AttributeDemo.cs ✅
    │   ├── DynamicInvoke.cs ✅
    │   └── ModifyStatic.cs ✅
    ├── re─ InvertAMap.cs ✅
    │   └── WordFrequencyCounter.cs ✅
    ├── queue-interface/
    │   ├── GenerateBinaryNumbers.cs ✅
    │   └── ReverseQueue.cs ✅
    ├── set-interface/
    │   ├── CheckEqualSet.cs ✅
    │   ├── FindSubset.cs ✅
    │   ├── SymmetricDifference.cs ✅
    │   └── UnionIntersectionOfSet.cs ✅
    ├── regex/
    │   ├── advance-problem/
    │   │   ├── ValidateanIPAddress.cs ✅
    │   │   ├── CreditCardNumber.cs ✅
    │   │   ├── CurrencyExtraction.cs ✅
    │   │   ├── RepeatingWords.cs ✅
    │   │   ├── ProgrammingLanguageDetection.cs ✅
    │   │   └── SocialSecurityNumber.cs ✅
    │   ├── basic-regex-problems/
    │   │   ├── ValidHexColorCode.cs ✅
    │   │   ├── ValidNumberPlate.cs ✅
    │   │   └── ValidUsername.cs ✅
    │   ├── extraction-problems/
    │   │   ├── CapitalizedWordsfromaSentence.cs ✅
    │   │   ├── ExtractAllEmailAddressesfromaText.cs ✅
    │   │   ├── ExtractDates.cs ✅
    │   │   └── ExtractWebpages.cs ✅
    │   └── replace-modify-string/
    │       ├── CensorBadWords.cs ✅
    │       └── MultipleSpacesToSingleSpace.cs ✅
    └── real-world-system-problem/
        ├── shopping-cart/
        │   └── ShoppingCart.cs ✅
        └── voting-system.cs/
    flection Operations | 12 | 12 | 100% ✅ |
| Regex Operations | 15 | 15 | 100% ✅ |
| Real-World Problems | 2 | 2 | 100% ✅ |
| **TOTAL** | **42** | **42
---

## 📊 Completion Summary

| CaLatest Update:** January 28, 2026
- **Assignment Status:** ✅ ALL TASKS COMPLETED
- **All implementations tested and verified:** ✅
- **Documentation updated:** ✅
- **Recent Topics:** Reflection API, Dependency Injection, Dynamic Programming% ✅ |
| Queue Operations | 2 | 2 | 100% ✅ |
| Set Operations | 4 | 4 | 100% ✅ |
| Regex Operations | 15 | 15 | 100% ✅ |
| Real-World Problems | 2 | 2 | 100% ✅ |
| **TOTAL** | **30** | **30** | **100% ✅** |

---

## 📝 Notes

- **Completion Date:** January 28, 2026
- **Assignment Status:** ✅ ALL TASKS COMPLETED
- **All implementations tested and verified:** ✅
- **Documentation updated:** ✅

---

## 🎉 Achievement Unlocked!

You have successfully completed:
- ✅ 15 Collection Framework implementations
- ✅ 19 Regex pattern operations
- ✅ 12 Reflection API operations
- ✅ 8 Custom attribute implementations
- ✅ 2 Real-world banking system implementations

**Total: 56+ Implementations | 100% Completion Rate**

---

## Next Steps

- [ ] Explore performance improvements using LINQ
- [ ] Add concurrent collections for multi-threading
- [ ] Implement advanced caching strategies
- [ ] Build microservices architecture
- [ ] Explore async/await patterns
- [ ] Implement design patterns (Factory, Observer, Strategy)

---

## 📚 Resources Used

- .NET 8.0+ Documentation
- C# Language Features
- NUnit Testing Framework
- Reflection API
- Regular Expressions (Regex)

---

**Last Updated:** January 28, 2026 | **Status:** ✅ ALL COMPLETE | **Grade:** A+ 🏆