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
            var agenda = db.GetAllAgenda()
;            return View(agenda);
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
                    AgendaFecha = collection["AgendaFecha"],
                    AgendaUrl = collection["AgendaUrl"],
                    AgendaCuenta = collection["AgendaCuenta"]

                };

                db.InsertAgenda(agenda);
                TempData["success"] = "El Registro " + "se ha guardado con Éxito";
                return RedirectToAction(nameof(Create));
            }

            catch
            {
                TempData["danger"] = "El registro " + "no se pudo guardar, intentelo de nuevo";
                return View();
            }
        }
    }
}

