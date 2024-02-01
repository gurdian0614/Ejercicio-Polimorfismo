
namespace Ejercicio_Polimorfismo
{
    internal class Casa : Inmueble
    {
        public Casa() { }

        public Casa(string TipoInmueble) {
            this.TipoInmueble = TipoInmueble;
        }

        public Casa(string TipoInmueble, double Precio) {
            this.TipoInmueble = TipoInmueble;
            this.Precio = Precio;
        }

        public Casa(string TipoInmueble, string Ubicacion, double AreaTerreno, double Precio)
        {
            this.TipoInmueble = TipoInmueble;
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
            this.Precio = Precio;
        }
    }
}
