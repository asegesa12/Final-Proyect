using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProyecto.Models
{
    public class Empleados
    {
        [Key]
        public int Id { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Codigo")]
        public int Codigo { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Telefono")]
        public string Telefono { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Departamento")]
        public string Departamento { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Cargo")]
        public string Cargo { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Salario")]
        public int Salario { get; set; }
        [ Required(ErrorMessage = "Campo Requerido"), Display(Name = "Estatus")]
        public string Estatus { get; set; }


        public virtual Departamento dpto { get; set; }
        public virtual Cargo Crg { get; set; }
    }
}