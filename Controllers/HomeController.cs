using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPets.Models;

namespace LHPets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //Instancias do tipo clientes
        Cliente cliente1 = new cliente(01, "Arthur A. Ferreira", "857.031.859-45", "artur.gomes@gmail.com", "Bethoven");
        Cliente cliente2 = new cliente(02, "Fernado Alves", "087.006.335-25", "fernandon_alves@gmail.com", "Totoi");
        Cliente cliente3 = new cliente(03, "Domingos Saboia", "010.563.224-04", "domingossaboiaoficial@gmail.com", "sabugo");
        Cliente cliente4 = new cliente(04, "Teresa Lavina Justino", "114.778.354-13", "TLavinaJus@gmail.com", "Ralph");
        Cliente cliente5 = new cliente(05, "Creatina de Sousa", "065.893.466-85", "crea.sousas@gmail.com", "tobbas");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;
        
        
        // Instancias do tipo fornecedor
        Fornecedor fornecedor1 = new fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        // lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>(); 
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores; 

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
