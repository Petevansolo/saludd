using System.ComponentModel.DataAnnotations;

public class Estudiante
{
    // Clave primaria. EF Core la detecta por convención (propiedad llamada "Id")
    // y en SQL Server la crea como IDENTITY (autoincremental).
    public int Id { get; set; }

    [Required(ErrorMessage = "El Nombre no debe ser vacío")]
    [StringLength(100, ErrorMessage = "El Nombre no debe pasar de 100 caracteres")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El Correo no debe ser vacío")]
    [EmailAddress(ErrorMessage = "Debe contener un correo válido")]
    [StringLength(150, ErrorMessage = "El Correo no debe pasar de 150 caracteres")]
    public string Correo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La calificación es requerida")]
    [Range(0, 10, ErrorMessage = "La calificación debe ser de 0 a 10")]
    public double Calificacion { get; set; }
}