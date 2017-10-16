# Tabcorp
## Ingredients used:
.Net Core SDK 1.0.0 preview2

Microsoft.EntityFrameworkCore.Sqlite 1.0.0

Microsoft.EntityFrameworkCore.Tools 1.0.0-preview2-final

Microsoft.EntityFrameworkCore.Design 1.0.0-preview2-final

## Design:
This .Net Core Web API application follows a blend of MVC(without the view) and Repository pattern, where repository class encapsulates data related work from Model and Controller objects. POCO has been used to define accepted data model. Application also makes sure objects are invoked through dependency injection via constructor injection. 
For persistent memory storage, SQLite was selected given its ease of use and lightweight nature. Entity Framework has been used to take advantage of migration to create database schema also to enhance security as we don’t need to parameterize queries here. Database is included in src\tabcorp\bin\Debug\netcoreapp1.0 .

## Git Branch Strategy:
In a real world scenario, I would follow ‘Git Flow’ model and develop on feature branches with pull requests to develop branch; but given the nature of this exercise, I have continuously developed on a single branch. 

