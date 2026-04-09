using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCircular {
    internal class Lista {
        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar(int num) {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;

            if(primero == null) {
                primero = nuevo;
                primero.Siguiente = nuevo;
                ultimo = nuevo;
            } else {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListBox l) {

            if (primero == null) return;

            Nodo actual = primero;

            do {
                l.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }while(actual != primero);
        }

        public void eliminar(int num) {
            if (primero == null) return;

            Nodo actual = primero;
            Nodo anterior = null;

            do {
                if(actual.Numero == num) {
                    if(actual == primero) {
                        primero = primero.Siguiente;
                        if(primero == actual) {
                            primero = null;

                        } else {
                            ultimo.Siguiente = primero;
                        }
                    }else if(actual == ultimo) {
                        anterior.Siguiente = primero;
                        ultimo = anterior;
                    } else {
                        anterior.Siguiente = actual.Siguiente;
                    }
                }
                anterior = actual;
                actual = actual.Siguiente;
            } while (actual != primero);
        }
    }
}
