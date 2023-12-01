using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperación_Profe_Eric.Clases
{
    public class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        public bool EstaVacio()
        {
            if (Primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void IngresarAuto()
        {
            Nodo nuevo = new Nodo();

            Console.WriteLine("Ingresa la marca, modelo y año de fabricación");
            
            {
                nuevo.DatoMarca = Convert.ToString(Console.ReadLine());
                nuevo.DatoModelo = Convert.ToString(Console.ReadLine());
                nuevo.DatoAño = int.Parse(Console.ReadLine());

                if (EstaVacio())
                {
                    Primero = nuevo;
                    Primero.Siguiente = null;
                    Ultimo = nuevo;
                }
                else
                {
                    Ultimo.Siguiente = nuevo;
                    nuevo.Siguiente = null;
                    Ultimo = nuevo;
                }
            }
        }

        public void Mostrar()
        {
            Nodo actual = new Nodo();
            actual = Primero;

            if (Primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine(actual.DatoMarca);
                    Console.WriteLine(actual.DatoModelo);
                    Console.WriteLine(actual.DatoAño);
                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }


        public void OrdenamientoBurbuja()
        {
            while (!OrdenarPorMarca())
            {
                Nodo actual = new Nodo();

                while (actual != null && actual.Siguiente != null)
                {
                    string tempMarca = actual.DatoMarca;
                    actual.DatoMarca = actual.Siguiente.DatoMarca;
                    actual.Siguiente.DatoMarca = tempMarca;

                    string tempModelo = actual.DatoModelo;
                    actual.DatoModelo = actual.Siguiente.DatoModelo;
                    actual.Siguiente.DatoModelo = tempModelo;

                    int tempAño = actual.DatoAño;
                    actual.DatoAño = actual.Siguiente.DatoAño;
                    actual.Siguiente.DatoAño = tempAño;
                }
                actual = actual.Siguiente;
            }
        }


        //nunca investige como ordenarlo con el
        //tipo de dato entero, perdon.
        public bool OrdenarPorMarca()
        {
            Nodo actual = Primero;

            while (actual != null && actual.Siguiente != null)
            {
                if (string.Compare(actual.DatoMarca, actual.Siguiente.DatoMarca) > 0)
                {
                    return false;
                }

                actual = actual.Siguiente;
            }

            return true;
        }


        public void MostrarOrdenados()
        {
            Console.WriteLine("Ordenando la lista por la Marca");
            OrdenamientoBurbuja();

            Console.WriteLine("Los elementos ordenado por la marca son: ");
            Mostrar();
        }


        public int BuscarPorMarca(string marcaBuscada)
        {
            Nodo actula = Primero;

            int posicion = 1;

            while (actula != null)
            {
                if (actula.DatoMarca.Equals(marcaBuscada))
                {
                    Console.WriteLine($"La marca {marcaBuscada} fue encontrado");
                    return posicion;
                }
                actula = actula.Siguiente;
                posicion++;
            }
            Console.WriteLine($"La marca {marcaBuscada} no fue encontrada en la lista");
            return -1;
        }
    }
}
