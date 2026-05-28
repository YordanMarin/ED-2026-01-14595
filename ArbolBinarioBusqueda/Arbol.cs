using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusqueda {
    internal class Arbol {
        public Nodo insertar(Nodo actual, int num) {
            Nodo nuevo = new Nodo(num);

            if (actual == null) return nuevo;
            else if (num > actual.numero) actual.derecha = insertar(actual.derecha, num);
            else if (num < actual.numero) actual.izquierda = insertar(actual.izquierda, num);
            else MessageBox.Show("No se permiten nodos duplicados");
            return actual;
        }

        public void mostrar(Nodo actual, TreeView t, TreeNode rama) {
            if(actual == null) return;
            TreeNode raiz = new TreeNode(actual.numero.ToString());//mostrando raiz

            if (rama == null)  // mostrar las ramas.
                t.Nodes.Add(raiz);
            else //mostrar hojas
                rama.Nodes.Add(raiz);

            if (actual.izquierda != null)
                mostrar(actual.izquierda, t, raiz);
            if (actual.derecha != null)
                mostrar(actual.derecha, t, raiz);
        }

        public void Preorden(Nodo actual, TextBox t) {
            if (actual == null) return;

            t.Text += actual.numero.ToString() + " "; //raiz
            Preorden(actual.izquierda,t); //izquierda
            Preorden(actual.derecha,t); //derecha
        }

        public void Inorden(Nodo actual, TextBox t) {
            if (actual == null) return;

            Inorden(actual.izquierda, t); //izquierda
            t.Text += actual.numero.ToString() + " "; //raiz
            Inorden(actual.derecha, t); //derecha
        }

        public void Postorden(Nodo actual, TextBox t) {
            if (actual == null) return;

            Postorden(actual.izquierda, t); //izquierda
            Postorden(actual.derecha, t); //derecha
            t.Text += actual.numero.ToString() + " "; //raiz
        }

        public Nodo Buscar(Nodo actual, int num) {
            if (actual == null) return null;

            if (num == actual.numero) return actual;
            else if (num < actual.numero)
                return Buscar(actual.izquierda, num);
            else
                return Buscar(actual.derecha, num);
        }

        public Nodo Eliminar(Nodo actual, int num) {
            if(actual == null) return null;

            if(num< actual.numero) 
                actual.izquierda = Eliminar(actual.izquierda, num);
            else if(num>actual.numero)
                actual.derecha = Eliminar(actual.derecha,num);
            else {
                //caso 1: cuando se tiene 1 unico hijo.
                if (actual.izquierda == null) return actual.derecha;
                if (actual.derecha == null) return actual.izquierda;

                //caso 2: cuando se tiene 2 hijos
                Nodo sucesor = minimo(actual.derecha);
                actual.numero = sucesor.numero;
                actual.derecha = Eliminar(actual.derecha, sucesor.numero);
            }
            return actual;
        }

        public Nodo minimo(Nodo actual) {
            while(actual.izquierda != null)
                actual = actual.izquierda;
            return actual;
        }
    }
}