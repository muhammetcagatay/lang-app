
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
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## :beginner: About The Project

<div align="center">
 
 Video
 
</div>

Developed a foreign language learning application using microservices architecture and the latest technologies such as .NET 6, React and MSSQL. The application is composed of 6 different services:

* AuthServer service: Its purpose is to distribute tokens to users for authentication.
* User service: Its purpose is to create new users and manage their profiles.
* Vocabulary service: This service allows users to create custom vocabulary courses and track their progress.
* Score service: This service keeps track of users' scores and performance in the different vocabulary courses
* Speaking service: This service uses speech recognition to evaluate users' pronunciation and provide feedback on the number of correct and incorrect words.
* Speech Recognition service: This service using Python that converts spoken words from audio files into textutilizes advanced speech-to-text algorithms to accurately transcribe the spoken words into written text. 


This application offers an interactive and personalized way for users to learn a new language, by creating custom vocabulary courses and tracking their progress through scores and speech recognition. The use of microservices architecture allows for a more scalable and maintainable solution, while the use of .NET 6, React, and MSSQL ensure a high performance and secure application.

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
   docker compose  up -d --build
   ```
4. Open new terminal and install packages
   ```sh
   cd lang-ui
   npm install --force
   ```
5. run client
   ```sh
   npm start
   ```




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

