# 🚀 ASP.NET Core MVC CRUD Application

A student management application built using **ASP.NET Core MVC, Entity Framework Core, and Azure SQL Database** to practice database operations and understand how web applications interact with cloud databases.

## Technologies

* C#
* ASP.NET Core MVC
* Entity Framework Core
* Razor Views and HTML Helpers
* SQL Server
* Azure SQL Database

## Features

* Add new student records
* Update existing student details
* Delete student records
* Retrieve student details using Student ID
* Form handling with model binding
* Model validation using data annotations and `ModelState.IsValid`
* Database operations using Entity Framework Core

## Student Information

The application manages student details such as:

| Field        | Description                     |
| ------------ | ------------------------------- |
| Student ID   | Unique identifier for a student |
| Name         | Student's full name             |
| Department   | Student's department            |
| Email        | Student's email address         |
| Phone Number | Contact number                  |
| Pending Fees | Outstanding fee amount          |

## Implementation Details

This project uses Entity Framework Core to perform database operations without writing SQL queries for every operation.

* **DbContext:** Manages the database connection and operations.
* **DbSet:** Represents the collection of student records.
* **Add():** Adds a new student entity.
* **FirstOrDefault():** Retrieves a matching student record.
* **Remove():** Marks a student record for deletion.
* **SaveChanges():** Persists changes to the database.

The Razor view uses `EditorForModel()` and `HiddenFor()` to generate form fields and submit the student ID.

## Database Configuration

The application connects to Azure SQL Database through a configured connection string.

To run the project:

1. Configure the database connection string.
2. Ensure the database and required table exist.
3. Register `AppDbContext` in the application's dependency injection configuration.
4. Configure Azure SQL firewall access if required.
5. Build and run the application.

> **Security:** Keep database credentials out of source code and public repositories. Use secure configuration for connection strings.

## What I Learned

* Working with ASP.NET Core MVC controllers and Razor views
* Performing CRUD operations using Entity Framework Core
* Understanding model binding and model validation
* Using `DbContext` and `DbSet` to manage data
* Connecting an ASP.NET Core application to Azure SQL Database

---

**Project Type:** Practice Project
**Focus:** ASP.NET Core MVC | Entity Framework Core | Azure SQL Database
