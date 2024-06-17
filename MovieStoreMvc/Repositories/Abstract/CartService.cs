using MovieStoreMvc.Models.Domain;
using MovieStoreMvc.Models.DTO;

namespace MovieStoreMvc.Repositories.Abstract
{
    public interface ICartService
    {
        void AddToCart(Movie movie);
        // Other methods related to cart operations can be added here
    }
}