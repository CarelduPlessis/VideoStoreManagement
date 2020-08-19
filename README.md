* Layers 

DATA : Real database                   

Business: Models of your project 

Presentation: User Interface

 
* How to Create the Models for the database (Business Layer)

Create folder called 'Models' >> Create the classes and give them appropriate names 

>> Add fields with the mind set off a database table and add foreign keys in the appropriate class.


* How to Create the Create, Read, Update, Delete (CRUD) pages (Presentation Layer)

Add a folders under Pages that refrences the Model classes (Note: do not use the same names as the Model classes) 

>> right click on the newly added folder 

>> Hover over the "Add" button 

>> select the button called "New Scaffolded Item..."

>> Select the Model for the Scaffolded Item (Note: the Model selected must have a logical connection with the name of the folder inoder for the project to make sence)

>> Check the DatabaseContexts name if it suits your project 

>> Click on the "Add" button

>> Do these steps with all of the newly added folders under Pages
 

* How to Create the real database (DATA Layer)

Tools >> NuGet Packet Manager >> Packet Manager Console


* Create database 

add-migration -context MovieManagementContext

* Give Name to database 

Name: MovieDB

update-database




















