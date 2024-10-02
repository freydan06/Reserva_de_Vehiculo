using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva_de_Vehiculo
{
    public static class VehiculoExtensions
    {
        public static string MostrarInformacion(this Vehiculo vehiculo)
        {
            return $"Modelo: {vehiculo.Modelo}, Precio por día: {vehiculo.PrecioPorDia:C}";
        }
    }
}
