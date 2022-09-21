using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Operacao() 
    {
        return View();
    }

    public IActionResult Resultado(string operacao, double n1, double n2) 
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Operacao = operacao;

        if(operacao == "Soma")
        {
            ViewBag.Resultado = (n1 + n2);
            ViewBag.Sinal = " + "; 
        }
        else if(operacao == "Subtracao")
        {
            ViewBag.Resultado = (n1 - n2);
            ViewBag.Sinal = " - "; 
        }
        else if(operacao == "Multiplicacao")
        {
            ViewBag.Resultado = (n1 * n2);
            ViewBag.Sinal = " x "; 
        }
        else
        {
            ViewBag.Resultado = (n1 / n2);
            ViewBag.Sinal = " / "; 
        }

        return View();
    }
}