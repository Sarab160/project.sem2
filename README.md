# 🚆 Railway System - C# Windows Forms Application

A complete Railway Management System built using C# Windows Forms, designed to manage trains, passengers, travels, reservations, and cancellations through an intuitive user interface.

---

## 📌 Project Information

- **Project Name:** Railway System  
- **Project Type:** Desktop-based CRUD application using C#  
- **Project Phase:** Analysis and Design  
---

## 📝 Project Description

This project implements a railway management system that simulates real-world train operations and ticket reservations. The system begins with a **Splash Screen**, followed by a **Login Form** with authentication. On successful login, users are directed to the **Main Form**, from which they can access all other modules:

- **Train Master:** Add, edit, delete, and view train records.
- **Passenger Master:** Manage passenger details.
- **Travel Master:** Assign travels to specific trains and manage their schedules.
- **Reservation Master:** Make and manage ticket reservations.
- **Cancellation Master:** Cancel reservations and maintain cancellation records.

---

## 🔒 Business Rules

### 🔹 Train Master
- Unique `TrainID` for each train.
- Requires train name and a defined route.
- Supports schedule and route changes.

### 🔹 Passenger Master
- Unique `PassengerID`.
- Passengers can reserve multiple travels.

### 🔹 Travel Master
- Unique `TravelID`.
- Must include departure date, source, destination.
- Can contain multiple reservations.

### 🔹 Cancellation Master
- Unique `CancelID` linked to travel.
- Logs all cancellations.

### 🔹 Reservation Master
- Unique `ReservationID`.
- Linked to both passenger and travel.
- Supports cancellation/modification.

---

## 📊 Final Entities (Masters)

- Passenger Master  
- Cancellation Master  
- Reservation Master  
- Train Master  
- Travel Master  

---

## 🧩 Database Table Design

### 🟦 Train Master
- Train Name  
- Train Capacity  
- Train Status  

### 🟩 Travel Master
- Date  
- Train Code  
- Source  
- Destination  
- Travel Cost  

### 🟨 Passenger Master
- Passenger Name  
- Address  
- Gender  
- Nationality  
- Phone  

### 🟥 Cancellation Master
- Ticket ID  

### 🟪 Reservation Master
- Passenger ID  
- Travel Code  

---

## 🧾 Forms Included

- **Login Form** – Secure entry point to the system  
- **Main Form** – Central dashboard for navigation  
- **Train Master Form** – Manage train data  
- **Travel Master Form** – Manage travel schedules  
- **Passenger Master Form** – Manage passenger info  
- **Reservation Master Form** – Make/manage reservations  
- **Cancellation Master Form** – Manage cancellations  

---

## 🛠️ Tech Stack

- **Language:** C#  
- **Framework:** .NET Framework (Windows Forms)  
- **IDE:** Visual Studio  
- **UI Toolkit:** Guna UI2  

---

## 🎯 Usage

- Launch the application.
- Login using credentials:  
  - Username: `sarab`  
  - Password: `1234`  
- Navigate to different modules via the Main Form.



