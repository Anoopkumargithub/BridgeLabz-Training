# 🚀 BridgeLabz Training Progress

Welcome to my **BridgeLabz Training Repository** 👋  
This space documents my **daily learning progress**, hands-on coding practice, and continuous skill development throughout the training program.

🎯 **Training Goal:**  
To strengthen problem-solving abilities, build a strong programming foundation, and gain confidence in modern development practices.

---

## 📅 Daily Training Log

---

### 🗓️ **Date: 29-12-2025**
### 🎯 Task of the Day
- Learn **Object-Oriented Programming (OOP) fundamentals** in C#
- Understand the four pillars of OOP: Encapsulation, Inheritance, Polymorphism, and Abstraction
- Set up new OOP practice workspace structure
- Prepare for hands-on OOP implementation

### 📘 What I Learned
- **Object-Oriented Programming Fundamentals:**
  - **Classes and Objects:**
    - Classes as blueprints for creating objects
    - Objects as instances of classes with state (fields) and behavior (methods)
    - Difference between class definition and object instantiation
  - **The Four Pillars of OOP:**
    1. **Encapsulation:**
       - Bundling data (fields) and methods that operate on that data within a single unit (class)
       - Data hiding using access modifiers (private, public, protected, internal)
       - Using properties (getters/setters) to control access to private fields
       - Benefits: Data protection, maintainability, flexibility
    2. **Inheritance:**
       - Creating new classes (derived/child) from existing classes (base/parent)
       - Code reusability through inheritance hierarchy
       - `base` keyword to access parent class members
       - Method overriding with `virtual` and `override` keywords
       - Benefits: Code reuse, hierarchical classification, extensibility
    3. **Polymorphism:**
       - "Many forms" - ability of objects to take multiple forms
       - **Compile-time polymorphism:** Method overloading, operator overloading
       - **Runtime polymorphism:** Method overriding using virtual/override
       - Interface implementation for achieving polymorphic behavior
       - Benefits: Flexibility, extensibility, code organization
    4. **Abstraction:**
       - Hiding complex implementation details and showing only essential features
       - Abstract classes with `abstract` keyword (cannot be instantiated)
       - Abstract methods (must be implemented by derived classes)
       - Interfaces for defining contracts (what a class must do, not how)
       - Benefits: Simplicity, security, code maintainability

- **Additional OOP Concepts:**
  - **Constructors:** Special methods for initializing objects
  - **Constructor overloading:** Multiple constructors with different parameters
  - **Static members:** Class-level members shared across all instances
  - **Method Overloading:** Same method name with different parameters
  - **Access Modifiers:** public, private, protected, internal, protected internal
  - **Properties:** Modern way to expose class fields with get/set accessors
  - **this keyword:** Reference to current instance of the class

### 🏗️ Project Structure Setup
Created new workspace: `oops-csharp-practice/`
```
oops-csharp-practice/
├── gcr-codebase/           # Guided coding practice problems
├── leet-code-codebase/     # LeetCode OOP solutions
└── scenario-based/          # Real-world OOP scenarios
```

### 📚 Key Takeaways
- OOP helps organize code into logical, reusable components
- Encapsulation protects data integrity through controlled access
- Inheritance promotes code reuse and establishes relationships between classes
- Polymorphism enables flexible and extensible code design
- Abstraction simplifies complex systems by hiding unnecessary details
- C# is a fully object-oriented language with robust OOP support

### ⏭️ What's Next
- Implement classes with proper encapsulation (private fields + public properties)
- Practice inheritance with real-world examples (Animal → Dog/Cat, Vehicle → Car/Bike)
- Create abstract classes and interfaces
- Build polymorphic solutions using method overriding
- Solve OOP-based coding challenges
- Apply OOP principles to scenario-based problems

---

### 🗓️ **Date: 31-12-2025**
### 🎯 Tasks of the Day
Completed **3 scenario-based OOP projects** demonstrating menu-driven applications and system design:

**Project 1:** Mathematical Operations - Algorithm implementation  
**Project 2:** Bank System - Role-based authentication and account management  
**Project 3:** Invoice Generator - Text-based invoice parsing and total calculation

---

## 📋 Project 1: Mathematical Operations
**File:** `oops-csharp-practice/scenario-based/MathematicalOperations.cs`

### 🔢 Features
- **Interactive Menu:** Recursive menu system for continuous operation selection
- **Algorithms Implemented:**
  - `Factorial()` - Calculates n! using iteration
  - `PrimeNumber()` - Checks if number is prime (optimized √n approach)
  - `GCD()` - Finds greatest common divisor of two numbers
  - `Fibonacci()` - Generates nth Fibonacci number

### 📚 Key Learnings
- Static utility classes for grouping related operations
- Menu-driven application design patterns
- Iterative vs recursive approaches for algorithms
- Data type selection (using `long` for large values)
- Code organization with separation of concerns

---

## 🏦 Project 2: Bank System
**File:** `oops-csharp-practice/scenario-based/BankSystem.cs`

### 🔐 Features
- **Authentication System:**
  - Client login (Account No. + PIN verification)
  - Manager login (Manager ID + Password verification)
  - Recursive retry mechanism for failed authentication

- **Class Architecture:**
  - `BankSystem` - Entry point and role orchestrator
  - `Bank` - Core data, user database (10 accounts), transaction limits (₹1,00,000 max, ₹2,000 min balance, 5 tx/day)
  - `User` & `Manager` - Role representations

- **Data Management:**
  - 2D array for user credentials and balance
  - Readonly fields for security-critical constants
  - Role-based menu presentation

### 📚 Key Learnings
- Role-based access control design
- 2D arrays for multi-attribute data management
- Encapsulation with readonly modifiers
- Abstraction of complex authentication logic
- Clear separation of concerns across classes

### 💡 Common OOP Principles Applied in Both Projects
✅ **Encapsulation** - Data protection with access modifiers  
✅ **Abstraction** - Hiding implementation details behind methods  
✅ **Separation of Concerns** - Each class has specific responsibility  
✅ **Code Reusability** - Static methods for shared functionality  
✅ **Maintainability** - Clear structure and logical organization

---

## 🧾 Project 3: Invoice Generator
**File:** `oops-charp-practice/scenario-based/InvoiceGenerator.cs`

### 🧮 Features
- **Menu-Driven Flow:** Recursive menu to generate invoices or exit.
- **Invoice Parsing:** Accepts comma-separated task entries in the format "Task - amount INR" and splits each entry by `-` and spaces.
- **Total Calculation:** Extracts numeric amounts, sums all tasks, and prints the total invoice value.
- **Summary Output:** Echoes trimmed task lines back to the user before showing the aggregate amount.

### 📚 Key Learnings
- String splitting and trimming to normalize free-form invoice input.
- Recursive menu handling for simple console loops.
- Separating parsing logic (`ParseInvoice`) from computation (`GetTotalAmount`) for clarity.

### 🚀 Future Enhancements
- Complete transaction operations (Deposit, Withdrawal, Balance Check)
- Input validation and error handling
- Custom exception handling
- Persistent data storage (File/Database)
- Enhanced security (password hashing)
- Account statement and transaction history

---

### 🗓️ **Date: 01-01-2026**
### 🎯 Task of the Day
Completed **Cafeteria Ordering System** - A menu-driven application for food ordering and payment processing.

**Project 4:** Cafeteria System - Interactive ordering with real-time billing

---

## 🍔 Project 4: Cafeteria System
**File:** `oops-csharp-practice/scenario-based/CafeteriaSystem.cs`

### 🍽️ Features
- **Menu Display:** Shows 10 food items with indexed pricing
  - Items include: Veg Sandwich, Cheese Burger, Pasta, Fried Rice, Paneer Roll, Cold Coffee, Tea, Samosa, Pizza Slice, Ice Cream
  - Price range: ₹15 - ₹120

- **Order Processing:**
  - Interactive item selection by index
  - Multiple item ordering in single transaction
  - Real-time running total display after each item addition
  - Input validation with recursive retry for invalid indices

- **Payment System:**
  - Total bill calculation and display
  - Payment acceptance with validation
  - Change calculation (return amount)
  - Recursive payment retry for insufficient amounts

- **Class Architecture:**
  - `CafeteriaSystem` - Main orchestrator with static methods for workflow
  - `Cafeteria` - Data holder with parallel arrays for MenuItems and Prices

### 📚 Key Learnings
- **Arrays for Data Management:**
  - Parallel arrays (MenuItems[], Prices[]) for related data
  - Array indexing for menu item lookup
  - Array length validation for boundary checking

- **Recursive Validation:**
  - `GetItemByIndex()` - Recursive retry for invalid menu selections
  - `MakePayment()` - Recursive retry for insufficient payment amounts

- **User Experience Design:**
  - Clear menu presentation with item numbering
  - Running total feedback during order placement
  - Friendly confirmation messages

- **Code Organization:**
  - Static utility methods for stateless operations
  - Separation of display, business logic, and data
  - Modular functions (DisplayMenu, TakeOrder, MakePayment)

### 💡 OOP Principles Applied
✅ **Encapsulation** - Data grouped in Cafeteria class  
✅ **Abstraction** - Complex ordering flow hidden behind simple methods  
✅ **Separation of Concerns** - Display, logic, and data separated  
✅ **Code Reusability** - Modular static methods for different operations

### 🚀 Future Enhancements
- Item quantity support (order multiples of same item)
- Order summary/receipt generation
- Discount and offer system
- Item availability management
- Exception handling for non-numeric inputs
- Order history tracking
- Multiple payment methods support

---

## 🛠️ Technologies & Tools

### 💻 Languages
- C#

### ⚙️ Framework / Platform
- .NET

### 🔧 Tools & IDEs
- Git & GitHub
- Command Line Interface
- Visual Studio Code
- Visual Studio 2022

---

## 🌱 Learning Objectives

By the end of this training, I aim to be proficient in:
- 🧠 Problem-solving and logical thinking
- 🧹 Writing clean, readable, and maintainable code
- 🏗️ Object-Oriented Programming principles and design patterns
- 🔄 Working across multiple programming languages
- 🏗️ Understanding modern development platforms like **.NET**

---

📌 *This README will be continuously updated to reflect ongoing learning and progress during the BridgeLabz Training Program.*