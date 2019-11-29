using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProyecto.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Codigo")]
        public int codigo { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Nombre")]
        public string Nombre { get; set; }
    }
}