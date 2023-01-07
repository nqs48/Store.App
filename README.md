# Store.App.Back
Technical challenge to evaluate the knowledge acquired in the sofka talent zone applying knowledge in the .net platform and C# programming language and Angular Framework to frontend Module


<!-- ABOUT THE PROJECT -->
## About The Project


Create a Rest service using .net it must have at least one GET and one POST . The data collection must create products using the Student model, with their respective validations.

- API (Get, Post, Put, Delete)
- Rest API with .net 
- Use Relational DtaBase SQLServer
- Used Postman for requests
- Angular for Frontend


---

## CRUD Actions


- **Get** data of products that are active and complete history.

- **Create** a new product with atributes. 

- **Update** data to old product.

- **Delete** a product for id.


---

# PROJECT REVIEW:


### UI Index Web Page

Responsive design of a dynamic web page with the available services.

![image](https://res.cloudinary.com/adev48/image/upload/v1673110364/Sofka%20Assets/Store.App/front_main_fde5tm.png)





---

## PRODUCTS LIST:

### Details of each created orduct

Detail of each product, making use of **SQL Server** to save the information associated with the product.

![image](https://res.cloudinary.com/adev48/image/upload/v1673110364/Sofka%20Assets/Store.App/products_govseg.png)

---

## Built With

This section contains the platforms that were used for the project.


### Frontend
* [JavaScript](https://developer.mozilla.org/es/docs/Web/JavaScript)
* [Local Storage](https://developer.mozilla.org/es/docs/Web/API/Window/localStorage)
* [Tailwind CSS](https://tailwindui.com/)
* [Angular Framework](https://angular.io/)


### Backend

This section contains the platforms that were used for the project.

* [Visual Studio 2022]()
* [Git](https://git-scm.com/)
* [.Net v 7.0]()
* [SQL Server]()
---

### Installation for **FrontEnd Project**

Install each one the pieces of software previously mentioned (Git).


1. Clone the repo

- HTTPS 

   ```
   $ git clone https://github.com/nqs48/Store.App.Front.git
   ```
   
 - SSH
 
   ```
   $ git clone git@github.com:nqs48/Store.App.Front.git
   ```
 
 
2. Open the project with VisualStudio Code (In the root proyect directory)

   ```
   $ code .
   ```
   
3. Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`

   ```
   ng serve -o
   ```
   
---

### Installation for **Backend Project**

Install each one the pieces of software previously mentioned (Git).


1. Clone the repo

- HTTPS
   ```
   $ git clone https://github.com/nqs48/Store.App.git
   ```


- SSH
   ```
   $ git clone git@github.com:nqs48/Store.App.git
   ```


2. Open the project with VisualStudio Code (In root directory Store.App)

   ```
   $ open .
   ```
   
   
3. Enter in the command line.

   ``` 
   $ dotnet restore 
     
   ```
   
   ``` 
   $ dotnet build 
     
   ```
   
4. Go to project Store.App.Infrastructura

  - Migration Maping (From Infrastructura to Enter Point)
  
     ```
     $ dotnet ef migrations add Inicial --startup-project ../Store.App.Api

     ```
   
  - Migration to Data Base (From Infrastructura to Enter Point)
   
     ```
     $ dotnet ef database update --startup-project ../Store.App.Api

     ```

   
5. Run the Api (In directory Store.App.Api)

   ```
   $ dotnet run
   
   ``` 
  
---

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

---

<!-- CONTACT -->
## Collaborators
```
Nestor Quiroga Suarez
Jr. Software Developer

```
<p align="center">
<br>
<a href="https://www.linkedin.com/in/nqs48/"><img src="https://img.shields.io/badge/linkedin-%230077B5.svg?&style=for-the-badge&logo=linkedin&logoColor=white" alt="LinkedIn" /></a>&nbsp;&nbsp;
<a href="https://api.whatsapp.com/send/?phone=573102095353&text=Hola+Nestea%2C+vi+tu+perfil+de+github+y+me+encanto+el+trabajo+que+haces%21%21&type=phone_number&app_absent=0"><img src="https://img.shields.io/badge/what's app-2d572c?style=for-the-badge&logo=whatsapp" alt="whats app" /></a>&nbsp;&nbsp;
<a href="https://www.instagram.com/nqs48/"><img src="https://img.shields.io/badge/instagram-white?style=for-the-badge&logo=instagram" alt="Instagram"/>&nbsp;&nbsp;
<a href="mailto:nqs48@hotmail.com"><img src="https://img.shields.io/badge/outlook-blue?&style=for-the-badge&logo=microsoft-outlook&logoColor=white" alt="outlook"/></a>
</a>
</p>
<br>
<p align='center'>
  <a href="#top"><img src="https://img.shields.io/badge/Back to Top-black?" alt="back to top"/></a>
</p>

