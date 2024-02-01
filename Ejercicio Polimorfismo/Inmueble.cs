
namespace Ejercicio_Polimorfismo
{
    internal class Inmueble
    {
        public string TipoInmueble {  get; set; }
        public string Ubicacion { get; set; }
        public double AreaTerreno { get; set; }
        public double Precio { get; set; }

        public void Vender()
        {
            Console.WriteLine($"{TipoInmueble} Vendida por el precio de L{Precio}");
        }

        public void Vender(string Cliente)
        {
            Console.WriteLine($"{TipoInmueble} vendida por el precio de L{Precio} por el cliente {Cliente}");
        }

        public void Vender(double Descuento)
        {
            Console.WriteLine($"{TipoInmueble} vendida por el precio de L{Precio} con descuento de L{Descuento}");
        }

        public void Vender(string Cliente, double Descuento)
        {
            Console.WriteLine($"{TipoInmueble} vendida por el precio de L{Precio} por el cliente {Cliente} y con un descuento de L{Descuento}");
        }
    }
}
