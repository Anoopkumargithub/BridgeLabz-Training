/* ===============================
   DATABASE
================================ */
CREATE DATABASE HEALTHCARE_DB;
GO
USE HEALTHCARE_DB;
GO

/* ===============================
   PATIENTS
================================ */
CREATE TABLE Patients (
    PatientID INT IDENTITY PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    DateOfBirth DATE,
    Contact VARCHAR(20) NOT NULL UNIQUE,
    Address VARCHAR(100),
    BloodGroup VARCHAR(3),
    Email VARCHAR(50) NOT NULL UNIQUE,
    Gender VARCHAR(10),
    Is_Active BIT DEFAULT 1,
    Created_At DATETIME DEFAULT CURRENT_TIMESTAMP,
    Updated_At DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE INDEX IDX_Patients_Name ON Patients(Name);

/* ===============================
   SPECIALITIES
================================ */
CREATE TABLE Specialities (
    SpecialityID INT IDENTITY PRIMARY KEY,
    SpecialityName VARCHAR(50) NOT NULL UNIQUE,
    Created_At DATETIME DEFAULT CURRENT_TIMESTAMP,
    Updated_At DATETIME DEFAULT CURRENT_TIMESTAMP
);

/* ===============================
   DOCTORS
================================ */
CREATE TABLE Doctors (
    DoctorID INT IDENTITY PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    SpecialityID INT NOT NULL,
    Contact VARCHAR(20),
    Email VARCHAR(50) UNIQUE,
    ConsultationFee DECIMAL(10,2) NOT NULL,
    Is_Active BIT DEFAULT 1,
    Created_At DATETIME DEFAULT CURRENT_TIMESTAMP,
    Updated_At DATETIME DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT FK_Doctor_Speciality
        FOREIGN KEY (SpecialityID) REFERENCES Specialities(SpecialityID)
);

CREATE INDEX IDX_Doctors_Speciality ON Doctors(SpecialityID);

/* ===============================
   DOCTOR SCHEDULES
================================ */
CREATE TABLE DoctorSchedules (
    ScheduleID INT IDENTITY PRIMARY KEY,
    DoctorID INT NOT NULL,
    DayOfWeek VARCHAR(10) NOT NULL
        CHECK (DayOfWeek IN ('Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday')),
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    MaxPatients INT NOT NULL CHECK (MaxPatients > 0),

    CONSTRAINT FK_Schedule_Doctor
        FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID),

    CONSTRAINT CK_Schedule_Time
        CHECK (StartTime < EndTime),

    CONSTRAINT UX_Doctor_Day_Time
        UNIQUE (DoctorID, DayOfWeek, StartTime)
);

/* ===============================
   APPOINTMENTS
================================ */
CREATE TABLE Appointments (
    AppointmentID INT IDENTITY PRIMARY KEY,
    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,
    AppointmentDate DATE NOT NULL,
    AppointmentTime TIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'SCHEDULED',
    Created_At DATETIME DEFAULT CURRENT_TIMESTAMP,
    Updated_At DATETIME DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT FK_Appointment_Patient
        FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),

    CONSTRAINT FK_Appointment_Doctor
        FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID),

    CONSTRAINT CK_Appointment_Status
        CHECK (Status IN ('SCHEDULED','CANCELLED','COMPLETED','RESCHEDULED'))
);

/* Prevent double booking */
CREATE UNIQUE INDEX UX_Doctor_Appointment_Slot
ON Appointments (DoctorID, AppointmentDate, AppointmentTime)
WHERE Status = 'SCHEDULED';

CREATE INDEX IDX_Appointment_Patient ON Appointments(PatientID);
CREATE INDEX IDX_Appointment_Doctor_Date ON Appointments(DoctorID, AppointmentDate);

/* ===============================
   APPOINTMENT AUDIT
================================ */
CREATE TABLE Appointment_Audit (
    AuditID INT IDENTITY PRIMARY KEY,
    AppointmentID INT NOT NULL,
    Action VARCHAR(20)
        CHECK (Action IN ('CREATE','CANCEL','RESCHEDULE','COMPLETE')),
    ActionBy VARCHAR(50),
    ActionAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    Remarks VARCHAR(255),

    CONSTRAINT FK_Audit_Appointment
        FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID)
);

/* ===============================
   VISITS
================================ */
CREATE TABLE Visits (
    VisitID INT IDENTITY PRIMARY KEY,
    AppointmentID INT NOT NULL,
    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,
    Diagnosis VARCHAR(255),
    Notes VARCHAR(255),
    VisitDate DATETIME DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT FK_Visit_Appointment
        FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID),

    CONSTRAINT FK_Visit_Patient
        FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),

    CONSTRAINT FK_Visit_Doctor
        FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);

/* One visit per appointment */
CREATE UNIQUE INDEX UX_Visit_Appointment ON Visits(AppointmentID);
CREATE INDEX IDX_Visit_Patient ON Visits(PatientID);

/* ===============================
   PRESCRIPTIONS
================================ */
CREATE TABLE Prescriptions (
    PrescriptionID INT IDENTITY PRIMARY KEY,
    VisitID INT NOT NULL,
    Medication VARCHAR(255) NOT NULL,
    Dosage VARCHAR(50),
    Frequency VARCHAR(50),
    Duration VARCHAR(50),
    Created_At DATETIME DEFAULT CURRENT_TIMESTAMP,
    Updated_At DATETIME DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT FK_Prescription_Visit
        FOREIGN KEY (VisitID) REFERENCES Visits(VisitID)
);

/* ===============================
   BILLING
================================ */
CREATE TABLE Billing (
    BillingID INT IDENTITY PRIMARY KEY,
    AppointmentID INT NOT NULL,
    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    Created_At DATETIME DEFAULT CURRENT_TIMESTAMP,
    Updated_At DATETIME DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT FK_Billing_Appointment
        FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID),

    CONSTRAINT FK_Billing_Patient
        FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),

    CONSTRAINT FK_Billing_Doctor
        FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);

/* One bill per appointment */
CREATE UNIQUE INDEX UX_Billing_Appointment ON Billing(AppointmentID);

/* ===============================
   BILLING ITEMS
================================ */
CREATE TABLE Billing_Items (
    ItemID INT IDENTITY PRIMARY KEY,
    BillingID INT NOT NULL,
    Description VARCHAR(100),
    Amount DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_BillingItem_Billing
        FOREIGN KEY (BillingID) REFERENCES Billing(BillingID)
);

/* ===============================
   PAYMENTS
================================ */
CREATE TABLE Payments (
    PaymentID INT IDENTITY PRIMARY KEY,
    BillingID INT NOT NULL,
    PaymentDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Amount DECIMAL(10,2) NOT NULL,
    PaymentMethod VARCHAR(50),
    PaymentStatus VARCHAR(20) DEFAULT 'PENDING',
    Created_At DATETIME DEFAULT CURRENT_TIMESTAMP,
    Updated_At DATETIME DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT FK_Payment_Billing
        FOREIGN KEY (BillingID) REFERENCES Billing(BillingID),

    CONSTRAINT CK_Payment_Status
        CHECK (PaymentStatus IN ('PENDING','PAID','FAILED'))
);

CREATE INDEX IDX_Payment_Status ON Payments(PaymentStatus);

/* ===============================
   USERS & ROLES
================================ */
CREATE TABLE Users (
    UserID INT IDENTITY PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(20)
        CHECK (Role IN ('ADMIN','DOCTOR','RECEPTIONIST'))
);

/* ===============================
   SYSTEM AUDIT LOG
================================ */
CREATE TABLE Audit_Log (
    AuditID INT IDENTITY PRIMARY KEY,
    TableName VARCHAR(50),
    Operation VARCHAR(10),
    RecordID INT,
    ChangedBy VARCHAR(50),
    ChangedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);
