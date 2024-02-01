
using Ejercicio_Polimorfismo;

Casa casa = new Casa("Casa de campo", 70000);
casa.Vender();
casa.Vender("Roger Gurdian");
casa.Vender(5000);
casa.Vender("Roger Gurdian", 5000);

Inmueble inmueble = new Casa("Casa de campo", 70000);

Departamento departamento = new Departamento("Duplex", 100000);
departamento.Vender();

Terreno terreno = new Terreno("Terreno", 150000);
terreno.Vender();

Edificio e1 = new Edificio();
e1.Tipo = "Edificio 1";
e1.Precio = 500000;

Edificio e2 = new Edificio();
e2.Tipo = "Edificio 2";
e2.Precio = 1000000;

List<Edificio> edificioLista = new List<Edificio>();
edificioLista.Add(e1);
edificioLista.Add(e2);

Console.WriteLine($"\n\n********** Lista de Edificios **********");
foreach (Edificio edificio in edificioLista)
{
    edificio.Vender();
}
