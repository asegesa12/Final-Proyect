using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProyecto.Models
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Nombre")]
        public string Nombre { get; set; }
    }
}