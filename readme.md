# Basic_Crud

This project demonstrates how to create a simple CRUD (Create, Read, Update, Delete) application using C# and SQLite. It's an excellent starting point for those new to .NET development, especially for building desktop applications with Windows Forms and integrating them with a relational database.

## 🛠️ Technologies Used

* **Programming Language**: C#
* **UI Framework**: Windows Forms
* **Database**: SQLite

## 🚀 Features

* **Create**: Add new products to the database.
* **Read**: View a list of all products.
* **Update**: Modify existing product details.
* **Delete**: Remove products from the database.
* **Search**: Filter products by name.

## 📂 Project Structure

```
Basic_Crud/
├── Controllers/      # Business logic and data handling
├── Core/             # Application configuration and startup
├── Models/           # Data models (e.g., Product)
├── Views/            # Windows Forms UI
├── Basic_CRUD.csproj # Project file
└── Basic_CRUD.sln    # Solution file
```

## ⚙️ Getting Started

### Prerequisites

* [Visual Studio](https://visualstudio.microsoft.com/) with the **.NET Desktop Development** workload installed.
* [SQLite](https://www.sqlite.org/) installed on your machine.

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/senhorbento/Basic_Crud.git
   cd Basic_Crud
   ```

2. Restore NuGet packages:

   ```bash
   dotnet restore
   ```

3. Run the application:

   ```bash
   dotnet run
   ```

## 🧪 Usage

Upon launching the application:

* **Add Product**: Click the "Insert" button, fill in the product details, and click "Salvar".
* **Edit Product**: Select a product from the list, modify the details, and click "Salvar".
* **Delete Product**: Select a product and click "Delete".
* **Search Products**: Use the search box to filter products by name.

## 📚 Learn More

This repository serves as a practical guide for beginners to understand how to:

* Set up a Windows Forms application with SQLite.
* Implement CRUD operations using Entity Framework Core.
* Bind data to UI controls like `DataGridView`.
