using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleAnalisis {
    internal class Lista {
        private Nodo primero = null;
        private Nodo ultimo = null;

        public void insertar(string nom, byte ed) {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;
            nuevo.Edad = ed;

            if(primero == null) {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Anterior = null;
                ultimo = nuevo;
            } else {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Anterior = ultimo;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListView l) {
            Nodo actual = primero;

            while(actual != null) {
                ListViewItem item = new ListViewItem(actual.Nombre);
                item.SubItems.Add(actual.Edad.ToString());
                l.Items.Add(item);
                actual = actual.Siguiente;
            }
        }

        public Nodo buscar(string nom) {
            Nodo actual = primero;

            while(actual != null) {
                if(actual.Nombre == nom) {
                    return actual;
                }
                actual = actual.Siguiente;
            }
            return null;
        }

        public void modificar(string an, string nn, byte ne) {
            Nodo modi = buscar(an);

            if(modi != null) {
                modi.Nombre = nn;
                modi.Edad = ne;
            }
        }

        public void eliminar(string an) {
            Nodo eli = buscar(an);

            if (eli != null) {
                if(eli == primero) {

                }else if(eli == ultimo) {

                } else {

                }
            }
        }
    }
}
