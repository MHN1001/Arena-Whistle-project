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

# ⚙️ Getting Started – Clone, Configure & Run

Follow these steps to set up **Arena Whistle** on your local machine:

---

## 1. Clone the Repository

```bash
git clone https://github.com/your-username/arena-whistle.git
cd arena-whistle
```

---

## 2. Restore the Database

1. Open **SQL Server Management Studio (SSMS)**.
2. Connect to your local SQL Server instance.
3. Right-click on **Databases** → **Restore Database**.
4. Choose **Device** → browse and select `Arena Whistle.bak` from the project folder.
5. Click **OK** to restore the database.

---

## 3. Update the Connection String

The application uses **ADO.NET** to connect to SQL Server.
Update the connection string in the configuration file (or directly in the DAL) as follows:

```csharp
string connectionString = "Server=.;Database=Arena Whistle;User ID=sa;Password=123456";
```

> ⚠️ Ensure your SQL Server `sa` account is enabled and the password matches.

---

## 4. Open the Project

* Open **Arena Whistle.sln** in **Visual Studio** (2019 or later recommended).
* Build the solution (`Ctrl + Shift + B`) to restore dependencies and compile.

---

## 5. Run the Application

* Press `F5` or click **Start** to launch the application.
* Log in using default credentials (if provided) or add users in the database.

---

This completes the setup and you should now have **Arena Whistle** running locally.


---

### 👨‍💻 Author

**Developed by:** El Mehdi Mhaoune

---

### 📝 License

This project is for **educational and demonstration purposes** only.
