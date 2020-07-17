using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsultoriaIdentityRoles.Models
{
    public class ReunionesModels
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string Compania { get; set; }
        public DateTime FechaHora { get; set; }
        public string Razon { get; set; }
    
    }
}