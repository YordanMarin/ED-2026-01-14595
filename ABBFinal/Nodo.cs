using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABBFinal {
    internal class Nodo {
        public double numero {  get; set; }
        public Nodo izquierda { get; set; }
        public Nodo derecha { get; set; }

        public Nodo(double numero) {
            this.numero = numero;
            izquierda = null;
            derecha = null;
        }
    }
}
