# Factory Engineer Management

#### By **Cameron Ray**

#### A factory management solution for seeing engineers' machine certifications

## Technologies Used

* C#
* .NET 5.0
* ASP.Net Core
* Entity Framework Core
* Razor
* MySQL
* HTML
* CSS

## Description

Example of many-to-many relationship for engineers in a factory with different certifications to machines. The relationships between engineers and machines can be modified or deleted. The classes have full CRUD functionality.

## Setup/Installation Requirements

* Requires MySQL for the database
* Clone the repository
* navigate to Factory.Solution
* Create an appsettings.json file in the root of the Factory folder.
```
$ cd Factory/
$ touch appsettings.json
```
* Add the following to the appsettings.json file with the bracketed username and password replaced with your mysql username and password.
```JSON
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=cameron_ray;uid=[username];pwd=[password];"
  }
}
```
* restore and build the project
```
$ dotnet restore
$ dotnet build
```
* import the database located in the root of Factory.Solution using MySQL Workbench. 
1. From the Navigator section click the Administration tab at the bottom of the section.
2. Click Data Import/Restore and select "Import from Self-Contained File."
3. select the path to import from. In this case it should be the clonedlocation/Factory.Solution/cameron_ray.sql

* alternatively run the following command in the terminal to build a database for running the app.
```
$ dotnet ef database update
```
* start the project fomr the Factory directory using
```
$ dotnet run
```
* open `http://localhost:5000` in the browser to try it out.

## Known Bugs
* No known bugs, feel free to contact me here if any are found.

## License

[MIT](LICENSE)

Copyright (c) May 2022 Cameron Ray