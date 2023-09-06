# Vessel and Accident Management System

This is a .NET 6 WinForms application designed to manage vessels and accidents in ports. The application allows users to perform CRUD operations on vessels associated with specific ports, and it also provides a separate Accident Management page where users can select accidents on a Persian Gulf map and determine the best vessel from the nearest port for assistance.

## Features

- Create, Read, Update, and Delete (CRUD) operations for vessels.
- Display a Persian Gulf map on the Accident Management page.
- Select accidents on the map and identify the nearest port for assistance.
- Utilizes Entity Framework Core for database interaction.
- Uses SQL Server as the database.

## Installation

1. **Clone the Repository**

   ```shell
   git clone https://github.com/yourusername/your-repo-name.git
   cd your-repo-name
Build the Project

Open the solution in Visual Studio (or your preferred IDE) and build the project. Make sure you have .NET 6 installed.

2. # Database Configuration

Update the database connection string in the appsettings.json file to point to your SQL Server instance:

"ConnectionStrings": {
  "DefaultConnection": "Server=your-server;Database=your-database;User Id=your-username;Password=your-password;"
}

3. # Use Entity Framework Core migrations to create and update the database schema

   shell
   dotnet ef database update
   Run the Application

Start the application, and it should open the Vessel Management page by default.

# Usage
Vessel Management

Use the Vessel Management page to create, update, and delete vessels associated with ports.
The page allows you to input vessel details and associate them with a port's latitude and longitude.
Accident Management

Navigate to the Accident Management page.
Interact with the Persian Gulf map to select an accident location.
The application will determine the nearest port based on the accident's location and suggest a suitable vessel for assistance.
Technologies Used
.NET 6
C#
WinForms
Entity Framework Core
SQL Server
Database Setup
The application uses SQL Server as the database.
Make sure to configure the connection string in the appsettings.json file.

Contributions to this project are welcome. To contribute:

Fork the repository.
Create a new branch for your feature or bug fix.
Make your changes and commit them.
Push your changes to your fork.
Submit a pull request with a clear description of your changes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.
