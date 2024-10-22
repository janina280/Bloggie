# Bloggie

A web application built using ASP.NET MVC and Bootstrap 5. The project includes functionality for managing blog posts and editing tags.

### Description
Bloggie is a blogging platform developed with ASP.NET MVC and styled using Bootstrap 5. It allows users to manage blog content, including creating, editing, and deleting posts. One of the key features is the ability to edit and manage tags associated with each post. This makes it easier to categorize and organize content for better user experience.

### Getting Started
* Dependencies
  
- .NET 6.0 SDK or higher
  
- Visual Studio 2022 (or any IDE that supports .NET development)
  
- SQL Server (for database storage)
  
- Bootstrap 5 (for front-end styling)
  
- C#, HTML, CSS, JavaScript (core technologies used in the application)

### Installing
Clone the Repository:
```
git clone https://github.com/janina280/Bloggie.git
cd Bloggie
```

Open the project in Visual Studio:

* Launch Visual Studio.
* Open the solution file Bloggie.sln.

Configure the database:
Set up your SQL Server connection string in appsettings.json:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server_name;Database=BloggieDB;Trusted_Connection=True;"
}
```

Run the migrations to create the database schema:

```
Update-Database
```

### Build the project:

Restore NuGet packages and build the solution in Visual Studio.

Executing program

Run the web application from Visual Studio by pressing F5 or selecting "Start Debugging".

Open your browser and navigate to the local URL usually http://localhost:5000 or http://localhost:5001.

You will now be able to:

* Create, edit, and delete blog posts.
* Edit and manage tags associated with posts.
