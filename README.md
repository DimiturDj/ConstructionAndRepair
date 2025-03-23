# 🏗️ ConstructionAndRepair - Web Application for Repair & Construction Services

**ConstructionAndRepair** is a full-featured web application built with ASP.NET Core MVC that allows customers to easily find and book qualified construction and repair workers. The system also enables service providers (workers) to manage their availability and receive reviews from clients.

This project was developed as part of a diploma work for a software engineering education program. It follows modern software architecture principles and uses technologies such as .NET 8.0, Entity Framework Core, Razor Views, and SQL Server.

---

## 📌 Table of Contents

- [🎯 Project Goals](#-project-goals)
- [🛠️ Features](#-features)
- [🧰 Technologies Used](#-technologies-used)
- [📐 Architecture Overview](#-architecture-overview)
- [🖥️ Pages and Roles](#-pages-and-roles)
- [🧪 Testing & Security](#-testing--security)
- [🚀 Getting Started](#-getting-started)
- [📸 Screenshots](#-screenshots)
- [📄 License](#-license)

---

## 🎯 Project Goals

- Develop a fully functioning web platform for managing repair and construction services.
- Enable different roles: administrators, customers, and workers.
- Include CRUD operations for all core entities.
- Support service bookings, feedback, reviews, and availability management.
- Design a clean, responsive and user-friendly interface.
- Follow the software development lifecycle: analysis, design, implementation, testing, deployment.

---

## 🛠️ Features

- ✅ User Registration and Login (custom session-based authentication)
- ✅ Dynamic navigation based on login state
- ✅ Manageable job offers (CRUD)
- ✅ Worker and customer profiles
- ✅ Bookings with time and service selection
- ✅ Review system with rating and comments
- ✅ Fully responsive layout using Bootstrap
- ✅ Admin access to all data
- ✅ Automatic login after registration
- ✅ Protected pages accessible only after login

---

## 🧰 Technologies Used

| Technology             | Description |
|------------------------|-------------|
| ASP.NET Core MVC (.NET 8.0) | Backend framework |
| Razor Views            | Server-side rendering |
| Entity Framework Core  | ORM and DB layer |
| MS SQL Server          | Database engine |
| Bootstrap 5            | Styling and layout |
| Git & GitHub           | Version control |
| Visual Studio 2022     | Development IDE |

---

## 📐 Architecture Overview

- **5 Models**: `AppUser`, `Worker`, `Customer`, `JobOffer`, `Booking`, `Review`
- **5 Controllers**: One for each feature entity
- **5 Views**: With full Create, Read, Update, Delete functionality
- **Database**: Code-first with EF Core and `AppDbContext`
- **Authentication**: Custom login/logout using `HttpContext.Session`

---

## 🖥️ Pages and Roles

### 👤 Guest Users
- View job offers and public content
- Register as customer or worker

### 🔑 Logged-in Users
- Book services
- Leave reviews
- See personalized greeting and logout option

### 👷 Workers
- View job offers
- Get reviewed

### 📋 Admin
- Can manage all data through backend

---

## 🧪 Testing & Security

- ✅ Manual tests on Chrome and Edge browsers
- ✅ Unit tests covering 65% of business logic (controllers, services)
- ✅ Form validation on client and server side
- ✅ Basic protection against SQL injection via EF Core
- ✅ Session-based login to prevent unauthorized access

---

## 🚀 Getting Started

1. **Clone the repository**

```bash
git clone https://github.com/DimiturDj/ConstructionAndRepair.git
cd ConstructionAndRepair
