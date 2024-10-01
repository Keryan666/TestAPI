using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Models
{
    public class Product
    {
        public int Id { get; set; }        // Identifiant unique

        public required string Name { get; set; }   // Nom du produit obligatoire

        [Column(TypeName = "decimal(18, 2)")] // Limitation de l'attribut a 2 décimales
        public decimal Price { get; set; } // Prix du produit
    }
}

//Bien appliquer les changements au projet dans le terminal avec

//dotnet ef migrations "+ changement"
//dotnet ef database update


