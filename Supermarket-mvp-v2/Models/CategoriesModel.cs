using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp_v2.Models
{
    internal class CategoriesModel
    {
        [DisplayName("ID de la Categoría")]
        public int Id { get; set; }

        [DisplayName("Nombre de la Categoría")]
        [Required(ErrorMessage = "El nombre de la categoría es obligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre de la categoría debe tener entre 2 y 50 caracteres")]
        public string Name { get; set; }

        [DisplayName("Descripción de la Categoría")]
        [Required(ErrorMessage = "La descripción de la categoría es obligatoria")]
        [StringLength(100, ErrorMessage = "La descripción debe tener hasta 100 caracteres")]
        public string Description { get; set; }
    }
}
