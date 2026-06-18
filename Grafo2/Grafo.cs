using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafo2 {
    internal class Grafo {
        int[,] matriz;
        int cantidad;

        public Grafo(int cantidad) {
            this.cantidad = cantidad;
            matriz = new int[cantidad, cantidad];
        }

        public void insertar(int o, int d, int c) {
            matriz[o, d] = c;
            //matriz[d, o] = c; si es no dirigido
        }

        public void imprimirArista(int o, int d,int c, ListBox l) {
            l.Items.Add($"{o} | {d} | {c}");
        }

        public void imprimirMatriz(RichTextBox r) {
            for (int i = 0; i < cantidad; i++) {
                for (int j = 0; j < cantidad; j++) {
                    r.Text += matriz[i, j] + "\t";
                }
                r.Text += "\n";
            }
        }

        public void dijkstra(int inicio, ListBox l) {
            int[] distancias = new int[cantidad];
            bool[] visitados = new bool[cantidad];

            for(int i = 0;i < cantidad; i++) {
                distancias[i] = int.MaxValue;
                visitados[i] = false;
            }

            distancias[inicio] = 0;

            for (int i = inicio; i<cantidad-1;i++) {
                int minimo = minima_distancia(distancias, visitados);
                visitados[i] = true;

                for (int j = inicio; j<cantidad;j++) {
                    if (!visitados[j] && matriz[minimo,j] != 0 && 
                        distancias[minimo]!= int.MaxValue &&
                        distancias[minimo] + matriz[minimo,j] < distancias[j]) {
                        distancias[j] = distancias[minimo]+matriz[minimo,j];
                    }
                }
            }
            l.Items.Add("Origen\tDestino\tDistancia");
            for(int i = 0; i < cantidad; i++) {
                if (distancias[i] == int.MaxValue)
                    l.Items.Add($"{inicio}\t{i}\tIndeterminado");
                else l.Items.Add($"{inicio}\t{i}\t{distancias[i]}");
            }
        }

        public int minima_distancia(int[] distancias, bool[] visitados) {
            int min = int.MaxValue;
            int index = -1;

            for (int i = 0; i < cantidad; i++) {
                if (!visitados[i] && distancias[i] <= min) {
                    min = distancias[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
