# Store.App
Technical challenge to evaluate the knowledge acquired in the sofka talent zone applying knowledge in the .net platform and C# programming language


<!-- ABOUT THE PROJECT -->
## About The Project


Create a Rest service using .net it must have at least one GET and one POST . The data collection must create products using the Student model, with their respective validations.

- API (Get, Post, Put, Delete)
- Rest API with .net 
- Use Relational DtaBase SQLServer
- Used Postman for requests


---

## CRUD Actions


- **Get** data of products that are active and complete history.

- **Create** a new product with atributes. 

- **Update** data to old product.

- **Delete** a product for id.


---



## Built With

This section contains the platforms that were used for the project.

* [Visual Studio 2022]()
* [Git](https://git-scm.com/)
* [.Net v 7.0]()
* [SQL Server]()


### Installation

Install each one the pieces of software previously mentioned.


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
Jr. FrontEnd Developer

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

