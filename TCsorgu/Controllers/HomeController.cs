using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using System.Diagnostics;
using TCsorgu.Models;
using static ServiceReference1.KPSPublicSoapClient;

namespace TCsorgu.Controllers
{
    public class HomeController : Controller
    {
        public bool İsControl;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Index(SearchModel search)
        {
         //  Repository.addList(search);
         if(ModelState.IsValid) 
            {
                kontrol(search);
                return View("sonuc", search);
            }
            else {
                return View(search);
            }
         
        }

        public IActionResult sonuc() 
        {
        

            return View();
        }
        public void kontrol(SearchModel searchModel) 
        {
           
            bool dogrulamaSonucu = false;
            var mernisClient = new ServiceReference1.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync(long.Parse(searchModel.TC), searchModel.Name, searchModel.surname, int.Parse(searchModel.year)).GetAwaiter().GetResult();
            dogrulamaSonucu = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
             searchModel.İsChecked = dogrulamaSonucu;
             

        }

    }
}