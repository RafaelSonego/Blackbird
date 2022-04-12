using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using blackbird.web.Models;

namespace blackbird.web.Controllers;

public class UserProfileController : Controller
{
    private readonly ILogger<UserProfileController> _logger;

    public UserProfileController(ILogger<UserProfileController> logger)
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
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
