📚 Library Management System (LMS)

A full-featured Library Management System built using:

💻 C#

🧱 .NET 8

🗄 Microsoft SQL Server

🛠 SQL Server Management Studio (SSMS 2022)

🧰 Visual Studio 2022

This system allows efficient management of books, members, and borrowing operations in a structured database-driven environment.

🚀 Features

Add, update, delete books

Manage library members

Issue and return books

Database-driven architecture

Clean modular structure

Secure SQL connection using Microsoft.Data.SqlClient

🏗 Technologies Used

C#

.NET 8

Microsoft SQL Server (Express)

SQL Server Management Studio 2022

Visual Studio 2022

Microsoft SQL Client (NuGet Package)

⚙️ Setup Instructions

Follow these steps to run the project locally:

1️⃣ Restore the Database

Open SQL Server Management Studio (SSMS 2022)

Right-click Databases

Click Restore Database

Select the provided LMS database backup (.bak) file

Complete restore process

2️⃣ Open Project in Visual Studio

Open Visual Studio 2022

Open the .sln file

Wait for project dependencies to load

3️⃣ Install SQL Client

Go to:

Tools → NuGet Package Manager → Manage NuGet Packages

Install:

Microsoft.Data.SqlClient
4️⃣ Get Connection String

Go to:

View → Server Explorer

Click:

Add Connection

Connect to your restored LMS database

Copy the generated Connection String

5️⃣ Configure Database Connection

Go to:

Solution Explorer → Utils → DbConnection.cs

Replace the existing connection string with yours.

Example:

private string connectionString = "YOUR_CONNECTION_STRING_HERE";
6️⃣ Run the Project

Click:

Start (▶) or F5

The project should now run successfully.
