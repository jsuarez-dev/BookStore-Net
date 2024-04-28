using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using BookStore.Data;

namespace BookStore.Controllers;

public class HomeController : Controller
{
    private readonly BookStoreContext _context;

    public HomeController(BookStoreContext context)
    {
        _context = context;
    }

    public async Task<ActionResult> Index()
    {
        var authors = await _context.Author.ToListAsync();
        authors.ForEach(a => a.Books = _context.Book.Where(b => b.AuthorId == a.Id).ToList());
        return View(authors);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
