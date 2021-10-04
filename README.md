





### History

```
dotnet new classlib -n MyLibrary
dotnet new xunit -n MyLibrary.Tests
dotnet add MyLibrary.Tests reference MyLibrary
dotnet new sln
dotnet sln add MyLibrary
dotnet sln add MyLibrary.Tests
dotnet restore

dotnet add MyLibrary package Npgsql.EntityFrameworkCore.PostgreSQL
```