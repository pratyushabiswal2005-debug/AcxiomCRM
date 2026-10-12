using Microsoft.AspNetCore.Mvc;
using AcxiomCRM.Models;
using DiagActivity = System.Diagnostics.Activity;

namespace AcxiomCRM.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = DiagActivity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}