using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ConsultoriaIdentityRoles.Models
{
    public class Productos
    {
        [Key, Required]
        public int Id { get; set; }
        [Required, Display(Name = "Nombre del Proyecto")]
        public string Nombre { get; set; }
        public int Precio { get; set; }
        [Required,Display(Name = "Nombre del desarrollador")]
        public int id_desarrollador { get; set; }
        public string descripcion { get; set; }
        public string Caracteristicas
        {
            get; set;
        }
        [Display(Name ="Fecha y hora de su creación")]
        public DateTime FechaHora { get; set; }
        public string Imagen { get; set; }
    }
}