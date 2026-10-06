# Sazón - Proyecto Académico 

**Sazón** es una aplicación web desarrollada para la materia **Programación 4** de la **Universidad Nacional de Lomas de Zamora (UNLZ)**. 
El sistema está diseñado para la gestión y administración de recetas y categorías gastronómicas.

## Tecnologías Utilizadas
* **Lenguaje:** C#
* **Framework:** ASP.NET Core MVC (.NET 8.0 / .NET 9.0)
* **ORM:** Entity Framework Core (Code First)
* **Base de Datos:** SQL Server
* **Diseño e Interfaz:** HTML, CSS, JavaScript y Bootstrap

##  Funcionalidades 
* **Arquitectura MVC:** Separación clara de responsabilidades mediante Controladores, Modelos y Vistas.
* **CRUD de Categorías:** Gestión completa (Creación, Lectura, Actualización y Eliminación) de las categorías del menú.

##  Cómo ejecutar el proyecto localmente
Para levantar el proyecto y recrear la base de datos desde cero utilizando las migraciones de Entity Framework:

1. Clone este repositorio:
   ```bash
   git clone https://github.com
   ```
2. Abra la solución (`Sazon.sln`) en **Visual Studio**.
3. Asegure de configurar su cadena de conexión en el archivo `appsettings.json` según su instancia local de SQL Server.
4. Abra la terminal (Developer PowerShell) y ejecutá el siguiente comando para generar la base de datos y sus tablas automáticamente:
   ```bash
   dotnet ef database update
   ```
5. Aprete (F5) para iniciar la aplicación o https.
