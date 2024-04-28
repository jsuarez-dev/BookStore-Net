using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Controllers;

public class AuthorController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public AuthorController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(new AuthorModel { Name = "John Doe", Country = "USA" });
    }

    public IActionResult Detail(uint id)
    {
        return View(new AuthorModel { Name = "John Doe", Country = "USA" });
    }

    public IActionResult List()
    {
        return View(new List<AuthorModel> { new AuthorModel { Name = "John Doe", Country = "USA" } });
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
