
namespace Ejercicio_Polimorfismo
{
    internal class Terreno : Inmueble
    {
        public Terreno() { }
        public Terreno(string TipoInmueble, double Precio) {
            this.TipoInmueble = TipoInmueble;
            this.Precio = Precio;
        }

    }
}
