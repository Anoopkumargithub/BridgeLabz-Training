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

## 📊 Class, Object, and Sequence Diagrams
**Folder:** `oops-csharp-practice/gcr-code-base/class-object-sequence-diagram/`

### 📋 Diagram Applications

#### 1️⃣ School Results Application
- **Class Diagram:** Defines the structure of Student, Subject, and Result classes
- **Object Diagram:** Shows instances of students with their subjects and marks
- **Sequence Diagram:** Illustrates the flow of result generation and grade calculation

#### 2️⃣ Grocery Store Bill Generation
- **Class Diagram:** Defines the structure of Product, Cart, and Bill classes
- **Object Diagram:** Shows instances of products in a shopping cart
- **Sequence Diagram:** Illustrates the flow of adding items and generating the final bill

### 📚 Key Learnings
- **UML Diagrams:**
  - Understanding Class Diagrams for system structure design
  - Object Diagrams for representing runtime instances
  - Sequence Diagrams for modeling interactions and workflow
  
- **Design Thinking:**
  - Breaking down real-world scenarios into classes and objects
  - Identifying relationships between entities
  - Mapping business logic flow through sequence diagrams

### 💡 Applications Covered
✅ **School Results System** - Student grade calculation and reporting  
✅ **Grocery Store Billing** - Shopping cart management and bill generation

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

### 🗓️ **Date: 04-01-2026**
### 🎯 Tasks of the Day
- Practiced single and multilevel inheritance with focused display routines.
- Added status-aware order flow and course pricing examples.

### 📘 What I Practiced
- Chaining constructors with `base` to reuse shared initialization.
- Method overriding for status reporting; method hiding when reusing display labels.
- Using protected members for derived-class access while keeping fields scoped.

### 🧩 Mini Systems & Files
- Multilevel course catalog: Course → OnlineCourse → PaidOnlineCourse with fee and discount display — [oops-charp-practice/gcr-code-base/csharp-inheritance/multilevel-inheritance/CourseManagement.cs](oops-charp-practice/gcr-code-base/csharp-inheritance/multilevel-inheritance/CourseManagement.cs)
- Multilevel retail orders: Order → ShippedOrder → DeliveredOrder with status via `GetOrderStatus()` and tracking/delivery info — [oops-charp-practice/gcr-code-base/csharp-inheritance/multilevel-inheritance/OnlineRetailSystem.cs](oops-charp-practice/gcr-code-base/csharp-inheritance/multilevel-inheritance/OnlineRetailSystem.cs)
- Single-inheritance library: Book → Author combining publication metadata with author bio — [oops-charp-practice/gcr-code-base/csharp-inheritance/single-inheritance/LibraryManagement.cs](oops-charp-practice/gcr-code-base/csharp-inheritance/single-inheritance/LibraryManagement.cs)
- Single-inheritance smart home: Device → Thermostat with status plus temperature setting — [oops-charp-practice/gcr-code-base/csharp-inheritance/single-inheritance/SmartHomeSystem.cs](oops-charp-practice/gcr-code-base/csharp-inheritance/single-inheritance/SmartHomeSystem.cs)

---

### 🗓️ **Date: 05-01-2026**
### 🎯 Task of the Day
Implement **Hospital Patient Management System** with billing, doctor, and patient functionalities using OOPS

**Project 7:** Hospital Patient Management System - Comprehensive medical facility management with multi-class architecture

---

## 🏥 Project 7: Hospital Patient Management System
**Folder:** [oops-charp-practice/scenario-based/hospital-patient-management-system/](oops-charp-practice/scenario-based/hospital-patient-management-system/)

### 🏗️ Core Classes & Architecture
- **Patients** - Base class for all patient types with ID and name — [Patients.cs](oops-charp-practice/scenario-based/hospital-patient-management-system/Patients.cs)
  - `InPatient` - Derived class for admitted patients with length of stay tracking
  - `OutPatient` - Derived class for visiting patients with visit date tracking
  - `IPatient` - Interface contract for patient operations

- **Doctors** - Healthcare provider class managing assigned patients — [Doctors.cs](oops-charp-practice/scenario-based/hospital-patient-management-system/Doctors.cs)
  - Maintains array of assigned patients
  - Consultation fee management
  - `IDoctor` - Interface contract for doctor operations

- **Bills** - Billing computation with hospital charges — [Bills.cs](oops-charp-practice/scenario-based/hospital-patient-management-system/Bills.cs)
  - Room charges calculation (₹1500 per day)
  - Doctor fee aggregation
  - `IPayable` - Interface contract for billing operations

- **Menu** - User interface orchestration — [Menu.cs](oops-charp-practice/scenario-based/hospital-patient-management-system/Menu.cs)
  - Menu display and option presentation
  - 5 main operations: View Patients, View Doctors, Doctor's Patients, Generate Bill, Exit

- **Utility** - Helper functions — [Utility.cs](oops-charp-practice/scenario-based/hospital-patient-management-system/Utility.cs)
  - Formatting utilities for consistent output

- **HospitalManagement** - Main entry point with workflow — [HospitalManagement.cs](oops-charp-practice/scenario-based/hospital-patient-management-system/HospitalManagement.cs)
  - Sample data initialization
  - Menu-driven control loop
  - Operation delegation based on user choice

### 🔧 Features

**Patient Management:**
- Two patient types supported: InPatient (admitted) and OutPatient (visiting)
- Patient ID and name tracking
- Polymorphic display with patient-specific details
- Admission duration tracking for InPatients
- Visit date tracking for OutPatients

**Doctor Management:**
- Doctor ID, name, and consultation fee
- Patient assignment to doctors (one-to-many relationship)
- Patient count property for doctor workload
- Display of doctor details and assigned patients

**Billing System:**
- Automatic bill generation for InPatients
- Room charge calculation: ₹1500 × number of days
- Doctor consultation fee inclusion
- Total bill amount calculation

**Menu Operations:**
1. **View Patients** - Display all patients with their details
2. **View Doctors** - List all doctors in the system
3. **View Doctor's Patients** - Select a doctor and view assigned patients
4. **Generate Bill** - Create bill for selected InPatient under selected doctor
5. **Exit** - Terminate application

### 📊 Sample Data
- **Patients:** John (5 days), Adam (8 days), Carter (8 days)
- **Doctors:** Dr. Bhide (₹1000 fee, 2 patients), Dr. Haathi (₹5000 fee, 1 patient)

### 📚 Key Learnings

**Inheritance & Polymorphism:**
- Base class `Patients` with derived `InPatient` and `OutPatient` classes
- Virtual method `DisplayAccountInfo()` overridden in derived classes
- `base` keyword to call parent constructor and methods
- Runtime polymorphism with method overriding

**Interface Design:**
- `IPatient` contract for patient operations
- `IDoctor` contract for doctor operations
- `IPayable` contract for billing operations
- Multiple interfaces for separation of concerns

**Relationships:**
- One-to-many relationship between Doctors and Patients
- Composition: Doctors contain Patients array, Bills contain Patient and Doctor references
- Type casting with `as` operator for safe conversions

**Arrays & Collections:**
- Parallel arrays for doctors and patients
- Dynamic array indexing for menu selections
- Array bounds checking for valid selections

**Menu-Driven Architecture:**
- Switch-case for operation dispatch
- Input validation with boundary checks
- Recursive menu loop for continuous operations
- Clear separation between menu (UI), business logic, and data

### 💡 OOP Principles Applied
✅ **Encapsulation** - Private fields with public properties for controlled access  
✅ **Inheritance** - InPatient and OutPatient inherit from Patients base class  
✅ **Polymorphism** - Method overriding for patient-specific display logic  
✅ **Abstraction** - Interfaces define contracts; classes implement behavior  
✅ **Composition** - Doctors manage Patients; Bills aggregate Patient and Doctor data  
✅ **Separation of Concerns** - Menu (UI), Classes (Logic), Utility (Helpers)  

### 🚀 Future Enhancements
- Persistent storage (database or file-based patient/doctor records)
- Search and filter operations (find patient by ID, list doctors by specialty)
- Appointment scheduling system
- Medical history tracking per patient
- Prescription management
- Insurance claim processing
- Emergency contact management
- Hospital departments and specializations
- Multiple payment methods and installment plans
- Comprehensive reporting and analytics

---

### 🗓️ **Date: 06-01-2026**
### 🎯 Task of the Day
Implement **Call Log Management System** with service interfaces and utility patterns using advanced OOP design.

**Project 8:** Call Log Management System - Comprehensive telecommunications logging with architecture patterns

---

## 📞 Project 8: Call Log Management System
**File:** `oops-charp-practice/scenario-based/TetecomSystem.cs`

### 📱 Features
- **Core Classes:**
  - `CallLog` - Represents a single call record with duration, timestamp, and contact info
  - `ICallLogService` - Interface defining contract for call log operations
  - `CallLogUtility` - Implementation of call log service with CRUD operations
  - `CallLogMenu` - Menu-driven interface for user interactions

- **Functionality:**
  - Record new calls with automatic timestamp generation
  - Search calls by phone number with filtering
  - Update call duration and notes
  - Delete specific call records
  - Display all call history with formatted output
  - Calculate total call duration statistics

- **Menu Operations:**
  - Add Call - Create new call log entry
  - View All Calls - Display complete call history
  - Search Calls - Find calls by phone number
  - Update Call - Modify existing call details
  - Delete Call - Remove call records
  - Exit - Graceful application termination

### 📚 Key Learnings
- **Interface Design:** Defining contracts with `ICallLogService` for extensibility
- **Service Pattern:** Separating business logic (CallLogUtility) from presentation (CallLogMenu)
- **List Operations:** Using `List<T>` for dynamic call storage with filtering and LINQ operations
- **DateTime Management:** Recording call timestamps and calculating durations
- **Menu-Driven Architecture:** Recursive menu handling with user input validation
- **Code Organization:** Clear separation between data (CallLog), service (ICallLogService/CallLogUtility), and UI (CallLogMenu)

### 💡 OOP Principles Applied
✅ **Encapsulation** - Private fields with controlled access through properties  
✅ **Abstraction** - Interface hides implementation details of call log operations  
✅ **Separation of Concerns** - UI logic isolated from business logic  
✅ **Single Responsibility** - Each class has a specific role (data, service, menu)  
✅ **Dependency Injection** - Menu depends on interface, not concrete implementation  

### 🚀 Future Enhancements
- Call history persistence (File/Database storage)
- Advanced filtering (date range, call duration filters)
- Call categorization (incoming, outgoing, missed)
- Contact list management
- Call duration statistics and analytics
- Custom exception handling for invalid operations
- Bulk operations (delete multiple calls, export to file)

---

**Project 9:** Bird Sanctuary System - Wildlife management with interface-based behavior implementation

---

## 🦅 Project 9: Bird Sanctuary System
**Folder:** `oops-charp-practice/scenario-based/bird-sanctuary-system/`

### 🐦 Features
- **Core Classes:**
  - `Bird` - Abstract base class for all bird types with name property
  - `Eagle` - Implements IFlyable for high-altitude flying behavior
  - `Sparrow` - Implements IFlyable for short-distance flying behavior
  - `Duck` - Implements ISwimmable for aquatic behavior
  - `Parrot` - Implements IFlyable with repeat talking capability

- **Interface Contracts:**
  - `IFlyable` - Defines `Fly()` method for flying birds
  - `ISwimmable` - Defines `Swim()` method for aquatic birds
  - Enables polymorphic behavior independent of inheritance hierarchy

- **Utility & Menu:**
  - `BirdUtility` - Manages bird collection with add and display operations
  - `BirdMenu` - Provides interactive menu for sanctuary operations
  - Dynamic bird type detection using `is` operator
  - Runtime polymorphism with interface method invocation

### 📚 Key Learnings
- **Interface-Based Design:** Decoupling behavior from inheritance hierarchy
- **Multiple Implementation:** Single class can implement multiple interfaces
- **Polymorphism:** Runtime type checking and method invocation via interfaces
- **Type Casting:** Safe casting using `is` operator before calling interface methods
- **Array Management:** Managing heterogeneous objects in a typed array
- **Protected Members:** Using `protected` fields in base class for derived class access
- **Separation of Concerns:** Utility handles data, Menu handles presentation

### 💡 OOP Principles Applied
✅ **Encapsulation** - Protected fields in base Bird class, private collection in BirdUtility  
✅ **Inheritance** - All birds inherit from Bird base class  
✅ **Polymorphism** - Different bird types implement same interfaces with unique behaviors  
✅ **Abstraction** - Interfaces define what birds can do, classes define how  
✅ **Interface Segregation** - IFlyable and ISwimmable focus on specific behaviors  
✅ **Open/Closed Principle** - Easy to add new bird types without modifying existing code  

### 🦆 Bird Types & Behaviors
- **Eagle** - Flies high in the sky (IFlyable)
- **Sparrow** - Flies short distances (IFlyable)
- **Duck** - Swims in water (ISwimmable)
- **Parrot** - Flies and repeats words (IFlyable)

### 🚀 Future Enhancements
- Persistence layer for sanctuary data (File/Database)
- Search and filter operations by bird type or behavior
- Bird health and feeding system
- Habitat management for different bird species
- Statistics and reporting (bird count by type, behavior distribution)
- Conservation status tracking
- Visitor interaction log

---

### 🗓️ **Date: 07-01-2026**
### 🎯 Task of the Day
Implement **Employee Wage Computation System** with interface-driven utilities and a menu workflow for wage scenarios.

**Project 10:** Employee Wage Computation System - Randomized attendance and wage calculations across daily, part-time, monthly, and capped conditions.

---

## 💼 Project 10: Employee Wage Computation System
**File:** [oops-charp-practice/scenario-based/employee-wage-computation-problem/EmployeeMain.cs](oops-charp-practice/scenario-based/employee-wage-computation-problem/EmployeeMain.cs)

### 🧱 Core Classes
- Orchestrator entrypoint with looped menu — [oops-charp-practice/scenario-based/employee-wage-computation-problem/EmployeeMenu.cs](oops-charp-practice/scenario-based/employee-wage-computation-problem/EmployeeMenu.cs)
- Interface contract for wage operations — [oops-charp-practice/scenario-based/employee-wage-computation-problem/IEmployee.cs](oops-charp-practice/scenario-based/employee-wage-computation-problem/IEmployee.cs)
- Utility implementation with business logic and randomness — [oops-charp-practice/scenario-based/employee-wage-computation-problem/EmployeeUtilityImpl.cs](oops-charp-practice/scenario-based/employee-wage-computation-problem/EmployeeUtilityImpl.cs)
- Employee model encapsulating wage constants and state — [oops-charp-practice/scenario-based/employee-wage-computation-problem/Employee.cs](oops-charp-practice/scenario-based/employee-wage-computation-problem/Employee.cs)

### 📱 Features
- Menu options: add employee, attendance check, daily wage, part-time wage, switch-based wage, monthly wage, and capped wage till hours/days limit.
- Randomized attendance/type selection drives wage paths (absent/full-time/part-time) with descriptive console output.
- Constants centralize wage rate, full/part-time hours, max working days, and max hours for consistent calculations.
- Capped wage loop aggregates total hours/days until either 100 hours or 20 days threshold, logging each day's hours and wage.

### 📚 Key Learnings
- Interface-first design to separate contract (`IEmployee`) from implementation (`EmployeeUtilityImpl`).
- Menu-to-service orchestration using a sealed menu class and upcasting to the interface for flexibility.
- Switch-case and loop control to model daily attendance variations and cumulative wage rules.
- Encapsulation of wage parameters in the model to avoid magic numbers in calculations.

---

### 🗓️ **Date: 08-01-2026**
### 🎯 Task of the Day
Implement **Smart Home Automation System** with appliance management and control features.

**Project 11:** Smart Home Automation System - Connect, manage, and control appliances through a menu-driven console hub.

---

## 🏠 Project 11: Smart Home Automation System
**Folder:** [oops-charp-practice/scenario-based/smart-home-automation-system/](oops-charp-practice/scenario-based/smart-home-automation-system/)

### 🏗️ Core Classes & Architecture
- Entry point wires the utility and menu for the smart home hub — [SmartHome.cs](oops-charp-practice/scenario-based/smart-home-automation-system/SmartHome.cs)
- Menu orchestrates add/list operations for appliances — [ApplianceMenu.cs](oops-charp-practice/scenario-based/smart-home-automation-system/ApplianceMenu.cs)
- Utility stores connected devices and triggers control hooks — [ApplianceUtility.cs](oops-charp-practice/scenario-based/smart-home-automation-system/ApplianceUtility.cs)
- Base appliance metadata captured once for all devices — [Appliance.cs](oops-charp-practice/scenario-based/smart-home-automation-system/Appliance.cs)
- Control contract with concrete implementations per device: [IControllable.cs](oops-charp-practice/scenario-based/smart-home-automation-system/IControllable.cs), [Fan.cs](oops-charp-practice/scenario-based/smart-home-automation-system/Fan.cs), [AC.cs](oops-charp-practice/scenario-based/smart-home-automation-system/AC.cs), [LightBulb.cs](oops-charp-practice/scenario-based/smart-home-automation-system/LightBulb.cs)

### 🔧 Features
- Menu options to add Fan, AC, or LightBulb devices, view connected appliances, or exit the hub.
- Fixed-capacity registry ensures appliances only connect while slots remain, with feedback when full.
- Control trigger invokes `IControllable` implementations to simulate turning devices on when listing connections.
- Console-driven workflow for quick setup and visibility into connected smart appliances.

### 📚 Key Learnings
- Interface-driven control flow enables polymorphic actions across appliance types.
- Composition centralizes appliance registration while keeping device behaviors encapsulated.
- Menu loops with switch-based branching simplify user-driven automation tasks.
- Capacity checks guard against over-allocation when adding new devices.

### 🚀 Future Enhancements
- Instantiate specific device classes (Fan/AC/LightBulb) directly from the menu to use their control behaviors for every connection.
- Add granular controls (on/off, speed, brightness, temperature) and per-device status tracking.
- Persist connected devices and states between sessions for a continuous smart home experience.

---

### 🗓️ **Date: 09-01-2026**
### 🎯 Task of the Day
Implement **Fitness Tracker System** with user management and exercise tracking features for comprehensive fitness monitoring.

**Project 12:** Fitness Tracker System - Complete user profile management and workout logging with statistics and goal tracking.

---

## 💪 Project 12: Fitness Tracker System
**Folder:** [oops-charp-practice/scenario-based/fitness-tracker/](oops-charp-practice/scenario-based/fitness-tracker/)

### 🏗️ Core Classes & Architecture
- Entry point orchestrates the fitness application workflow — [FitnessMain.cs](oops-charp-practice/scenario-based/fitness-tracker/FitnessMain.cs)
- User interface with menu options for fitness operations — [FitnessMenu.cs](oops-charp-practice/scenario-based/fitness-tracker/FitnessMenu.cs)
- Business logic implementation for fitness tracking — [FitnessUtilityImpl.cs](oops-charp-practice/scenario-based/fitness-tracker/FitnessUtilityImpl.cs)
- Interface contract for trackable fitness operations — [ITrackable.cs](oops-charp-practice/scenario-based/fitness-tracker/ITrackable.cs)
- User profile data model with personal and fitness metrics — [UserProfile.cs](oops-charp-practice/scenario-based/fitness-tracker/UserProfile.cs)
- Workout data model for exercise logging — [WorkOut.cs](oops-charp-practice/scenario-based/fitness-tracker/WorkOut.cs)

### 🔧 Features

**User Management:**
- Create new user profiles with personal information (name, age, gender, weight, height)
- Store user data with unique user ID generation
- Display user profile details with calculated metrics
- Update user weight and fitness goals
- BMI calculation based on height and weight

**Workout Tracking:**
- Log exercises with workout type, duration, calories burned, and date
- Support multiple exercise types (Running, Cycling, Swimming, Gym, Yoga, etc.)
- Track workout history per user
- Calculate total workout duration and calories burned

**Statistics & Analysis:**
- View user-specific workout history
- Calculate total workouts completed
- Aggregate calories burned across workouts
- Track workout frequency and consistency
- Workout performance metrics per exercise type

**Menu Operations:**
1. **Create User Profile** - Add new user to the fitness system
2. **Add Workout** - Log exercise session for a user
3. **View User Profile** - Display user details and fitness metrics
4. **View Workout History** - Show all workouts for selected user
5. **Calculate Fitness Stats** - Display comprehensive fitness statistics
6. **Exit** - Graceful application termination

### 📚 Key Learnings

**Interface Design:**
- `ITrackable` interface defines contract for fitness operations (AddUser, AddWorkout, GetUserStats)
- Separates interface definition from implementation for flexibility

**Data Models:**
- `UserProfile` encapsulates personal and fitness information
- `WorkOut` represents individual exercise sessions
- Proper encapsulation with private fields and public properties

**Utility Pattern:**
- `FitnessUtilityImpl` implements ITrackable with core business logic
- Uses List<T> for dynamic user and workout storage
- Filtering and aggregation operations on collections

**Menu-Driven Architecture:**
- `FitnessMenu` handles user interaction and input validation
- Recursive menu pattern for continuous operations
- Clear delegation from menu to utility

**Collection Management:**
- Using List<UserProfile> for flexible user storage
- Nested List<WorkOut> within UserProfile for workout history
- LINQ-style filtering for finding users and calculating statistics

**Calculations & Metrics:**
- BMI calculation: weight (kg) / (height (m))²
- Calorie tracking and aggregation
- Workout duration summation
- Fitness progress monitoring

### 💡 OOP Principles Applied
✅ **Encapsulation** - Private fields with public properties for controlled access  
✅ **Abstraction** - ITrackable interface hides implementation details  
✅ **Single Responsibility** - Separate classes for user, workout, and menu concerns  
✅ **Dependency Injection** - Menu depends on ITrackable interface, not concrete implementation  
✅ **Composition** - UserProfile contains collection of WorkOut objects  
✅ **Separation of Concerns** - UI (FitnessMenu), Logic (FitnessUtilityImpl), Data (Models)  

### 🚀 Future Enhancements
- Goal setting and progress tracking towards fitness objectives
- Nutrition logging and dietary tracking
- Integration with wearable devices for automatic tracking
- Social features (challenges, friend connections, leaderboards)
- Advanced analytics and trend analysis with charts
- Personalized workout recommendations based on goals
- Integration with calendar for scheduled workouts
- Export workout history to reports (PDF/Excel)
- Push notifications for workout reminders
- Persistent storage (Database integration)
- Mobile app version for on-the-go tracking
- AI-powered fitness coach recommendations

---

### 🗓️ **Date: 14-01-2026**
### 🎯 Task of the Day
Started **Address Book** project and completed the first task: create contacts with full details.

**Project 13:** Address Book System - Add contacts with essential identity and communication fields.

---

## 📖 Welcome to Address Book Application

```
╔════════════════════════════════════════════════════════════════╗
║                  WELCOME TO ADDRESS BOOK                       ║
║         A Comprehensive Contact Management System               ║
╚════════════════════════════════════════════════════════════════╝
```

### 📋 Project Overview
The Address Book system is a menu-driven console application designed to manage personal and professional contacts efficiently. It demonstrates core OOP principles including encapsulation, abstraction, and interface-driven design patterns.

### ✅ Completed Tasks & Features

#### **Task 1: Create Contacts with Full Details** ✅ **COMPLETED**
- **Objective:** Ability to create a Contact in Address Book with comprehensive information
- **Fields Captured:** First Name, Last Name, Address, City, State, ZIP Code, Phone Number, Email
- **Implementation:** ContactDetails model with parameterized constructor
- **Status:** ✓ Fully functional contact creation with data validation

#### **Task 2: Add New Contact to Address Book** ✅ **COMPLETED**
- **Objective:** Ability to add a new Contact to the Address Book
- **Features:** 
  - User-driven input workflow for all contact fields
  - Automatic contact creation and storage in List<ContactDetails>
  - Confirmation message with formatted contact display
  - Sequential field prompting for ease of use
- **Status:** ✓ Fully functional single contact addition

#### **Task 3: Edit Existing Contact** ✅ **COMPLETED**
- **Objective:** Ability to edit existing contact person using their first name
- **Features:**
  - Search-based contact lookup by first name
  - Field selection menu (1-8 fields to update)
  - Individual field modification without affecting others
  - Updated contact display for confirmation
  - Error handling for non-existent contacts
- **Status:** ✓ Fully functional contact editing with validation

#### **Task 4: Delete Contact by Name** ✅ **COMPLETED**
- **Objective:** Ability to delete a person from Address Book using person's first name
- **Features:**
  - Search-based contact location by first name
  - Pre-deletion contact display for verification
  - Explicit confirmation prompt ("yes/no") to prevent accidental deletion
  - Safe removal using List<T>.Remove() method
  - Success/cancellation feedback messages
  - Error handling for non-existent contacts
- **Status:** ✓ Fully functional safe contact deletion

#### **Task 5: Add Multiple Persons to Address Book** ✅ **COMPLETED**
- **Objective:** Ability to add multiple persons to Address Book in single session
- **Features:**
  - Continuous entry loop allowing sequential contact additions
  - "Add another contact? (yes/no)" prompt after each entry
  - Capacity management with configurable maximum limit (default 100 contacts)
  - Capacity status display showing current/max contacts
  - Full address book notification when capacity reached
  - Session summary with total contacts added
  - Dynamic List<ContactDetails> growth management
- **Status:** ✓ Fully functional bulk contact addition with capacity control

### 📊 Current Address Book Capabilities

**Core Operations (CRUD):**
| Operation | Status | Feature |
|-----------|--------|---------|
| **Create** | ✅ | Add single or multiple contacts |
| **Read** | ✅ | Display specific contact by name |
| **Update** | ✅ | Edit individual contact fields |
| **Delete** | ✅ | Remove contacts with confirmation |

**Menu Options:**
1. ✅ **Add Contact(s)** - Create one or multiple contacts with capacity check
2. ✅ **Edit Contact** - Modify existing contact information
3. ✅ **Delete Contact** - Remove contact with confirmation
4. ✅ **Show Contact** - Display specific contact details
5. ⏳ **View All Contacts** - List all contacts (In Progress)
6. ✅ **Exit** - Close application gracefully

### 🏗️ Architecture Overview

**Core Classes:**
- `ContactDetails` - Data model encapsulating all contact information
- `ContactImpl` - Business logic for contact operations (Add, Edit, Delete, Search)
- `IContact` - Interface contract defining contact operations
- `AddressBook` - Main UI entry point coordinating menu-driven workflow
- `AddressBookOperations` - Orchestration layer managing user interactions

**Data Storage:**
- `ContactDetails[] contacts` - Fixed-size array for storing all contacts
- Maximum capacity: 100 contacts (fixed array size: `new ContactDetails[100]`)
- Manual capacity checking before each addition using array index
- Contact count tracking with `int contactCount` variable
- Direct array index manipulation for add/edit/delete operations

**User Interaction:**
- Menu-driven console application
- Input validation for all user entries
- Clear feedback messages for all operations
- Graceful error handling for edge cases

### 🎓 OOP Principles Demonstrated

✅ **Encapsulation** - Private contact fields with public properties  
✅ **Abstraction** - IContact interface hides implementation complexity  
✅ **Single Responsibility** - Each class has focused, well-defined role  
✅ **Separation of Concerns** - UI (AddressBook), Logic (ContactImpl), Models (ContactDetails)  
✅ **Composition** - AddressBook composes ContactImpl for functionality  
✅ **Defensive Programming** - Confirmation dialogs and capacity checks  

### 📈 Development Progress

| Phase | Task | Completion | Implementation |
|-------|------|-----------|----------------|
| Phase 1 | Create Contact Model | ✅ 100% | ContactDetails with 8 fields |
| Phase 2 | Add Contact Operation | ✅ 100% | Single entry workflow |
| Phase 3 | Edit Contact Operation | ✅ 100% | Field-by-field modification |
| Phase 4 | Delete Contact Operation | ✅ 100% | Safe deletion with confirmation |
| Phase 5 | Bulk Add Contacts | ✅ 100% | Multiple entry with capacity management |


### 🚀 Next Enhancements (Roadmap)

**Immediate (Phase 6+):**
- [ ] View All Contacts - Display complete contact list
- [ ] Search by Phone/Email - Advanced search capabilities
- [ ] Contact Validation - Email format and phone number validation
- [ ] Duplicate Detection - Prevent adding same contact twice

**Short-term:**
- [ ] Persistent Storage - File/Database integration (JSON, CSV, or SQL)
- [ ] Contact Categories - Organize contacts by type (Personal, Business, Family)
- [ ] Advanced Search - Filter by city, state, or other criteria
- [ ] Batch Operations - Edit/delete multiple contacts at once

---

## 📖 Project 13: Address Book System

### 📌 Overview
The Address Book is a menu-driven console application for managing contacts. Currently supports creating, editing, deleting, and bulk adding contacts with array-based storage.

### ✅ Completed Tasks (Tasks 1-5)

| Task | Feature | Status |
|------|---------|--------|
| Task 1 | Create Contact with 8 fields (First Name, Last Name, Address, City, State, ZIP, Phone, Email) | ✅ |
| Task 2 | Add New Contact to Address Book | ✅ |
| Task 3 | Edit Existing Contact by Name | ✅ |
| Task 4 | Delete Contact by Name with Confirmation | ✅ |
| Task 5 | Add Multiple Contacts in Single Session | ✅ |

### 🎯 Task 6 (Upcoming)
- **Objective:** Refactor to add multiple Address Books to the System
- **Details:** Each Address Book has a unique Name
- **Status:** ⏳ Not Started

---

## 🛠️ Technologies & Tools

#### 🎯 Completion Details
- **User Input Flow:** Console prompts for all 8 contact fields (First Name, Last Name, Address, City, State, ZIP, Phone, Email)
- **Contact Creation:** Creates ContactDetails object with user-provided values
- **Display & Confirmation:** Automatically displays formatted contact info and confirms addition success
- **Array Storage:** Stores contacts in fixed array with index-based access

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