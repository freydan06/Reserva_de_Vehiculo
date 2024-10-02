public class Vehiculo
{
    // Propiedades
    public string Modelo { get; set; }
    public decimal PrecioPorDia { get; set; }

    // Metodo
    public Vehiculo(string modelo, decimal precioPorDia)
    {
        Modelo = modelo;
        PrecioPorDia = precioPorDia;

    }
    // Clase interna de vehiculo Descuento 
    public class Descuento
    {
        // Metodo de gestion de descuento
        public static decimal AplicarDescuento(decimal precio, decimal porcentajeDescuento)
        {
            return precio - (precio * (porcentajeDescuento / 100));
        }
    }
}
