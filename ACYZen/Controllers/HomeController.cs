using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ACYZenWEBAPP.Models;

namespace ACYZenWEBAPP.Controllers;

public class HomeController : Controller
{
    ActionYaZenContext db;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(db.ActionYaZens.ToList());
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}