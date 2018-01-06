# ![cf](http://i.imgur.com/7v5ASc8.png) Lecture 13 : Entity Framework 6

## Entity Framework 6

1. Entity Framework Core is a lightweight extensible, and cross platform version fo the popular Entity Framework data access technology
2. EF Core is an object-relational mapper(O/RM) that enables .NET developers to work with a database using .NET objects.
3. It eliminates the need for most of the data-access code that developers usually need to writ.
4. EF Core supports many database engines.

### Code First Migrations

1. We will use Package Manager Console to:
   - Add the entity Framework Core Tools Package (req to add migrationsand update the database)
   - Add the initial migration
   - update the database with the initial migration
2. Open up NuGet Package Manager console and run the following Command:

` Install-Package Microsoft.EntityFrameworkCore.Tools` <br />
`Add-Migration Initial` <br />
`Update-Database`

1. Notice the new Migrations folder.  
1.The Add-Migration command creates code to create the initial database schema. The schema is based on the model specified in the DbContext(In the Data/MvcMovieContext.cs file). The Initial argument is used to name the migrations. You can use any name, but by convention you choose a name that describes the migration. See Introduction to migrations for more information.2
1. The Update-Database command runs the Up method in the Migrations/<\time-stamp>_InitialCreate.cs file, which creates the database.
Run/Test the app. see the changes in the Database


### Update the Migration
1. open up the Package Manager Console
2. run this command:

```csharp
Add-Migration Rating
Update-Database
```

# Assignments

## Readings
1. [Entity Framework 6](https://docs.microsoft.com/en-us/aspnet/core/data/entity-framework-6)
2. [Models](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model)