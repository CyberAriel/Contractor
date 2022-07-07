using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Contractor.Models;
using System.Linq;

using System.Threading.Tasks;
using Contractor.Contractors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Contractor.Controllers;

public class HomeController : Controller
{

    

    private readonly ILogger<HomeController> _logger;
    public List<int> IDList = new List<int>();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        using (var context = new ContractorsContext())
        {
            
            var model = await context.Contractors.AsNoTracking().ToListAsync();
            return View(model);
        }
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    
    public async Task<IActionResult> Create([Bind("Name,Nip,TypContractor,Activ, Desctiption")] ContractorData contractors)
    {
        using (var context = new ContractorsContext())
        {
            context.Add(contractors);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
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
   

    [HttpPost]
    public async Task<IActionResult> Edit([Bind("Name,Nip,TypContractor,Activ, Desctiption")] ContractorData contractors)
    {
        


        int id = 1;
        using (var context = new ContractorsContext())
        {
            var entity = context.Contractors.FirstOrDefault(item => item.Id == id);
            var model = await context.Contractors.AsNoTracking().ToListAsync();

            foreach (var v in model)
            {
                IDList.Add(v.Id);
            }



            if (entity != null)
            {
                entity.Name = contractors.Name;
                entity.Nip = contractors.Nip;
                entity.TypContractor = contractors.TypContractor;
                entity.Desctiption = contractors.Desctiption;
                entity.Activ = contractors.Activ;
                await context.SaveChangesAsync();
               
            }
            return RedirectToAction("Index");
        }

    }
            
     
    

    






}

