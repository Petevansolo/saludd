using System.ComponentModel.DataAnnotations;

namespace saludd.Components.Data
{
    public class Persona
    {

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        [StringLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres")]
        public string Correo { get; set; } = string.Empty;
        [Required(ErrorMessage = "El teléfono es requerido")]
        [Phone(ErrorMessage = "El teléfono no es válido")]
        [StringLength(20, ErrorMessage = "El teléfono no puede exceder los 20 caracteres")]
        public string Telefono { get; set; } = string.Empty;


    }
}




