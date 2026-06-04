using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABBFinal {
    internal class Arbol {

        int cant = 0;
        
        public Nodo Insertar(Nodo actual,double num) {
            Nodo nuevo = new Nodo(num);

            if (actual == null) {
                cant++;
                return nuevo; 
            }

            if (num < actual.numero) actual.izquierda = Insertar(actual.izquierda, num);
            else if (num > actual.numero) actual.derecha = Insertar(actual.derecha, num);
            else MessageBox.Show("No se permiten duplicados!");
            return actual;
        }

        public void Mostrar(Nodo actual, TreeView t, TreeNode rama) {
            TreeNode raiz = new TreeNode(actual.numero.ToString());

            if(rama == null) t.Nodes.Add(raiz);
            else rama.Nodes.Add(raiz);

            if(actual.izquierda != null)
            Mostrar(actual.izquierda, t, raiz);
            if(actual.derecha != null)
            Mostrar(actual.derecha, t, raiz);
        }

        public int Count() {
            return cant;
        }

        public Nodo minimo(Nodo actual) {
            while(actual.izquierda != null) {
                actual = actual.izquierda;
            }
            return actual;
        }

        public Nodo maximo(Nodo actual) {
            while (actual.derecha != null) {
                actual = actual.derecha;
            }
            return actual;
        }

        public double SumaHojas(Nodo actual) {
            if(actual == null) return 0;

            if (actual.izquierda == null & actual.derecha == null)
                return actual.numero;

            return SumaHojas(actual.izquierda)+SumaHojas(actual.derecha);
        }
    }
}
