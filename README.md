# 🏟️ Arena Whistle

### Stadium Booking Management System

**Arena Whistle** is a comprehensive Windows Forms application designed to manage stadium bookings, users, permissions, stadium data, and administrative operations.

This project was developed with a focus on applying real-world software development concepts, moving beyond basic CRUD operations to implement ADO.NET, stored procedures, custom controls, rigorous debugging, and a robust multi-layer architecture.

http://googleusercontent.com/image_generation_content/0



-----

## 📌 Project Overview

Built using C# and the .NET Framework, Arena Whistle leverages **Guna UI2** for a modern, enhanced user interface and **SQL Server** for data persistence. The application supports distinct roles for administrators and client users, handling schedules, authentication, and complex permissions.

### 🎯 Main Objectives

The primary goal of this project is to bridge theoretical knowledge with practical application:

  * Building a complete real-world system using **ADO.NET** without relying on ORMs like Entity Framework.
  * Implementing **Stored Procedures** for all database operations to ensure performance and security.
  * Mastering WinForms UI/UX design using modern libraries like Guna UI2.
  * Implementing **Role-Based Access Control (RBAC)**.
  * Designing a clean **Multi-Layer Architecture**.
  * Handling real-world exceptions and debugging edge cases (e.g., missing images, data concurrency).

-----

## 🖼️ Application Screenshots

### Authentication & Dashboards

The application features secure login and distinct navigation areas for users and administrators.

| Sign In                                                                                                                                                                                                                                                             | Main Menu (Stadium Zone)                                                                                                                                                                                                                                                            |
| :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| http://googleusercontent.com/image_generation_content/1

 | http://googleusercontent.com/image_generation_content/2

 |

-----

## 🏟️ Key Features

### ✅ Stadium Management

Admins have full control over the stadium inventory.

  * **CRUD Operations:** Add, edit, and delete stadiums.
  * **Image Gallery:** Store and display multiple images per stadium with an integrated slideshow.
  * **Organization:** Sort and filter facilities by Sport Type or ID.
  * **Resilience:** Auto-handling of missing image indexes or corrupted data.

http://googleusercontent.com/image_generation_content/3



### ✅ Booking Management

A robust system to handle reservations and prevent conflicts.

  * **Smart Scheduling:** Prevents overlapping bookings through database validations.
  * **Real-time Availability:** Calculates and displays open slots.
  * **Filtering:** View booked stadiums and filter history by date, user, or sport.

| Booked Stadiums List                                                                                                                                                                                                                                                        | Current Match Overview                                                                                                                                                                                                                                                            |
| :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| http://googleusercontent.com/image_generation_content/4

 | http://googleusercontent.com/image_generation_content/5

 ### ✅ User & Admin Management

Comprehensive tools for managing system access.

  * **Role-Based Security:** Secure login system distinguishing between Admins and Client Users.
  * **User Administration:** Add new users or deactivate existing accounts.
  * **Profile Management:** Users can update their personal information and change passwords securely.

| Find User (Admin View)                                                                                                                                                                                                                                                            | Update Profile (User View)                                                                                                                                                                                                                                                            |
| :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| http://googleusercontent.com/image_generation_content/6

 | http://googleusercontent.com/image_generation_content/7



-----

## 🚀 Technology Stack

| Category     | Technology                       |
| :----------- | :------------------------------- |
| **Framework** | .NET Framework                   |
| **Language** | C#                               |
| **UI Toolkit** | Windows Forms (WinForms) + Guna UI2 |
| **Database** | SQL Server                       |
| **Data Access** | ADO.NET + Stored Procedures      |
| **Architecture** | Multi-layered (Presentation, BLL, DAL) |

-----

## 🧱 Project Architecture

The solution follows a strict separation of concerns:
