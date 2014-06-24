# Muse

A simple application to manage restaurant administration based on
WinForms [C#.NET].

# Requirement

1.  Visual Studio 2012 or later
2.  .NET Framework 4.0 or later
3.  SQL Server 2012 or later
3.  NuGet Package Manager 2.8.X or later
4.  Entity Framework 6.X or later

# Getting Started

1.  Clone the respository
2.  Navigate to `Tools > Extensions and Updates` if NuGet Package Manager
    not installed on visual studio
3.  By default, visual studio will automatically download the missing package
    required by the project when you build on the first time. But in case that
    was not happen, please install it manually by navigate to
    `Tools > Nuget Package Manager > Manage NuGet Packages for Solution`
4.  For seeding database with dummy data, navigate to `Tools > NuGet Package
    Manager > Package Manager Console`. Type `Update-Database`. You need to do
    this everytime the database schema changed. In case you fail to to so,
    please remove the database from SQL Server.
