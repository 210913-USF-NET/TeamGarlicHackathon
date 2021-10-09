using BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon1.Controllers
{
    public class VideoController : Controller
    {
        private IBL _bl;
        public VideoController(IBL bl)
        {
            _bl = bl;
        }
        // GET: VideoController
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("inside video controller index");
            List<ModelVideo> allvids = _bl.GetVideos();
            List<string> vids = new List<string>();
            foreach (ModelVideo vid in allvids)
            {
                vids.Add(vid.Vid);
            }
            System.Diagnostics.Debug.WriteLine("inside video controller list of vid strings created");
            for (int i = 0; i < vids.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine($"vid {i} is {vids[i]}");
            }

            string videoplay = _bl.GetId(_bl.RandomString(vids));
            @ViewData["Link"] = videoplay;

            return View();
        }

        // GET: VideoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VideoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VideoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VideoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VideoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
