2025-01-22
0900
Added a View HelloWorld
Test and Run
successfull

2025-01-22
0930
Visual apgraded NuGet Packages
Added MoviesController.cs
Attempting to compile the application in memory with the added DbContext.
Attempting to figure out the EntityFramework metadata for the model and DbContext: 'Movie'
warn: Microsoft.EntityFrameworkCore.Model.Validation[30000]
      No store type was specified for the decimal property 'Price' on entity type 'Movie'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the SQL server column type that can accommodate all the values in 'OnModelCreating' using 'HasColumnType', specify precision and scale using 'HasPrecision', or configure a value converter using 'HasConversion'.
Using database provider 'Microsoft.EntityFrameworkCore.SqlServer'!
Added DbContext : '\Data\MvcMovieContext.cs'
Added Controller : '\Controllers\MoviesController.cs'.
Added View : \Views\Movies\Create.cshtml
Added View : \Views\Movies\Edit.cshtml

2025-01-22
updated package manager
lot of stuff happening?
Visual took care of everything
(N'20250122145919_InitialCreate', N'8.0.11')
C:\Users\k_cha\source\repos\MvcMovie\MvcMovie\Migrations\20250122145919_InitialCreate.cs

https://localhost:7094/Movies/Edit/5

2025-01-25
2211
Add search by genre
created a class file named MovieGenreViewModel.cs in the Models folder
Replaced the Index method in MoviesController.cs with new code
to use LINQ to get list of genres

2025-01-25
2224
Add search by genre to the Index view
replaced Model with Model.Movies
When the lambda expression is evaluated (for example, @Html.DisplayFor(modelItem => item.Title)), the model's property values are evaluated.
The ! after model.Movies is the null-forgiving operator, which is used to declare that Movies isn't null.
Tested App
https://localhost:7094/Movies?MovieGenre=&SearchString=2

2025-01-25
2259
Add a Rating property to Models/Movie.cs
by adding this command at the end of the file Movie.cs
public string? Rating { get; set; }
Because we added a new field to the Movie class we need to rebuild the app
Tutoriol instructed to press Ctrl Shift B but didn't work
Had to use drop down menu Build MvcMovie

In MoviesController.cs, added Rating to the [Bind] attribute for both the Create and Edit action methods

20250125
2311
added to Views/Movies/Index.cshtml
@Html.DisplayNameFor(model => model.Movies![0].Rating)
updated SeedData
updated Views/Movies/Create.cshtml
Run App
Error
An unhandled exception occurred while processing the request.
SqlException: Invalid column name 'Rating'.
Microsoft.Data.SqlClient.SqlCommand+<>c.<ExecuteDbDataReaderAsync>b__211_0(Task<SqlDataReader> result)

Had to get NuPackages
Ran these commands in the PM command prompt
""Add-Migration Rating""
"Update-Database""
  VALUES (N'20250126042838_Rating', N'8.0.11')

Ran app
successful

Update validation
the Movie class to take advantage of the built-in validation attributes Required, 
StringLength,
 RegularExpression,
 Range 
and the DataType formatting attribute.

Test attributes: or validation

https://localhost:7094/Movies/Create

Tested using Create function
Validation worked
The controller and views automatically picked up the validation rules specified by using validation attributes on the properties of the Movie model class

Tested using Edit function
model crashed?

834
20250129
Using DataType Attributes

Clean started at 8:25 AM...
1>------ Clean started: Project: MvcMovie, Configuration: Debug Any CPU ------
========== Clean: 1 succeeded, 0 failed, 0 skipped ==========
========== Clean completed at 8:25 AM and took 01.865 seconds ==========

1>MvcMovie -> C:\Users\k_cha\source\repos\MvcMovie\MvcMovie\bin\Debug\net8.0\MvcMovie.dll
========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
========== Build completed at 8:45 AM and took 11.443 seconds ==========

1009
20250129
Test & Run
Exception Handling error "cannot run on Null Data"
Update-Dabase command run in PM console
response: "The database is already up to date"
inspected database tables - updated tables and removed Null values for Rating
Test & Run
All good. Saved at the last minute.


20250205-0828
Clean started at 8:28 AM...
1>------ Clean started: Project: MvcMovie, Configuration: Debug Any CPU ------
========== Clean: 1 succeeded, 0 failed, 0 skipped ==========
========== Clean completed at 8:28 AM and took 09.214 seconds ==========Clean completed at 8:28 AM and took 09.214 seconds
8:59 Test and Run App
Ready to Push to GitHub

