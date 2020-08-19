* Layers 

DATA : Real database                   

Business: Models of your project 

Presentation: User Interface

 
* How to Create the Models for the database (Business Layer)

0.1 Create folder called 'Models' 

0.2 Create the classes and give them appropriate names 

0.3 Add fields with the mind set off a database table and add foreign keys in the appropriate class.


* How to Create the Create, Read, Update, Delete (CRUD) pages (Presentation Layer)

Add a folders under Pages that refrences the Model classes (Note: do not use the same names as the Model classes) 

1.0 right click on the newly added folder 

1.2 Hover over the "Add" button 

1.3 select the button called "New Scaffolded Item..."

1.4 Select the Model for the Scaffolded Item (Note: the Model selected must have a logical connection with the name of the folder inoder for the project to make sence)

1.5 Check the DatabaseContexts name if it suits your project 

1.6 Click on the "Add" button

1.7 Do these steps with all of the newly added folders under Pages
 

* How to Create the real database (DATA Layer)

In Visual Studio Menu Navigate To: Tools >> NuGet Packet Manager >> Packet Manager Console


* Create database 

add-migration -context MovieManagementContext

* Give Name to database 

Name: MovieDB

update-database




















