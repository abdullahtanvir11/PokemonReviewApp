using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        public CategoryController(ICategoryRepository categoryRepository)
        {
            
        }
    }
}
