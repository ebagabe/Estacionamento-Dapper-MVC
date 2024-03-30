using System.Data;
using Dapper;
using System.Diagnostics;
using estacionamento_dapper.Models;
using Microsoft.AspNetCore.Mvc;

namespace estacionamento_dapper.Controllers;

[Route("/valores")]
public class ValorDoMinutoController : Controller
{
    private readonly IDbConnection _connection;
    public ValorDoMinutoController(IDbConnection connection)
    {
        _connection = connection;
    }
    public IActionResult Index()
    {
        var valores = _connection.Query<ValorDoMinuto>("SELECT * FROM valores_por_hora");
        return View(valores);
    }

}
