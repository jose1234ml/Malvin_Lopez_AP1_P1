
using System.ComponentModel.DataAnnotations;

namespace Malvin_Lopez_AP1_P1.Models;

public class RegistroAportes
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
    [RegularExpression(@"^[^\d]*$", ErrorMessage = "El nombre no puede contener números")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La fecha es obligatoria")]
    [DataType(DataType.Date)]
    public DateTime Fecha { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Debe ingresar el monto aportado.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El dinero aportado debe ser mayor a 0")]
    public decimal DineroAportes { get; set; }
}