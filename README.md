
Agregar SQLite
dotnet add package Microsoft.EntityFrameworkCore.Sqlite


Usar Migration para crear el esquema a partir de nuestro codigo
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update


Ingenieria inversa desde una BBDD
dotnet ef dbcontext scaffold "Data Source=hospital.db" Microsoft.EntityFrameworkCore.Sqlite

Compilar y correr
dotnet run
