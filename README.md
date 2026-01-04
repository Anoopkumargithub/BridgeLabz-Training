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

### 🗓️ **Date: 02-01-2026**
### 🎯 Task of the Day
Completed **Class and Object fundamentals** - Three basic OOP programs demonstrating encapsulation and class design.

**Practice 1:** Area of Circle - Calculate area and circumference  
**Practice 2:** Employee Class - Store and display employee information  
**Practice 3:** Handle Book Details - Manage book information

✅ Added two scenario-based programs:
- **Project 5:** Bus Route Distance Tracker - Track cumulative distance stop by stop until passenger exit
- **Project 6:** Festival Lucky Draw - Validate lucky numbers and award gifts on 3 & 5 multiples

Completed **constructor, access-modifier, and instance practice** with six mini-programs covering object initialization patterns and display routines.

---

## 📝 Practice 1: Area of Circle
**File:** `oops-charp-practice/gcr-code-base/csharp-class-object/AreaOfCircle.cs`

### 🔢 Features
- **Class Design:**
  - Private field `radius` for encapsulation
  - Constructor to initialize radius
  - Private methods `CalculateArea()` and `CalculateCircumference()`
  - Public `Display()` method for output

- **Functionality:**
  - Calculates area using formula: π × r²
  - Calculates circumference using formula: 2 × π × r
  - User input for radius value
  - Formatted output display

### 📚 Key Learnings
- **Encapsulation:** Private fields with controlled access
- **Constructor usage:** Initializing object state
- **Math class:** Using `Math.PI` and `Math.Pow()` for calculations
- **String interpolation:** Formatted output with `$` syntax
- **Public vs Private:** Display is public, calculations are private

---

## 👤 Practice 2: Employee Class
**File:** `oops-charp-practice/gcr-code-base/csharp-class-object/EmployeeClass.cs`

### 💼 Features
- **Class Design:**
  - Three private fields: `name`, `id`, `salary`
  - Parameterized constructor for initialization
  - Public `DisplayDetails()` method

- **Functionality:**
  - Stores employee information (Name, ID, Salary)
  - Displays formatted employee details
  - Demonstrates object creation and method invocation

### 📚 Key Learnings
- **Multiple field management:** Handling different data types (string, int, double)
- **Constructor parameters:** Passing multiple values during object creation
- **this keyword:** Distinguishing between parameters and fields
- **Object instantiation:** Creating objects with `new` keyword
- **Method invocation:** Calling instance methods on objects

---

## 📚 Practice 3: Handle Book Details
**File:** `oops-charp-practice/gcr-code-base/csharp-class-object/HandleBookDetails.cs`
### 📖 Features
- Three private fields: `title`, `author`, `price`
- Parameterized constructor
- Public `Display()` method with formatted output

### 🛠️ Functionality
- Stores book information (Title, Author, Price)
- Displays book details in sentence format
- Simple object-oriented book management

### 📚 Key Learnings
- Data modeling: Representing real-world entities as classes
- Consistent naming: Meaningful variable and method names
- Output formatting: Creating readable, natural language output
- Encapsulation benefits: Data protection with private fields

---

## 🏗️ Constructor & Access Practice

### 📕 Book (Constructor with fields)
- **File:** [oops-charp-practice/gcr-code-base/csharp-constructors/BookClass.cs](oops-charp-practice/gcr-code-base/csharp-constructors/BookClass.cs)
- Parameterized constructor sets title, author, price
- `Display()` prints a one-line summary of the book

### 🚗 Car Rental (Branching logic + constructor)
- **File:** [oops-charp-practice/gcr-code-base/csharp-constructors/CarRental.cs](oops-charp-practice/gcr-code-base/csharp-constructors/CarRental.cs)
- Constructor initializes customer name, model, rental days and triggers billing
- Rate selection uses model-based conditional logic; `Display()` prints bill

### ⚪ Circle (Constructor + private helpers)
- **File:** [oops-charp-practice/gcr-code-base/csharp-constructors/CircleClass.cs](oops-charp-practice/gcr-code-base/csharp-constructors/CircleClass.cs)
- Constructor stores radius; private methods compute area and circumference
- `Display()` shows both values using calculated results

### 🏨 Hotel Booking (Overloaded constructors + copy)
- **File:** [oops-charp-practice/gcr-code-base/csharp-constructors/HotelBooking.cs](oops-charp-practice/gcr-code-base/csharp-constructors/HotelBooking.cs)
- Demonstrates default, parameterized, and copy constructors
- `Display()` outputs guest name, room type, and nights for each instance

### 📚 Library (Availability check with state toggle)
- **File:** [oops-charp-practice/gcr-code-base/csharp-constructors/LibiraryClass.cs](oops-charp-practice/gcr-code-base/csharp-constructors/LibiraryClass.cs)
- Constructor sets book metadata and availability flag
- `Availability()` flips state on borrow; `Display()` summarizes book details

### 👤 Person (Copy constructor)
- **File:** [oops-charp-practice/gcr-code-base/csharp-constructors/Person.cs](oops-charp-practice/gcr-code-base/csharp-constructors/Person.cs)
- Parameterized constructor captures identity fields; copy constructor clones
- `Display()` prints name, age, and city for original and copied instances

---

## 🚌 Project 5: Bus Route Distance Tracker
**File:** oops-charp-practice/scenario-based/BusRouteDistanceTracker.cs

### 🛣️ Features
- Fixed per-stop distance accumulator with running total display
- Stop counter increments until passenger chooses to exit
- User-driven loop controlled by simple yes/no input

### 📚 Key Learnings
- While-loop control based on user choice
- Incremental state tracking for cumulative totals
- Console prompts for iterative workflows

---

## 🎁 Project 6: Festival Lucky Draw
**File:** oops-charp-practice/scenario-based/FestivalLuckyDraw.cs

### 🎟️ Features
- Validates positive integer input for lucky number entries
- Awards gift when number divisible by both 3 and 5; encourages retry otherwise
- Continuous visitor handling until operator exits the loop

### 📚 Key Learnings
- Input validation with `int.TryParse`
- Compound condition checks for business rules
- Loop-driven user interaction for repeated processing

---

## 💡 Common OOP Principles Applied Across All Practices
✅ **Encapsulation** - All data fields are private, accessed through public methods  
✅ **Constructors** - Proper initialization of object state  
✅ **this keyword** - Differentiating instance variables from parameters  
✅ **Access Modifiers** - Understanding public vs private scope  
✅ **Method Design** - Single Responsibility (each method has one purpose)  
✅ **Object Instantiation** - Creating and using objects properly

### 🎓 Technical Concepts Practiced
- Private fields for data hiding
- Parameterized constructors
- Instance methods
- String interpolation for output
- Different data types (string, int, double)
- Console input/output operations
- Namespace organization

### 🚀 Next Steps
- Add property getters/setters instead of direct field access
- Implement data validation in constructors
- Practice method overloading
- Explore static vs instance members
- Build more complex class relationships

---

### 🗓️ **Date: 03-01-2026**
### 🎯 Tasks of the Day
- Reviewed `this`, static members, and the `is` operator; noted use-cases for the sealed keyword to block inheritance when needed.
- Built small management systems with display routines for BankAccount, Employee, Patient, Book, Product, Student, and Vehicle classes.

### 📘 What I Practiced
- `this` to disambiguate constructor parameters from fields across all entity classes.
- Static fields/methods for shared context: organization names, discounts/fees, and instance counters.
- `is` operator before display calls to verify object type safety.
- Readonly identifiers for immutable IDs (account numbers, roll numbers, ISBNs, product IDs, registrations).

### 🧩 Mini Systems & Files
- Bank accounts with shared bank name, per-account balance display, and total account count — [oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/BankSystem.cs](oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/BankSystem.cs)
- Employee roster with company-wide static name and total employee tracker — [oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/EmployeeManagement.cs](oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/EmployeeManagement.cs)
- Hospital intake showing patient details and aggregate admissions — [oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/HospitalManagement.cs](oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/HospitalManagement.cs)
- Library catalog with static library name and per-book display — [oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/LibrarySystem.cs](oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/LibrarySystem.cs)
- Shopping cart applying a shared discount to products before summarizing totals — [oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/ShoppingCart.cs](oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/ShoppingCart.cs)
- University roster keeping static university name and student count — [oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/UniversityManagement.cs](oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/UniversityManagement.cs)
- Vehicle registration with a static fee applied to each record — [oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/VehicleRegistrationSystem.cs](oops-charp-practice/gcr-code-base/csharp-this-sealed-static-keyword/VehicleRegistrationSystem.cs)

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