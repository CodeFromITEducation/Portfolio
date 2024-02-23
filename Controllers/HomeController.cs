using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CSharp()
        {
            return View();
        }
        public IActionResult Java()
        {
            return View();
        }
        public IActionResult JavaScript()
        {
            return View();
        }
        public IActionResult tic()
        {
            return View();
        }
        public ActionResult Diary()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = @"C:\Users\Owner\source\repos\SQLiteDiaryWFA\bin\Debug\net8.0-windows7.0\SQLiteDiaryWFA.exe",
                UseShellExecute = true
            };
            Process process = Process.Start(startInfo);
            return RedirectToAction("CSharp");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
