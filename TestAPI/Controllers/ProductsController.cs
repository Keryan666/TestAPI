using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAPI.Data;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("api/Produits")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Constructeur de la classe ProductsController, prend en paramètre le contexte de la base de données
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/products
        // Méthode pour obtenir la liste des produits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            // Retourne la liste des produits de la base de données
            return await _context.Products.ToListAsync();
        }

        // POST: api/products
        // Méthode pour ajouter un nouveau produit
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            // Ajoute le produit au contexte
            _context.Products.Add(product);
            // Sauvegarde les changements dans la base de données
            await _context.SaveChangesAsync();

            // Retourne le produit créé avec le code de statut 201 Created
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }

        // DELETE: api/products/{id}
        // Méthode pour supprimer un produit par son identifiant
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            // Recherche le produit par son identifiant
            var product = await _context.Products.FindAsync(id);
            // Si le produit n'existe pas, retourne le code de statut 404 Not Found
            if (product == null)
            {
                return NotFound();
            }

            // Supprime le produit du contexte
            _context.Products.Remove(product);
            // Sauvegarde les changements dans la base de données
            await _context.SaveChangesAsync();

            // Retourne le code de statut 204 No Content
            return NoContent();
        }
    }
}
