using ConceptosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConceptosMVC.Controllers {
    public class ContenidosController : Controller {
        // GET: Index
        public ActionResult Index() {
            return View();
        }
        /*_____________________________________________*/
        public ActionResult ContenidoContent() {
            return View();
        }
        /*_____________________________________________*/
        [HttpPost]
        public ActionResult ContenidoContent(String video) {
            int posicion = video.IndexOf("v=");
            String idvideo = video.Substring(posicion + 2);
            return Content("<iframe width='560' height='315' src = 'https://www.youtube.com/embed/" + idvideo + "' frameborder = '0' allowfullscreen ></ iframe > ");
            //return View();
        }
        /*_____________________________________________*/
        //GET: ContenidoJavScript
        public ActionResult ContenidoJavaScript() {
            return View();
        }
        /*_____________________________________________*/
        public ActionResult CodigoJavaScript() {
            //Devolvemos el contenido mediante un Script de JavaScript
            String imagen = Url.Content("~/Images/2.jpg");
            String script = "$('#imagen').attr('src', '" + imagen + "');";
            return JavaScript(script);
        }
        /*_____________________________________________*/
        public ActionResult ContenidoFile(){
            String path = Url.Content("~/Images/1.png");
            return File(path, "image/png");
            }
        /*_____________________________________________*/
        public ActionResult ContenidoJson() {
            Personaje p = new Personaje();
            p.Nombre = "Juan";
            p.Apellido = "Bou";
            p.Profesion = "Jefe de Microsoft";
            return Json(p, JsonRequestBehavior.AllowGet);
        }
        /*_____________________________________________*/
    }
}