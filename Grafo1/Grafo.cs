using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafo1 {
    internal class Grafo {
        int[,] matriz;
        int cantidad;

        public Grafo(int cantidad) {
            this.cantidad = cantidad;
            matriz = new int[cantidad, cantidad];
        }

        public void insertar(int o, int d) {
            matriz[o, d] = 1;
        }

        public void imprimirArista(int o, int d, ListBox l) {
            l.Items.Add($"{o} | {d}");
        }

        public void imprimirMatriz(RichTextBox r) {
            for (int i = 0; i < cantidad; i++) {
                for (int j = 0; j < cantidad; j++) {
                    r.Text += matriz[i, j]+"\t";
                }
                r.Text += "\n";
            }
        }

        public void amplitud(TextBox t) {
            int inicio = 0;
            bool[] visitado = new bool[cantidad];
            Queue<int> cola = new Queue<int>();

            visitado[inicio] = true;
            cola.Enqueue(inicio);

            while(cola.Count() != 0) {
                int actual = cola.Dequeue();
                t.Text += actual + " ";

                for (int i = inicio; i < cantidad; i++) {
                    if (matriz[actual,i] == 1 && !visitado[i]) {
                        visitado[i] = true;
                        cola.Enqueue(i);
                    }
                }
            }
        }

        public void profundidad(TextBox t) {
            int inicio = 0;
            bool[] visitado = new bool[cantidad];
            Stack<int> pila = new Stack<int>();

            visitado[inicio] = true;
            pila.Push(inicio);

            while (pila.Count() != 0) {
                int actual = pila.Pop();
                t.Text += actual + " ";

                for (int i = cantidad-1; i>=inicio; i--) {
                    if (matriz[actual, i] == 1 && !visitado[i]) {
                        visitado[i] = true;
                        pila.Push(i); ;
                    }
                }
            }
        }
    }
}
