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


### Adding new field // Updating Migration
1. Add a new field to the Movies Model
2. Updte the [BIND] n the create and edit actions
3. Add new field in the index.cshtml page in the table
4. Add a new form group with the new field in the create.cshtml page

If you try and visit the Movies page, it will SQL error because of the new field.

#### There are a few approaches to resolving the error:
- Have the Entity Framework automatically drop and re-create the database based on the new model class schema. This approach is very convenient early in the development cycle when you are doing active development on a test database; it allows you to quickly evolve the model and database schema together. The downside, though, is that you lose existing data in the database — so you don't want to use this approach on a production database! Using an initializer to automatically seed a database with test data is often a productive way to develop an application.
- Explicitly modify the schema of the existing database so that it matches the model classes. The advantage of this approach is that you keep your data. You can make this change either manually or by creating a database change script.
- Use Code First Migrations to update the database schema.

### Update the Migration
1. open up the Package Manager Console
2. run this command:

```csharp
Add-Migration Rating
Update-Database
```