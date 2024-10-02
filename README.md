# Mon Projet API

## Description
Ce projet est une API construite avec ASP.NET Core, utilisant Entity Framework Core pour interagir avec une base de données MySQL. Suivez les instructions ci-dessous pour configurer et exécuter le projet sur votre machine.

## Prérequis

Avant de commencer, assurez-vous d'avoir les éléments suivants installés :
1. Visual Studio 2022 : Version complète.
2. .NET SDK : Assurez-vous que le SDK .NET 8 est installé.
3. MySQL : Installez MySQL Server pour vos bases de données.
4. Entity Framework Core : Utilisé pour interagir avec la base de données.

## Installation
dotnet new webapi -n TestAPI


Pour installer les dépendances nécessaires, ouvrez votre terminal et exécutez les commandes suivantes :
- dotnet add package Pomelo.EntityFrameworkCore.MySql
- dotnet add package Microsoft.EntityFrameworkCore.Design

### Création de la base de données

Pour initialiser la base de données, exécutez les commandes suivantes :
- dotnet ef migrations add InitialCreate
- dotnet ef database update

## Configuration

Modifiez le fichier appsettings.json pour y inclure les bonnes informations de connexion pour MySQL. Exemple de configuration :
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=your_port;Database=your_db;User=your_user;Password=your_password;"
  }
}
