
using System.ComponentModel.DataAnnotations;

namespace Malvin_Lopez_AP1_P1.Models;

public class RegistroAportes
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
    [RegularExpression(@"^(?=.*[a-zA-ZÁÉÍÓÚáéíóúñÑ])[a-zA-ZÁÉÍÓÚáéíóúñÑ\s]*$", ErrorMessage = "El nombre solo puede contener letras y espacios.")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La fecha es obligatoria")]
    [DataType(DataType.Date)]
    public DateTime Fecha { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Debe ingresar el monto aportado.")]
    [Range(0.01, 10000000, ErrorMessage = "El dinero aportado debe estar entre 0.01 y 10,000,000")]
    public decimal DineroAportes { get; set; }
}