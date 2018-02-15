using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using restauranter.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace restauranter.Controllers
{
    public class HomeController : Controller
    {
        private ReviewContext _context;

        public HomeController ([FromServices]ReviewContext context) {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("addreview")]

        public IActionResult AddReview(Review review){
            _context.reviews.Add(review);
            _context.SaveChanges();
            return RedirectToAction("AllReviews");
        }

        [HttpGet]
        [Route("reviews")]
        public IActionResult AllReviews(){
            var reviews=_context.reviews.Where(review=>review.id!=0).ToList();
            Console.WriteLine("*************"+reviews);
            ViewBag.reviews=reviews;
            return View("Reviews");
        }
    }
}
