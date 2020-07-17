using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ConsultoriaIdentityRoles.Models
{
    public class ReunionesModel
    {
        [Display(Name = "identificador")]
        public int id { get; set; }

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Compania { get; set; }
        public DateTime FechaHora { get; set; }
        public string Razon { get; set; }
    }
}