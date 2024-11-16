using Dot_Net_MinimalAPI_Demo.Interfaces;
using Dot_Net_MinimalAPI_Demo.Models;

namespace Dot_Net_MinimalAPI_Demo.Endpoints
{
    public static class ProductEndpoints
    {
        public static void RegisterProductEndpoints(this WebApplication app)
        {
            // GET all products
            app.MapGet("api/products", async (IProductService _productService) =>
            {
                return Results.Ok(await _productService.GetProductsAsync());
            });

            // GET product by id
            app.MapGet("api/products/{id}", async (int id, IProductService _productService) =>
            {
                return Results.Ok(await _productService.GetProductByIdAsync(id));
            });

            // POST new product
            app.MapPost("api/products", async (Product product, IProductService _productService) =>
             {
                 return Results.Ok(await _productService.AddProductAsync(product));
             });

            // PUT update product
            app.MapPut("api/products", async (Product product, IProductService _productService) =>
            {
                return Results.Ok(await _productService.UpdateProductAsync(product));
            });

            // DELETE product
            app.MapDelete("api/products/{id}", async (int id, IProductService _productService) =>
            {
                return Results.Ok(await _productService.RemoveProductAsync(id));
            });
        }
    }
}
