using Microsoft.AspNetCore.Mvc;
using CatBlog.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CatBlog.Controllers
{
    public class CatController : Controller
    {
        private readonly CatBlogContext _context;

        public CatController(CatBlogContext context)
        {
            _context = context;
        }

        // 
        // GET: /cat/

        public async Task<IActionResult> Index()
        {
            var cats = await _context.Cat.ToListAsync();
            return View(cats);
        }

        [HttpPost]
        public async Task<IActionResult> Post(IFormFile catImage)
        {
            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            if (catImage.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await catImage.CopyToAsync(stream);
                }
            }

            return Ok(new { filePath });
        }
    }
}