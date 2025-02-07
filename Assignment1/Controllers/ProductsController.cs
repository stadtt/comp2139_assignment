using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers;

public class ProductsController : Controller
{

    private readonly ApplicationDbContext _context;
    public ProductsController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Index(string searchString)
    {
        var inventory = _context.Products.Include(p => p.Category).ToList();
        return View(inventory);
    }

    public IActionResult Index()
    {
        return View();
    }
}