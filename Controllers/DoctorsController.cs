using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class doctorsController : Controller
    {
        private readonly HospitalContext _context;
        public doctorsController(HospitalContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context);
        }
    }
}
