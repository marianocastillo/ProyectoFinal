using Microsoft.AspNetCore.Mvc;
using TiendaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TiendaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class SizesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SizesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("Sizes")]
        public async Task<ActionResult<IEnumerable<Sizes>>> GetSizes()
        {
            return await _context.Sizes.ToListAsync();
        }


    }


}