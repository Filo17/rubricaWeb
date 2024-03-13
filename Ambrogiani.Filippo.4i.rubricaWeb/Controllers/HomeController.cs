using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ambrogiani.Filippo._4i.rubricaWeb.Models;

namespace Ambrogiani.Filippo._4i.rubricaWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        List<string> lista = new();
        lista.Add("Pecora");
        lista.Add("Sabbia");
        lista.Add("Fragole");
        return View( lista );
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
