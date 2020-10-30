using System;

namespace EntityFramework_4Point2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Step 1: Create Models folder.
            Step 2: Create context class, and any required model classes.
            Step 3: Per Class:
                Step 3a: Name the table for the model class.
                Step 3b: Declare primary key property.
                Step 3c: Specify other columns.
            Step 4: Setup Context:
                Step 4a: Inherit from DbContext.
                Step 4b: Declare table DbSets.
                Step 4c: Implement OnConfiguring with connection string.
                Step 4d: Implement OnModelCreating with string collation and foreign keys.
            Step 5: Create a migration using "dotnet ef migrations add InitialMigration" in Package Manager Console (in the project folder).
            */
        }
    }
}
