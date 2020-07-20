using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ConsultoriaIdentityRoles.Models
{
    public class Ventas
    {

        public int Id { get; set; }
        [Display(Name ="Numero de usuario")]
        public int id_usuario_Comprador { get; set; }
        [Display(Name = "Numero de producto")]
        public int id_producto { get; set; }
        [Display(Name = "Numero de desarrollador")]
        public int id_usuario_desarrollador{ get; set; }
        public DateTime FechaHora { get; set; }
        public int Total
        {
            get; set;
        }
       
    }
}