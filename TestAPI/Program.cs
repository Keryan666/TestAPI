using Microsoft.EntityFrameworkCore;
using TestAPI.Data;

var builder = WebApplication.CreateBuilder(args); // Crée un constructeur d'application web avec les arguments de ligne de commande

// Ajoute le DbContext avec la chaîne de connexion
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), // Utilise la chaîne de connexion définie dans la configuration
    new MySqlServerVersion(new Version(8, 0, 23)))); // Spécifie la version du serveur MySQL

builder.Services.AddControllers(); // Ajoute les services de contrôleurs du MVC

var app = builder.Build(); // Construit l'application web

// Configure le pipeline HTTP
app.UseAuthorization(); // Ajoute la middleware d'autorisation
app.MapControllers(); // Mappe les routes des contrôleurs

app.Run(); // Démarre l'application
