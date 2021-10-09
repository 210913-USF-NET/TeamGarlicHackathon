using Hackathon1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Models;

namespace Hackathon1.Controllers
{
    public class HomeController : Controller
    {

        private IBL _bl;
        public HomeController(IBL bl)
        {
            _bl = bl;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("inside home controller index");
            List<ModelVideo> allvids = _bl.GetVideos();
            List<string> vids = new List<string>();
            foreach (ModelVideo vid in allvids)
            {
                vids.Add(vid.Vid);
            }
            System.Diagnostics.Debug.WriteLine("inside home controller list of vid strings created");
            for(int i = 0; i < vids.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine($"vid {i} is {vids[i]}");
            }

            string videoplay = _bl.GetId(_bl.RandomString(vids));
            @ViewData["Link"] = videoplay;
            
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
}
