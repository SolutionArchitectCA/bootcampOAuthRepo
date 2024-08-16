Steps to create the Identity Authentication using ASP.NET Core WebApp:

1. dotnet new webapp --auth Individual
2. dotnet tool install --global dotnet-ef
3. dotnet tool install --global dotnet-aspnet-codegenerator
4. dotnet add package Microsoft.AspNetCore.Identity.UI
5. dotnet add package Microsoft.EntityFrameworkCore.Sqlite
6. dotnet add package Microsoft.EntityFrameworkCore.Tools
7. dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
8. dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
9. dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
10. dotnet aspnet-codegenerator identity -dc bootcampOAuthRepo.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout;Account.RegisterConfirmation" --databaseProvider sqlite
11. dotnet ef migrations add InitialCreate
12. dotnet ef database update
