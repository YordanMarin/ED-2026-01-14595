using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleAnalisis {
    internal class Nodo {
        private string nombre;
        private byte edad;
        private Nodo anterior;
        private Nodo siguiente;

        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        internal Nodo Anterior { get => anterior; set => anterior = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
