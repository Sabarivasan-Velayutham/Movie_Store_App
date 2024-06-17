using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Repositories.Abstract;

namespace MovieStoreMvc.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IMovieService _movieService;

        public CartController(ICartService cartService, IMovieService movieService)
        {
            _cartService = cartService;
            _movieService = movieService;
        }

        [HttpPost]
        public IActionResult AddToCart(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            if (movie != null)
            {
                _cartService.AddToCart(movie);
                TempData["msg"] = "Movie added to cart successfully";
            }
            else
            {
                TempData["msg"] = "Movie not found";
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
