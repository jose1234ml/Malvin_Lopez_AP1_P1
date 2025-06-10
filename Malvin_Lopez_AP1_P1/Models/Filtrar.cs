

namespace Malvin_Lopez_AP1_P1.Models;

public static class Filtrar
{
    public static List<RegistroAportes> Aplicar(
        List<RegistroAportes> registros,
        string filtroCampo,
        string valorFiltro,
        DateTime? fechaDesde,
        DateTime? fechaHasta)
    {
        if (registros == null || registros.Count == 0)
            return new List<RegistroAportes>();

        var resultado = registros.AsQueryable();

        if (!string.IsNullOrWhiteSpace(filtroCampo) && !string.IsNullOrWhiteSpace(valorFiltro))
        {
            switch (filtroCampo)
            {
                case "Id aportes":
                    if (int.TryParse(valorFiltro, out int id))
                        resultado = resultado.Where(r => r.Id == id);
                    break;

                case "Nombre":
                    resultado = resultado.Where(r =>
                        r.Nombre != null &&
                        r.Nombre.Contains(valorFiltro, StringComparison.OrdinalIgnoreCase));
                    break;
            }
        }

        if (fechaDesde.HasValue)
        {
            resultado = resultado.Where(r => r.Fecha >= fechaDesde.Value);
        }

        if (fechaHasta.HasValue)
        {
            resultado = resultado.Where(r => r.Fecha <= fechaHasta.Value);
        }

        return resultado.ToList();
    }
}
