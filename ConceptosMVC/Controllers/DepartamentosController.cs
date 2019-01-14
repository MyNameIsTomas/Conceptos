using ConceptosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConceptosMVC.Controllers {
    public class DepartamentosController : Controller {
        HelperDepartamentos helper;
        public DepartamentosController() {
            this.helper = new HelperDepartamentos();
        }
        /*_____________________________________________*/
        // GET: Index
        public ActionResult Index() {
            return View();
        }
        /*_____________________________________________*/
        public ActionResult InsertarDepartamento() {
            DEPT dept = new DEPT();
            dept.DEPT_NO = this.helper.GetMaximoDepartamento();
            return View(dept);
        }
        [HttpPost]
        public ActionResult InsertarDepartamento(DEPT departamento) {
            departamento.DEPT_NO = this.helper.GetMaximoDepartamento();
            if (ModelState.IsValid) {
                this.helper.InsertarDepartamento(departamento);
                return View("Index");
            }
            return View(departamento);
        }
        /*_____________________________________________*/
        public ActionResult ModificarDepartamento() {
            return View();
        }
        /*_____________________________________________*/

    }
}