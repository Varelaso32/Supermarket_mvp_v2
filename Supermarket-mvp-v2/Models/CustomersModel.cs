using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp_v2.Models
{
    internal class CustomersModel
    {
        [DisplayName("ID del Cliente")]
        public int Id { get; set; }

        [DisplayName("Número de Documento")]
        [Required(ErrorMessage = "El número de documento es obligatorio")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "El número de documento debe tener entre 5 y 50 caracteres")]
        public string DocumentNumber { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres")]
        public string FirstName { get; set; }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El apellido debe tener entre 2 y 50 caracteres")]
        public string LastName { get; set; }

        [DisplayName("Dirección")]
        [Required(ErrorMessage = "La dirección es obligatoria")]
        [StringLength(100, ErrorMessage = "La dirección debe tener hasta 100 caracteres")]
        public string Address { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public string BirthDate { get; set; } 

        [DisplayName("Número de Teléfono")]
        [Required(ErrorMessage = "El número de teléfono es obligatorio")]
        [StringLength(20, ErrorMessage = "El número de teléfono debe tener hasta 20 caracteres")]
        public string PhoneNumber { get; set; }

        [DisplayName("Correo Electrónico")]
        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        [StringLength(20, ErrorMessage = "El correo electrónico debe tener hasta 20 caracteres")]
        public string Email { get; set; }
    }
}
