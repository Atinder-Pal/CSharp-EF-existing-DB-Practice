# c-review-oop-practice---entity-framework-existing-database-Atinder-Pal

**Purpose:** This practice is designed to get familiarization with the fundamentals of importing a database to C# using Entity Framework. This scenario is intended for when you would like to build your database first, then build your C# server later. 

**Author:** Atinder Pal

**Requirements:**
* Create a new database in PHPMyAdmin called “existing_db_practice”.
  * Run the SQL script at the bottom of this spec on “existing_db_practice”.
  * This database will have two tables:
    * Person
      * ID (PK)
      * FirstName
      *LastName
    * PhoneNumber
      * ID (PK)
      * Number
      * PersonID (FK)

* Create a new console application in Visual Studio called “ExistingDBPractice”.
  * Add the “Pomelo.EntityFrameworkCore.MySql” package.
  * Use the package manager console to generate C# models and a “PersonContext” based on the “existing_db_practice” database.
    * Package Manager Console is a specialized console that may not run all the same commands as Command Prompt or Terminal
    * Tools > NuGet Package Manager > Package Manager Console
    
* Write a program that will:
  * Take in a first name from the user
    * Case insensitive
    * Trimmed
  * Then print the full name of that user from the database
  * If the name is not in the database then output “Name not found.” and exit.
  
  **Challenges:**
  * If the name is not in the database, keep prompting until they enter a name that is, or until they enter “quit” (case insensitive).
  * Also print the person’s phone number(s) based on their first name.
  * Research Code First Migrations
    * Add an “EmailAddress” table to the models in C#
    * Push the “EmailAddress” table update to the database.
    * Research  Data Seeding - EF and add an email address for each person
    * Push the email addresses in an update to the database.
    
  **Link to Trello Board:** https://trello.com/b/25vNBcCc/entity-framework-solution-setup-from-existing-database


