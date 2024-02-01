
namespace Ejercicio_Polimorfismo
{
    internal class Departamento : Inmueble
    {
        public Departamento() { }

        public Departamento(string TipoInmueble, double Precio) {
            this.TipoInmueble = TipoInmueble;
            this.Precio = Precio;
        }
    }
}
