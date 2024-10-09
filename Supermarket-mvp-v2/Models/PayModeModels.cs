using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarketmvp.Models //Samuel Varela Morales
{
    internal class PayModeModel
    {
        [DisplayName("ID del Método de Pago")]
        public int Id { get; set; }

        [DisplayName("Nombre del Método de Pago")]
        [Required(ErrorMessage = "El nombre del método de pago es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre del método de pago debe tener entre 3 y 50 caracteres")]
        public string Name { get; set; }

        [DisplayName("Observación del Método de Pago")]
        [Required(ErrorMessage = "La observación del método de pago es obligatoria")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La observación del método de pago debe tener entre 3 y 200 caracteres")]
        public string Observation { get; set; }

    }//Fin de la clase
}