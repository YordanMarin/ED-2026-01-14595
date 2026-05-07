using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola {
    internal class Cola {
        Nodo primero = null;
        Nodo ultimo = null;
        int cant = 0;

        public bool Enqueue(string nom) {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            if(buscar(nom) == false) {
                if (primero == null) {
                    primero = nuevo;
                    primero.Siguiente = null;
                    ultimo = nuevo;
                } else {
                    ultimo.Siguiente = nuevo;
                    nuevo.Siguiente = null;
                    ultimo = nuevo;
                }
                cant++;
                return true;
            } else {
                return false;
            }  
        }

        public bool buscar(string nom) {
            Nodo actual = primero;
            while(actual != null) {
                if(actual.Nombre == nom) {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        public void mostrar(ListBox l) {
            Nodo actual = primero;

            while(actual != null) {
                l.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public string Dequeue() {
            if(primero != null) {
                string nom = primero.Nombre;
                primero = primero.Siguiente;
                cant--;
                return nom;
            }
            return null;
        }

        public string Peek() {
            if (primero != null) {
                string nom = primero.Nombre;
                return nom;
            }
            return null;
        }

        public int Count() {
            return cant;
        }

        public void Clear() {
            primero = null;
            ultimo = null;
            cant = 0;
        }
    }
}
