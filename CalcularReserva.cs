public static class CalcularReserva
{
    public static decimal CalcularCostoTotal(Vehiculo vehiculo, int dias, decimal porcentajeDescuento)
    {
        decimal precioConDescuento = Vehiculo.Descuento.AplicarDescuento(vehiculo.PrecioPorDia, porcentajeDescuento);
        return precioConDescuento * dias;
    }
}
