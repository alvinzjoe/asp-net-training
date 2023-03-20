using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetcoreTraining.Models;
using NetcoreTraining.Services;

namespace NetcoreTraining.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public JsonFileProductService ProductService;
    public IEnumerable<Product> Products { get; private set; }

    public HomeController(ILogger<HomeController> logger, JsonFileProductService productService)
    {
        _logger = logger;
        ProductService = productService;
    }

    public IActionResult Index()
    {
        Products = ProductService.GetProducts();
        ViewBag.Products = Products;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

