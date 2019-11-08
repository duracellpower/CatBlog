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


        public async Task<IActionResult> Index()
        {
            var cats = await _context.Cat.ToListAsync();
            return View(cats);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Cat newCat)
        {
            _context.Cat.Add(newCat);
            await _context.SaveChangesAsync();
            return Redirect("/");
        }

        [HttpDelete("/cat/delete/{catId}")]
        public async Task<IActionResult> Delete(int catId) {
            var catToRemove = await _context.Cat.FindAsync(catId);
            _context.Cat.Remove(catToRemove);
            await _context.SaveChangesAsync();
            return Redirect("/");
        }
    }
}