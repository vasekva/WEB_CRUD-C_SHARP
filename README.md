# Web implementation of the system C.R.U.D with MVC template

---
## Technologies and resources used:

* Windows 7
* VisualStudio 2019
* SQL Server Express LocalDB
- EntityFramework 6.4.4
- Microsoft.EntityFrameworkCore.SqlServer 5.0.8
- Microsoft.EntityFrameworkCore.Tools 5.0.8
- Microsoft.VisualStudio.Web.CodeGeneration.Design 5.0.2

![mainpage_image](./WEB_CRUD/MD_Files/MainPage.png)

<h2>Necessary steps to start a project:</h2>

<h1>Before starting, check if all the necessary frameworks are installed!</h1>
   Pay attention! I recommend using ***VisualStudio*** because
   the EntityFrameworkCore.SqlServer extension and the 'SQLServer Object Explorer'
   allow you to conveniently view and delete the database
<h5>
   The project uses SQL Server Express LocalDB.
</h5>
<h5>
   By default, LocalDB creates MDF database files in the C: / Users / <user> directory.
</h5>

<h3>Don't forget to delete!!!</h3>

---

1. `git clone` the project from the current page
```
    $ git clone https://github.com/vasekva/WEB_CRUD-C_SHARP.git <directory_name>
```
    
---
2. Open the project with **VisualStudio** or **JetBrains Rider** :
   1. ***VisualStudio:***
    
      ![firstStep_image](./WEB_CRUD/MD_Files/VS_FirstStep.png)
    
      - After loading the project open "Solution Explorer"
    
      ![secondStep_image](./WEB_CRUD/MD_Files/VS_SecondStep.png)
    
      - Double left click on WEB_CRUD.sln
    
      ![secondStep01_image](./WEB_CRUD/MD_Files/VS_SecondStep_01.png)
    
      - In the changed window, start the program by clicking on the start button using IIS Express
    
      ![secondStep02_image](./WEB_CRUD/MD_Files/VS_SecondStep_02.png)
    
      - Oh... one more thing, be sure to check that you have selected the browser to run the application :)
    
      ![secondStep03_image](./WEB_CRUD/MD_Files/VS_SecondStep_03.png)
    
      - After building the project, the browser will automatically open with the main page you need.
      </br></br>
   2. ***JetBrains Rider:***
      - After loading the project, just click on the start button at the top, or press Shift + F10
      
      ![firstStep_image](./WEB_CRUD/MD_Files/Rider_FirstStep.png)
      
      - After building the project, the browser will automatically open with the main page you need.

---
3. In the header of the page, you can see two links - Projects and Tasks.
   Each of them redirects to the editing page of the corresponding table, where its contents are displayed
   and entities can be created, updated and deleted. More details about the functionality in a [separate page](./WEB_CRUD/MD_Files/CRUD_Pages.md)
   
   ![thirdStep_image](./WEB_CRUD/MD_Files/ThirdStep.png)

---
