using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        public IActionResult Results(string searchType, string searchTerm)
        {
            //Need to take data in and pass into ViewBag.jobs
            /*searchTerm = Request.Form["searchTerm"];
            searchType = Request.Form["searchType"];*/
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);

            return View("Index");
            //searchTerm and searchType
        }
        // TODO #1 - Create a Results action method to process 
        // search request and display results

    }
}
