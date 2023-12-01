using System;
using Recuperación_Profe_Eric.Clases;

namespace Recuperación_Profe_Eric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            for (int i = 0; i < 3; i++)
            {
                lista.IngresarAuto();
            }

            Console.WriteLine("Los registros de los autos son: ");
            lista.Mostrar();

            Console.WriteLine("Los elementos esta ordenados por la marca: ");
            lista.MostrarOrdenados();

            Console.WriteLine("Ingrese la marca que desee buscar");
            string nombreBuscado = Console.ReadLine();
            int posicionEncontrada = lista.BuscarPorMarca(nombreBuscado);
        }
    }
}