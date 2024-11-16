using Dot_Net_MinimalAPI_Demo.Helper;
using Dot_Net_MinimalAPI_Demo.Models;

namespace Dot_Net_MinimalAPI_Demo.Interface
{
    public interface IProductService
    {
        Task<Response> GetProductsAsync();
        Task<Response> GetProductByIdAsync(int Id);
        Task<Response> AddProductAsync(Product product);
        Task<Response> UpdateProductAsync(Product product);
        Task<Response> RemoveProductAsync(int Id);
    }
}
