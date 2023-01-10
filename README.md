
<div align="center">
 
  <h1> Lang App </h1>
  
</div>


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/muhammetcagatay/VivaceAPI">
    <img src="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/screen-shot-2020-03-25-at-12-00-45-pm-1585152076.png?crop=0.990xw:0.990xh;0.00510xw,0.00510xh&resize=480:*" alt="Logo" width="400">
  </a>

  <p align="center">

  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#beginner-about-the-project">About The Project</a></li>
    <li><a href="#hammer-built-with">Built With</a></li>
    <li><a href="#electric_plug-installation">Installation</a></li>
   <li><a href="#earth_americas-endpoints">Endpoints</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## :beginner: About The Project

<div align="center">
 
 Video
 
</div>

The main idea of ​​creating this project is to create JWT Authentication system using .Net Core and React technologies.

* When the application is run, the client makes a request to the server with email and password information. If the email and password information is correct, access token and refresh token are returned to the client.
* It makes a request to an enpoint that is authorized on the server along with the client access token. If the access token is correct, the information is responded to the client.
* In case the access token expires, the client makes a request to the server with a refresh token and the server returns a new access token in return.
 




## :hammer: Built With

You can take a look at the programming languages, frameworks, databases and other tools I used while developing the project below.

* [.NET6](https://docs.microsoft.com/tr-tr/dotnet/core/introduction)
* [Entity Framework Core 6](https://docs.microsoft.com/tr-tr/ef/core/)
* [Docker](https://www.docker.com)
* [MSSQL](https://learn.microsoft.com/en-us/sql/?view=sql-server-ver16)
* [React](https://reactjs.org/)
* [Python](https://docs.python.org/3/)
* [Flask](https://flask.palletsprojects.com/en/2.2.x/)
* [Ocelot](https://github.com/ThreeMammals/Ocelot)

## :electric_plug: Installation

Follow the steps below to run the project in your local

1. Clone the repo
   ```sh
   git clone https://github.com/muhammetcagatay/lang-app.git
   ```
2. Go to project folder
   ```sh
   cd lang-app
   ```
3. Docker compose
   ```sh
   docker-compose up
   ```

## :earth_americas: Endpoints
Listening and serving API Gateway HTTP on : 5001

| Method | URL | Description |
| --- | --- | --- |
| `POST` | `/api/auth/login` | `Returns of Access Token and Refresh Token` |
| `POST` | `/api/auth/refreshToken` | `Returns of new Access Token and Refresh Token` |
| `GET - Authorize` | `/api/home` | `Returns the "Giriş Başarılı" message` |



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png

