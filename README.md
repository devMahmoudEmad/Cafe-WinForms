# Cafe Management System

A Windows Forms application for managing a cafe, built with C#, .NET 8.0, and Entity Framework Core.

## Features
- Manage menu items: Food, Drinks, and Desserts
- Place and track orders
- User-friendly graphical interface
- Data persistence using Entity Framework Core
- Database migrations for easy schema updates

## Project Structure
- `Form1.cs` — Main Windows Form UI
- `models/` — Entity models: `Food`, `Drink`, `Dessert`, `Item`
- `context/` — `CafeContext.cs` for Entity Framework Core
- `Migrations/` — Database migration files
- `Program.cs` — Application entry point

## Getting Started
1. **Requirements:**
   - .NET 8.0 SDK
   - Windows OS (for WinForms)
2. **Build and Run:**
   - Open `Cafe.sln` in Visual Studio
   - Restore NuGet packages
   - Build and run the project
3. **Database:**
   - The app uses Entity Framework Core for data access
   - Migrations are included in the `Migrations/` folder

## Usage
- Add, edit, or remove menu items
- Place orders and view order history
- Data is stored locally using EF Core

## License
This project is for educational purpose only XD

