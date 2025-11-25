# 🏟️ Arena Whistle – Stadium Booking Management System

A full-featured **Stadium Booking Management System** built with **C# WinForms**, **Guna UI2**, **ADO.NET**, and **SQL Server Stored Procedures**.  
This project demonstrates real-world software engineering practices: clean multi-layer architecture, secure database design, role-based permissions, custom controls, and advanced T-SQL programming.

![Login Screen](screenshots/login.png)

---

### Project Overview

**Arena Whistle** is a desktop application that manages:

- Stadiums & multiple stadium images
- Bookings, schedules, availability & overlap prevention
- Users, roles, authentication & permissions
- Employees, referees & departments
- Payments, pricing, fines & card processing
- Client & administrative workflows

The focus is on **practical application** of OOP, design patterns, data structures, custom controls, and advanced database concepts.

---

### Key Features

#### Stadium Management
- Add / Edit / Delete stadiums
- Upload & manage multiple images per stadium
- Filter by sport type, floor type, availability
- Safe image slideshow with fallback handling

![All Stadiums View](screenshots/all_stadiums.png)  
![Stadium Add Mode](screenshots/add_stadium.png)

#### Booking & Reservation System
- Real-time availability checking
- Prevent overlapping bookings
- Match & referee assignment
- Reservation status tracking (Pending / Confirmed / Canceled)

![Booked Stadiums](screenshots/booked_stadiums.png)  
![Current Match Overview](screenshots/current_match.png)

#### Payment System
- Default & dynamic pricing
- Multiple payment methods & card types
- Fine calculation & tracking

#### User & Admin Management
- Secure login with role-based access
- Admin dashboard with full control
- User activation/deactivation
- Operation logging & login history

![Admin User Update Center](screenshots/user_update_center.png)  
![Change User Status](screenshots/change_status.png)

#### Security & Permissions
- Granular permission system
- Operation logging
- Secure password updates

![Update Password](screenshots/update_password.png)

---

### Modern UI with Guna UI2

Clean, animated, professional interface:

![Welcome Dashboard](screenshots/welcome_mhn.png)  
![Stadiums Zone](screenshots/stadiums_zone.png)  
![User Profile](screenshots/user_profile.png)  
![Update Personal Info](screenshots/update_personal_info.png)

---

### Architecture (Clean Multi-Layer Design)
/Arena Whistle
│
├── Presentation Layer       → WinForms + Guna UI2 + Custom Controls
├── Business Logic Layer     → Managers, Validation, Business Rules
├── Data Access Layer        → ADO.NET + Stored Procedure Calls
└── Database (SQL Server)    → 25+ Tables, Procedures, Triggers, Functions

---

### Skills & Technologies Applied

#### C# / .NET
- Events & Delegates
- Generics & Nullable Types
- Custom Controls
- Cryptography basics
- Windows Registry
- ADO.NET with Stored Procedures

#### SQL Server / T-SQL
- Variables, IF/CASE, TRY/CATCH
- Transactions & Error Handling
- Scalar & Table-Valued Functions
- Window Functions
- INSTEAD OF Triggers
- Complex Joins & Business Logic in DB

---

### Database Structure (25+ Tables)

Key tables: `Stadiums`, `StadiumsImages`, `Bookings`, `Payments`, `Users`, `Permissions`, `Referees`, etc.  
**Backup included**: `Data Base File/Arena Whistle.bak`

---

### Robust Error Handling & Debugging
Handles real-world issues such as IndexOutOfRange, NullReference, SQL constraints, missing columns, invalid input, etc.

---

### Technology Stack

| Category             | Technology                          |
|----------------------|-------------------------------------|
| Framework            | .NET Framework 4.7.2                |
| Language             | C#                                  |
| UI                   | WinForms + **Guna UI2**             |
| Database             | SQL Server                          |
| Data Access          | ADO.NET + Stored Procedures         |
| Architecture         | Multi-layered (DAL → BLL → PL)      |

---

### Future Enhancements
- [ ] Migrate to .NET 8 WinForms
- [ ] Build REST API backend
- [ ] Real-time notifications (SignalR)
- [ ] PDF/Excel reporting
- [ ] Full data encryption
- [ ] Web version (Blazor / ASP.NET Core)

---

### Author

**Developed by:** El Mehdi Mhaoune  
**Supervisor:** Dr. Mohammed Abu-Hadhoud

---

### License

This project is for **educational and demonstration purposes**.

---

**Thank you for checking out Arena Whistle!**  
A complete, production-ready example of professional desktop application development in C# and SQL Server.

Ready to manage stadiums like a pro!
