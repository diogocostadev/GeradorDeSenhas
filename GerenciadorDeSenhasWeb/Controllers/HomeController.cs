using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GerenciadorDeSenhasWeb.Models;

namespace GerenciadorDeSenhasWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        GerenciadorDeSenhas.Gerenciador gerenciador = new GerenciadorDeSenhas.Gerenciador();
        string senha = gerenciador.GerarSenha(10, true, true, true);
        gerenciador.SalvarSenha(senha);
        
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
