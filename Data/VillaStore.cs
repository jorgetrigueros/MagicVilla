using MagicVilla_API.Dtos.Villa;

namespace MagicVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
             new VillaDto { Id = 1, Nombre = "Vista a la Piscina", Ocupantes = 4, MetrosCuadrados = 80},
             new VillaDto { Id = 2, Nombre = "Vista a la Playa", Ocupantes = 4, MetrosCuadrados = 80}
        };
    }
}
