# BridgeLabz-Training

## Collection Framework - C# Practice

> A comprehensive guide to mastering C# Collections Framework with 15+ real-world implementations

---

## Assignment Progress Tracker

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
| 11 | Validate Credit Card Numbers | `regex/advance-problem/CreditCardNumber.cs` | ✅ Done |
| 12 | Extract Currency Values | `regex/advance-problem/CurrencyExtraction.cs` | ✅ Done |
| 13 | Detect Repeating Words | `regex/advance-problem/RepeatingWords.cs` | ✅ Done |
| 14 | Identify Programming Languages | `regex/advance-problem/ProgrammingLanguageDetection.cs` | ✅ Done |
| 15 | Validate Social Security Numbers | `regex/advance-problem/SocialSecurityNumber.cs` | ✅ Done |

**Total:** 15/15 Tasks Completed ✅

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

## 📋 Detailed Implementation Guide

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
    │   ├── InvertAMap.cs ✅
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
    │   │   └── ValidateanIPAddress.cs ✅
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
            └── VotingSystem.cs ✅
```

---

## 📊 Completion Summary

| Category | Total Tasks | Completed | Percentage |
|----------|------------|-----------|-----------|
| List Operations | 5 | 5 | 100% ✅ |
| Map Operations | 2 | 2 | 100% ✅ |
| Queue Operations | 2 | 2 | 100% ✅ |
| Set Operations | 4 | 4 | 100% ✅ |
| Regex Operations | 10 | 10 | 100% ✅ |
| Real-World Problems | 2 | 2 | 100% ✅ |
| **TOTAL** | **25** | **25** | **100% ✅** |

---

## 📝 Notes

- **Completion Date:** January 21, 2026
- **Assignment Status:** ✅ ALL TASKS COMPLETED
- **All implementations tested and verified:** ✅
- **Documentation updated:** ✅

---

## Next Steps

- [ ] Explore performance improvements using LINQ
- [ ] Add unit tests for each implementation
- [ ] Implement custom data structures
- [ ] Explore concurrent collections for multi-threading
- [ ] Build more complex real-world systems