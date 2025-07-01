# Flower Shop Management Desktop App

## 💻 Features

- Add, edit, and delete products
- Manage customer orders with drag-and-drop interface
- Handle delivery information for each order
- Display graphical statistics for products (by category or quantity)
- User login and data persistence through SQLite database

## 🛠️ Technologies

- Language: C#
- Framework: .NET Framework (Windows Forms)
- Database: SQLite (`Florarie.db`)
- Tools: Visual Studio, Windows Forms Designer

## 📁 Structure

- `Produs.cs`, `Client.cs`, `Comanda.cs`, `Livrare.cs`: Business logic classes
- `FormAdaugareProdus`, `FormGraficProduse`, `FormDragDropComenzi`: UI forms
- `BazaDate.cs`: Database interaction layer
- `Florarie.db`: Local database file

## 🚀 How to Run

1. Open the `AlpicatieFlorarie.sln` file in Visual Studio.
2. Build the solution.
3. Run the application (F5) and interact with the interface.
4. Ensure that `Florarie.db` is present in the correct folder for data persistence.

## 📸 Screenshots

_Add screenshots here to showcase application interface and features._

## 📌 Notes

- This app was developed as part of an academic software engineering project.
- Suitable for small businesses or educational purposes.
