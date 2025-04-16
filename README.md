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

- **10 Models**: `AppUser`, `Worker`, `Customer`, `JobOffer`, `Booking`, `Review`,`WorkerDashboardViewModel`,`AdminDashboardViewModel`,`LoginModel`,`SearchViewModel`
- **10 Controllers**: One for each feature entity
- **10 Views**: With full Create, Read, Update, Delete functionality
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

### 📋 Admin
- Can manage all data 

---

## 🧪 Testing & Security

- ✅ Manual tests on Chrome and Edge browsers
- ✅ 16 Unit tests covering  business logic 
- ✅ Form validation on client and server side
- ✅ Basic protection against SQL injection via EF Core
- ✅ Session-based login to prevent unauthorized access

---

## 🚀 Getting Started

1. **Clone the repository**

```bash
git clone https://github.com/DimiturDj/ConstructionAndRepair.git
cd ConstructionAndRepair
```
## 📸 Screenshots

### Homepage
![image](https://github.com/user-attachments/assets/f1350d45-5df6-4275-afe6-6ba8dbd3af8b)
![image](https://github.com/user-attachments/assets/abfb94f9-0fb8-4728-8c53-cf3551458b3e)


### Available Job Offers
![image](https://github.com/user-attachments/assets/408c6a86-67d4-47db-ba5d-2105ec194b4c)
![image](https://github.com/user-attachments/assets/8c748af9-fe41-4df0-8f89-e34fd7b850d9)
![image](https://github.com/user-attachments/assets/a2b481c2-afc5-412c-aa1e-f9f259ccffff)
![image](https://github.com/user-attachments/assets/a9de5e1c-dc45-4d47-8a00-0f80b3972866)


### Our Workers
![image](https://github.com/user-attachments/assets/00fd98f9-c8ec-4a46-9eee-6ae68489e9f9)
![image](https://github.com/user-attachments/assets/93a44283-bb19-4026-8bb6-a6f4e1e7a927)
![image](https://github.com/user-attachments/assets/aab8c56d-ed1a-4f92-8247-d3a23bb523dc)


### Customers
![image](https://github.com/user-attachments/assets/df063b83-5511-47c7-9212-86f91636c253)
![image](https://github.com/user-attachments/assets/2442a4c4-7e02-43cf-8127-1fa6d9ff680a)
![image](https://github.com/user-attachments/assets/0727dd02-eb1f-4281-8464-20fec245f259)
![image](https://github.com/user-attachments/assets/4da4b8eb-552a-4148-bbea-b1ec3d0cab17)


### Bookings
![image](https://github.com/user-attachments/assets/29807b3c-ec79-4b15-9efc-01e2189067c5)
![image](https://github.com/user-attachments/assets/f0285634-7090-4e73-bb81-a6e5ef359a1f)
![image](https://github.com/user-attachments/assets/6a05533e-4113-4407-9a60-dd4f9304e685)
![image](https://github.com/user-attachments/assets/4eb42ec9-4567-46b9-9fbe-478f81f90de7)


### Reviews
![image](https://github.com/user-attachments/assets/e89aa605-bc62-457f-99a3-1c00ea188059)
![image](https://github.com/user-attachments/assets/ab9096ac-e391-4208-88af-875c5db911a3)
![image](https://github.com/user-attachments/assets/ca4aa0bb-dd01-45f4-80a5-2a6b07940510)
![image](https://github.com/user-attachments/assets/0c943558-dcc1-442f-8666-8f5bf8f7fa18)


### About Page
![image](https://github.com/user-attachments/assets/3fa2a415-94f8-4cf3-be7c-907897f79a3f)

### Contact Page
![image](https://github.com/user-attachments/assets/a8a5995e-d1f1-4c43-a9ff-5755879e6f4b)


### Admin Panel
![image](https://github.com/user-attachments/assets/29be85a3-7b84-4c92-85b6-6db4f1302ec6)
### Worker Panel
![image](https://github.com/user-attachments/assets/da6cc4a2-70cc-44e9-ab65-1603345a6330)

### Unit Tests 
![image](https://github.com/user-attachments/assets/98ba2dd3-77c0-4c04-9a0d-14588f4ee147)


