using Malvin_Lopez_AP1_P1.Models;

namespace Malvin_Lopez_AP1_P1.Services;

public class RegistroService
{
    private static List<RegistroAportes> registros = new();
    public Task<List<RegistroAportes>> ObtenerRegistrosAsync()
    {
        return Task.FromResult(registros);
    }
    public Task<RegistroAportes?> ObtenerPorIdAsync(int id)
    {
        var registro = registros.FirstOrDefault(r => r.Id == id);
        return Task.FromResult(registro);
    }
    public Task CrearRegistroAsync(RegistroAportes nuevo)
    {
        nuevo.Id = registros.Any() ? registros.Max(r => r.Id) + 1 : 1;
        registros.Add(nuevo);
        return Task.CompletedTask;
    }
    public Task<bool> ActualizarRegistroAsync(RegistroAportes actualizado)
    {
        var index = registros.FindIndex(r => r.Id == actualizado.Id);
        if (index == -1)
            return Task.FromResult(false);

        registros[index] = actualizado;
        return Task.FromResult(true);
    }
}
