using Microsoft.AspNetCore.Mvc;
using TCsorgu.Models;

namespace TCsorgu.Controllers
{
    public class SearchController: Controller
    {

        public IActionResult Index() 
        {
        
           SearchModel model = new SearchModel();



            return View();
        
        }


    }
}
