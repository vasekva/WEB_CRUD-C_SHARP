# Web implementation of the system C.R.U.D with MVC template

---
## Technologies and resources used:

* Windows 7
* VisualStudio 2019
- EntityFramework 6.4.4
- Microsoft.EntityFrameworkCore.SqlServer 5.0.8
- Microsoft.EntityFrameworkCore.Tools 5.0.8
- Microsoft.VisualStudio.Web.CodeGeneration.Design 5.0.2

![mainpage_image](./WEB_CRUD/MD_Files/MainPage.png)

<h2>Necessary steps to start a project:<h2/>

---

1. `git clone` the project from the current page
```
    $ git clone https://github.com/vasekva/WEB_CRUD-C_SHARP.git <directory_name>
```
</br>
    
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

</br>
---
3. In the header of the page, you can see two links - Projects and Tasks.
   Each of them redirects to the editing page of the corresponding table, where its contents are displayed
   and entities can be created, updated and deleted. More details about the functionality in a [separate page](./WEB_CRUD/MD_Files/CRUD_Pages.md)
   
   ![thirdStep_image](./WEB_CRUD/MD_Files/ThirdStep.png)

---
