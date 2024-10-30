-Microsoft.EntityFrameworkCore
-Microsoft.EntityFrameworkCore.des
-Microsoft.EntityFrameworkCore.tool
-Microsoft.EntityFrameworkCore.sql

Oracle.EntityFrameworkCore

dotnet ef migrations add InitialCreate --context  ApplicationDbContext

 dotnet ef migrations add userAuthorizeApps --context  ApplicationDbContext

dotnet ef database update

dotnet ef database update --context  ApplicationDbContext


======
-Enable-Migrations
-Add-Migration
-Update-Database
-Remove-Migration

====Public
 dotnet publish -c Release -o ./publish

-Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design
-Now, Right Click on the project and click on "Add new Scaffolded Item". Click on "Identity" and then click "Add".