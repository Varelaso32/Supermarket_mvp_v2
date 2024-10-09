using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Supermarket_mvp_v2.Models //Samuel Varela Morales
{
    internal class ProductsModels
    {
        [DisplayName("ID del Producto")]
        public int Id { get; set; }

        [DisplayName("Nombre del Producto")]
        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre del producto debe tener entre 3 y 100 caracteres")]
        public string Name { get; set; }

        [DisplayName("Precio del Producto")]
        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        [Range(0.01, 10000, ErrorMessage = "El precio del producto debe ser mayor que cero")]
        public decimal Price { get; set; }

        [DisplayName("Stock del Producto")]
        [Required(ErrorMessage = "El stock del producto es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock del producto no puede ser negativo")]
        public int Stock { get; set; }

        [DisplayName("ID de la Categoría")]
        [Required(ErrorMessage = "El ID de la categoría es obligatorio")]
        public int CategoryId { get; set; }
    } // Fin de la clase
}