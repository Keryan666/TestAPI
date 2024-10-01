using Microsoft.EntityFrameworkCore;
using TestAPI.Data;

var builder = WebApplication.CreateBuilder(args); // Cr�e un constructeur d'application web avec les arguments de ligne de commande

// Ajoute le DbContext avec la cha�ne de connexion
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), // Utilise la cha�ne de connexion d�finie dans la configuration
    new MySqlServerVersion(new Version(8, 0, 23)))); // Sp�cifie la version du serveur MySQL

builder.Services.AddControllers(); // Ajoute les services de contr�leurs du MVC

var app = builder.Build(); // Construit l'application web

// Configure le pipeline HTTP
app.UseAuthorization(); // Ajoute la middleware d'autorisation
app.MapControllers(); // Mappe les routes des contr�leurs

app.Run(); // D�marre l'application
