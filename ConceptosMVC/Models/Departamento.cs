using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConceptosMVC.Models {
    public class Departamento {
        [ReadOnly(true)]
        public int NumDepartamento { get; set; }
        [Required(ErrorMessage = "Nombre obligatorio")]
        public String Nombre { get; set; }
        [RegularExpression("[A-Z](3)$", ErrorMessage = "Debes introducir el nombre correctamente")]
        public String Localidad { get; set; }
    }
}