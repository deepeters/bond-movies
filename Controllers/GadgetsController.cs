using BondMovies.Data;
using BondMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BondMovies.Controllers
{
    public class GadgetsController : Controller
    {
        // GET: Gadgets
        public ActionResult Index()
        {
            List<GadgetModel> gadgets = new List<GadgetModel>();
            GadgetDAO gadgetDAO = new GadgetDAO();
            gadgets = gadgetDAO.FetchAll();

            return View("Index", gadgets);
        }

        public ActionResult Details(int id)
        {
            GadgetDAO gadgetDAO = new GadgetDAO();
            GadgetModel gadget = gadgetDAO.FetchOne(id);

            return View("Details", gadget);
        }

        public ActionResult Create()
        {
            return View("GadgetForm");
        }

        public ActionResult Edit(int id)
        {
            GadgetDAO gadgetDAO = new GadgetDAO();
            GadgetModel gadget = gadgetDAO.FetchOne(id);
            return View("GadgetForm", gadget);
        }

        [HttpPost]
        public ActionResult ProcessCreate(GadgetModel gadgetModel)
        {
            //Save to DB
            GadgetDAO gadgetDAO = new GadgetDAO();
            gadgetDAO.CreateOrUpdate(gadgetModel);

            return View("Details", gadgetModel);
        }
    }
}