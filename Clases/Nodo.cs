using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperación_Profe_Eric.Clases
{
    public class Nodo
    {
        private string _datoMarca;
        private string _datoModelo;
        private int _datoAño;
        private Nodo _siguiente;


        public string DatoMarca
        {
            get { return _datoMarca;}
            set { _datoMarca = value;}
        }

        public string DatoModelo
        {
            get { return _datoModelo; }
            set { _datoModelo = value;}
        }

        public int DatoAño
        {
            get { return _datoAño; }
            set { _datoAño = value; }
        }

        public Nodo Siguiente
        {
            get { return _siguiente;}
            set{ _siguiente = value; }
        }
    }
}
