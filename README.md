# 🏗️ ConstructionAndRepair - Web Application for Repair & Construction Services

**ConstructionAndRepair** is a full-featured web application built with ASP.NET Core MVC that allows customers to easily find and book qualified construction and repair workers. The system also enables service providers (workers) to manage their availability and receive reviews from clients.

This project was developed as part of a diploma work for a software engineering education program. It follows modern software architecture principles and uses technologies such as .NET 8.0, Entity Framework Core, Razor Views, and SQL Server.

---

## 📌 Table of Contents

- [🎯 Project Goals](#-project-goals)
- [🛠️ Features](#-features)
- [🧰 Technologies Used](#-technologies-used)
- [📐 Architecture Overview](#-architecture-overview)
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

- ✅ Manual tests on Chrome and Opera browsers
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
![image](https://github.com/user-attachments/assets/323b2d3d-c26d-4b00-aa1e-186c9524136a)
![image](https://github.com/user-attachments/assets/f147eb11-84d1-4288-a3d6-fb30cb0bf370)
![image](https://github.com/user-attachments/assets/5bfaae3f-5acc-471a-8de5-2f2957c2a8da)
![image](https://github.com/user-attachments/assets/1130b025-4e02-4562-a479-768819b4eb8e)
![image](https://github.com/user-attachments/assets/5c282e2d-7896-46e4-aee2-1cfee1b5c1d3)


### Our Workers
![image](https://github.com/user-attachments/assets/3a2a7c82-0c26-42c0-bb3f-d6a09151c891)
![image](https://github.com/user-attachments/assets/ce122055-f15e-4031-ae62-13ba5ca4c98e)
![image](https://github.com/user-attachments/assets/d5fe849e-2a54-4117-8644-48bcbdc1e50c)
![image](https://github.com/user-attachments/assets/a43bc6c2-a773-4691-b0c8-e07c7d1322fe)
![image](https://github.com/user-attachments/assets/8c034725-7b12-431f-afaf-d09e8cb0504d)




### Customers
![image](https://github.com/user-attachments/assets/f70e25ff-8b11-4392-ac49-73375674162e)
![image](https://github.com/user-attachments/assets/d2a93cf6-aa85-404b-a622-fa73e48e75eb)
![image](https://github.com/user-attachments/assets/8bfda588-814f-4830-85d2-0a9de8776d7c)
![image](https://github.com/user-attachments/assets/4df77072-fcbf-42f3-b551-17770ffb96bf)
![image](https://github.com/user-attachments/assets/3f56dd8d-66ad-4358-adb5-a5bc5eba07ae)



### Bookings and customer bookings
![image](https://github.com/user-attachments/assets/c86c64b9-0118-455f-9841-4efb763f4d6c)
![image](https://github.com/user-attachments/assets/34928f8d-83c8-4678-9dd8-42c05eed77ee)
![image](https://github.com/user-attachments/assets/699a8fbd-9db9-4e85-ad0e-d28b3ebfd37b)
![image](https://github.com/user-attachments/assets/d3c19e5e-6642-43fe-b29d-e80060edd56f)
![image](https://github.com/user-attachments/assets/83ea8b2a-6205-47d1-97b1-1c961abfa657)
![image](https://github.com/user-attachments/assets/c65d21cd-81aa-4d0a-9d5d-438152a0f4b1)


### Reviews
![image](https://github.com/user-attachments/assets/590ad3f4-cefc-46ba-99bd-c00f5e1e2cf0)
![image](https://github.com/user-attachments/assets/874124a2-504d-4975-a6d9-4775657b3456)
![image](https://github.com/user-attachments/assets/8b207c06-c42f-47ba-a565-fe5c5d625824)
![image](https://github.com/user-attachments/assets/5dadb0d7-6a61-477c-a768-21664b49633f)
![image](https://github.com/user-attachments/assets/22a39d48-a93e-419b-870d-ea253f422370)

### Login
![image](https://github.com/user-attachments/assets/d5bea4d0-02d2-43ff-bb8b-6027397ac40e)

### Register
![image](https://github.com/user-attachments/assets/cf8acf80-0889-4aca-8861-dd0bcbc6d062)

### Forgoten password
![image](https://github.com/user-attachments/assets/abfe384b-fc49-4694-8beb-97226af5d311)



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


