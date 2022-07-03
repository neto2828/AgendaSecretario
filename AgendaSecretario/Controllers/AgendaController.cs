using System;
using AgendaSecretario.Class;
using AgendaSecretario.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace AgendaSecretario.Controllers


{
    public class AgendaController : Controller
    {
        private IAgendaCollection db = new AgendaCollection();
        //GET Agenda
        public ActionResult Index()
        {
            return View();
        }

        //GET Datails
        public ActionResult Details()
        {
            return View();
        }

        //GET Create
        public ActionResult Create()
        {
            return View();
        }

        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        //GET Agenda
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var agenda = new Agenda()
                {
                    AgendaTitulo = collection["AgendaTitulo"],
                    AgendaMunicipio = collection["AgendaMunicipio"],
                    AgendaFecha = DateTime.Parse(collection["AgendaFecha"]),
                    AgendaUrl = collection["AgendaUrl"]

                };

                db.InsertAgenda(agenda);
                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View();
            }
        }
    }
}

