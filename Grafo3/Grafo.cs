using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafo3 {
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

        public void imprimirArista(int o, int d, int c, ListBox l) {
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

        public void floyd(RichTextBox r) {
            int[,] floyd = new int[cantidad, cantidad];

            for(int i = 0;i < cantidad; i++) {
                for (int j = 0;j < cantidad; j++) {
                    if(matriz[i, j] != 0)
                        floyd[i,j]=matriz[i,j];
                    else
                        floyd[i,j] = int.MaxValue;
                }
            }

            //algoritmo de floyd-warshall
            for(int k = 0;  k < cantidad; k++) {
                for(int i = 0; i < cantidad; i++) {
                    for( int j = 0;j< cantidad; j++) {
                        if (floyd[i,k] != int.MaxValue && floyd[k,j] != int.MaxValue) {
                            
                            int nuevoCosto = floyd[i,k] + floyd[k,j];
                            if (nuevoCosto < floyd[i,j]) {
                                floyd[i, j] = nuevoCosto;
                            }
                        }
                    }
                }
            }

            //imprimiendo la matriz de floyd-warshall
            for(int i =0; i < cantidad; i++) {
                for(int j=0; j< cantidad; j++) {
                    if (i == j)
                        r.Text += 0 + "\t";
                    else if (floyd[i, j] == int.MaxValue)
                        r.Text += "∞" + "\t";
                    else
                        r.Text += floyd[i, j] + "\t";
                }
                r.Text += "\n";
            }
        }
    }
}
