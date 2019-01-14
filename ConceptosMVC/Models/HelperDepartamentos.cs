using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConceptosMVC.Models {
    public class HelperDepartamentos {
        EntidadHospital entidad;
        public HelperDepartamentos() {
            this.entidad = new EntidadHospital();
        }
        public int GetMaximoDepartamento() {
            int valor =(int) this.entidad.MaximoDepartamento().FirstOrDefault();
            valor = valor + 10;
            return valor;
        }
        public void InsertarDepartamento(DEPT departamento) {
            this.entidad.DEPT.Add(departamento);
            this.entidad.SaveChanges();
        }
    }
}