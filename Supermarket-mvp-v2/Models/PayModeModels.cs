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
        [DisplayName("Pay Mode Id")]
        public int Id { get; set; }

        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay Mode name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay Mode name must be between 3 and 50  characters")]
        public string Name { get; set; }

        [DisplayName("Pay Mode Observartion")]
        [Required(ErrorMessage = "Pay Mode observation is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay Mode observation must be between 3 and 200  characters")]
        public string Observation { get; set; }

    }//Fin de la clase
}