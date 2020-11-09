using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace miblog.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Debes ingresar un nombre para la categoria.")]
        [Display(Name = "Nombre categoría")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debes ingresar una orden de visualización.")]
        [Display(Name = "Orden de visualización")]
        public int? Orden { get; set; }
    }
}
