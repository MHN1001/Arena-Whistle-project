# 🏟️ Arena Whistle – Stadium Booking Management System

A full-featured **Stadium Booking Management System** built with **C# WinForms**, **Guna UI2**, **ADO.NET**, and **SQL Server Stored Procedures**.
This project demonstrates real-world software engineering practices including clean multi-layer architecture, secure database design, role-based permissions, custom controls, and advanced T-SQL programming.

---

### 📌 Project Overview

**Arena Whistle** is a desktop application designed to efficiently manage:

* Stadiums and multiple stadium images
* Bookings, schedules, availability checks, and overlapping prevention
* Users, roles, authentication, and permissions
* Employees, referees, and departments
* Payments, pricing, fines, and card processing
* Client and administrative workflows

The application emphasizes **practical use** of OOP principles, design patterns, data structures, custom controls, and advanced database programming.

---

### 🎯 Key Features

#### 🏟 Stadium Management

* Add, edit, and delete stadiums
* Upload and manage multiple images per stadium
* Filter stadiums by sport type, floor type, and availability
* Safe image slideshow with fallback handling

#### 📅 Booking & Reservation System

* Real-time availability checking
* Prevent overlapping bookings
* Match and referee assignment
* Reservation status tracking (Pending / Confirmed / Canceled)

#### 💳 Payment System

* Default and dynamic pricing
* Support for multiple payment methods and card types
* Fine calculation and tracking

#### 👥 User & Admin Management

* Secure login with role-based access
* Admin dashboard with complete control
* User activation/deactivation
* Operation logging and login history

#### 🔐 Security & Permissions

* Granular permission system
* Operation logging for accountability
* Secure password update procedures

---

### 🧱 Architecture (Clean Multi-Layer Design)

```
/Arena Whistle
│
├── Presentation Layer       → WinForms + Guna UI2 + Custom Controls
├── Business Logic Layer     → Managers, Validation, Business Rules
├── Data Access Layer        → ADO.NET + Stored Procedure Calls
└── Database (SQL Server)    → 25+ Tables, Procedures, Triggers, Functions
```

* **Presentation Layer (PL):** Handles user interface, custom controls, and animations.
* **Business Logic Layer (BLL):** Implements validation, business rules, and application logic.
* **Data Access Layer (DAL):** Manages database interactions via ADO.NET and stored procedures.
* **Database Layer:** Includes tables, procedures, functions, triggers, and constraints for secure and reliable data storage.

---

### 🧠 Skills & Technologies Applied

#### C# / .NET

* Events and Delegates
* Generics and Nullable Types
* Custom Controls
* Cryptography basics
* Windows Registry operations
* ADO.NET with Stored Procedures

#### SQL Server / T-SQL

* Variables, IF/CASE statements, TRY/CATCH blocks
* Transactions and error handling
* Scalar and Table-Valued Functions
* Window Functions
* INSTEAD OF Triggers
* Complex joins and business logic implemented in the database

---

### 🗃 Database Structure (25+ Tables)

**Key Tables:**

* `Stadiums`, `StadiumsImages`
* `Bookings`, `StadiumReservations`
* `Payments`, `BookingFines`
* `Users`, `Permissions`, `UsersOperations`
* `Employees`, `Referees`, `Departments`

**Database Backup Included:** `Arena Whistle.bak`

---

### 🧪 Robust Error Handling & Debugging

The application includes protections for common real-world errors:

* IndexOutOfRange exceptions (e.g., image lists)
* Null reference exceptions
* Missing columns in DataTables
* SQL constraint violations and transaction errors
* Input validation and user feedback

---

### 🚀 Technology Stack

| Category     | Technology                     |
| ------------ | ------------------------------ |
| Framework    | .NET Framework 4.7.2           |
| Language     | C#                             |
| UI           | WinForms + Guna UI2            |
| Database     | SQL Server                     |
| Data Access  | ADO.NET + Stored Procedures    |
| Architecture | Multi-layered (DAL → BLL → PL) |

---

### 🗺 Future Enhancements

* [ ] Migrate to **.NET 8 WinForms**
* [ ] Build a REST API backend
* [ ] Real-time notifications using SignalR
* [ ] PDF/Excel reporting module
* [ ] Full data encryption
* [ ] Web version (Blazor / ASP.NET Core)

---

### 👨‍💻 Author

**Developed by:** El Mehdi Mhaoune

---

### 📝 License

This project is for **educational and demonstration purposes** only.
