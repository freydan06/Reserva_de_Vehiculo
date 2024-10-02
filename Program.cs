using Reserva_de_Vehiculo;
using System;

class Program
{
    static void Main(string[] args)
    {
        Vehiculo vehiculo = new Vehiculo("Toyota Corolla", 50m); // Precio por día: $50
        decimal porcentajeDescuento = 10; // Descuento del 10%

        // Mostrar la información del vehículo
        Console.WriteLine(vehiculo.MostrarInformacion());

        // Calcular el costo total de la reserva por 5 días con descuento
        int diasReserva = 5;
        decimal costoTotal = CalcularReserva.CalcularCostoTotal(vehiculo, diasReserva, porcentajeDescuento);

        Console.WriteLine($"Costo total de la reserva por {diasReserva} días: {costoTotal:C}");
    }
}

