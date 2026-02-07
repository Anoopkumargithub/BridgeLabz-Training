CREATE DATABASE TechVilleSmartCityManagementSystem;
USE TechVilleSmartCityManagementSystem;

/*
Module 1: Citizen Registration Portal 
Topics: Basic Elements of Programming - Variables, Literals, Primitive Data Types, Basic I/O, Operators 
Story Scenario: TechVille needs a basic citizen registration system. Citizens need to register with their personal details, and the system should calculate their eligibility for various city services based on age, income, and residency status. 
Tasks: 
● Accept citizen details (name, age, income, residency years) 
● Calculate service eligibility scores using arithmetic operators 
● Display formatted citizen information 
● Perform basic validations using comparison operators 
Learning Outcomes: Understanding variables, data types, input/output, and basic operators 
*/

/* ==============================
        Citizen Details
==============================*/

CREATE TABLE CitizenDetails 
(
    CitizenID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Age INT CHECK(Age>=0),
    Income DECIMAL(10,2) CHECK(Income >=0) ,
    ResidencyYears INT CHECK(ResidencyYears>=0),
    ResidencyStatus AS
    CASE 
        WHEN ResidencyYears >= 5 THEN 1
        ELSE 0
    END,
    Eligibility AS
    CASE
        WHEN Age >=18
        AND Income >10000
        AND ResidencyYears >= 5
        THEN 1
        ELSE 0
    END,
)