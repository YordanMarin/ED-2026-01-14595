using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaListaSimple
{
    internal class Pila
    {
        private Nodo cima = null;
        private int cant = 0;

        public void Push(string nom)
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            nuevo.Siguiente = cima;
            cima = nuevo;
            cant++;
        }

        public string Pop()
        {
            if (cima != null)
            {
                string nom = cima.Nombre;
                cima = cima.Siguiente;
                cant--;
                return nom;
            }
            return null;
        }

        public string Peek()
        {
            if (cima != null)
            {
                return cima.Nombre;
            }
            return null;
        }

        public int Count()
        {
            return cant;
        }

        public void Clear()
        {
            cima = null;
            cant = 0;
        }

        public bool Estavacio()
        {
            return cima == null;
        }
    }
}
