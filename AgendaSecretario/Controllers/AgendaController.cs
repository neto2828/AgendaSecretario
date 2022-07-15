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

        //GET Agenda/Export
        public ActionResult Export()
        {
            var agenda = db.GetAllAgenda()
; return View(agenda);
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
                    AgendaEstatus = collection["AgendaEstatus"],
                    AgendaTitulo = collection["AgendaTitulo"],
                    AgendaMunicipio = collection["AgendaMunicipio"],
                    AgendaFecha = collection["AgendaFecha"],
                    AgendaUrl = collection["AgendaUrl"],
                    AgendaCuenta = collection["AgendaCuenta"],
                    AgendaPost = collection["AgendaPost"],
                    AgendaEmbedded = "https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2F" + collection["AgendaCuenta"] + "%2Fposts%2F" + collection["AgendaPost"] + "&width=500&show_text=true&height=505&appId"

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

        // GET: AgendaController/Delete/5
        public ActionResult Delete(string id)
        {
            var agenda = db.GetAgendaById(id);
            return View(agenda);
        }

        // POST: AgendaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                db.DeleteAgenda(id);
                TempData["delete"] = "El registro " + "se ha eliminado con Éxito";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["danger"] = "El registro " + "no se pudo guardar, intentelo de nuevo";
                return View();
            }
        }

        // GET: AgendaController/Publicado/5
        public ActionResult Publicado(string id)
        {
            var agenda = db.GetAgendaById(id);
            return View(agenda);
        }

        // POST: AgendaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Publicado(string id, IFormCollection collection)
        {
            try
            {
                db.PublishAgenda(id);
                TempData["success"] = "El registro " + "se ha publicado con Éxito";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["danger"] = "El registro " + "no se pudo publicar, intentelo de nuevo";
                return View();
            }
        }
    }
}

