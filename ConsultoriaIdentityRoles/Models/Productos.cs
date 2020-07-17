using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsultoriaIdentityRoles.Models
{
    public class Productos
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int id_desarrollador { get; set; }
        public string descripcion { get; set; }
        public string Caracteristicas
        {
            get; set;
        }
        public DateTime FechaHora { get; set; }
        public string Imagen { get; set; }
    }
}