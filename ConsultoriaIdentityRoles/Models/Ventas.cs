using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsultoriaIdentityRoles.Models
{
    public class Ventas
    {
        public int Id { get; set; }

        public int id_usuario_Comprador { get; set; }
        public int id_producto { get; set; }
        public int id_usuario_desarrollador{ get; set; }
        public DateTime FechaHora { get; set; }
        public int Total
        {
            get; set;
        }
       
    }
}