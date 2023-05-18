using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AmaZon.Models;
using System.Text.Encodings.Web;


namespace AmaZon.Controllers;

public class PaisController : Controller
{
    // private readonly ILogger<PaisController> _logger;

    // public PaisController(ILogger<PaisController> logger)
    // {
    //     _logger = logger;
    // }

    public IActionResult Index()
    {
        var paises = _context.DataPaises.ToList();
        // return "L";
        return View(paises);
    }

    // [HttpPut("{id}")]
    // public IActionResult UpdatePais()
    // {
    //     // return View();
    // }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
}
