﻿
namespace Ejercicio_Polimorfismo
{
    internal class Edificio
    {
        public string Tipo { get; set; }
        public double Precio { get; set; }

        public void Vender()
        {
            Console.WriteLine($"{Tipo} vendida por el precio de L{Precio}");
        }
    }
}
