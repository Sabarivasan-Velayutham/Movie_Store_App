// using MovieStoreMvc.Models.Domain;
// using MovieStoreMvc.Repositories.Abstract;

// namespace MovieStoreMvc.Repositories.Implementation
// {
//     public class CartService : ICartService
//     {
//         private readonly DatabaseContext _ctx;

//         public CartService(DatabaseContext ctx)
//         {
//             _ctx = ctx;
//         }

//         public void AddToCart(Movie movie)
//         {
//             // Logic to add the movie to the cart
//             _ctx.Cart.Add(new CartItem { MovieId = movie.Id, Quantity = 1 });
//             _ctx.SaveChanges();
//         }
//     }
// }
