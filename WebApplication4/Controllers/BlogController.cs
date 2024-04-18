using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class BlogController : Controller
    {

        public BlogController()
        {
        }
        public IActionResult Index()
        {
            BlogContext blogContext = new BlogContext();
            var blogs = blogContext.Blogs.ToList();
            return View(blogs);
        }
    }
}
