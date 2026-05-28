using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario {
    internal class Arbol {
        public Nodo insertar(Nodo actual, int num) {
            Nodo nuevo = new Nodo(num);

            if (actual == null) //insertar raiz
                return nuevo;
            else if ((actual.izquierda != null || actual.derecha == null)
                && (actual.izquierda == null || actual.derecha != null)) //insertar ramas
                MessageBox.Show("Nodo ocupado");
            else if(actual.izquierda == null) actual.izquierda = nuevo;
            else actual.derecha = nuevo;
            return actual;
        }

        public void mostrar(Nodo actual, TreeView t, TreeNode rama) {

            TreeNode raiz = new TreeNode(actual.numero.ToString());//mostrando raiz
            raiz.Tag = actual; // almacena la referencia del nodo

            if(rama == null)  // mostrar las ramas.
                t.Nodes.Add(raiz);
            else //mostrar hojas
                rama.Nodes.Add(raiz);

            if (actual.izquierda != null) 
                mostrar(actual.izquierda, t, raiz);
            if (actual.derecha != null)
                mostrar(actual.derecha, t, raiz);

        }

        public int Altura(Nodo actual) {
            if(actual == null) return 0;
            else {
                int alturaIzquierda = Altura(actual.izquierda);
                int alturaDerecha = Altura(actual.derecha);

                return Math.Max(alturaIzquierda, alturaDerecha) + 1;
            }
        }

        
    }
}
