using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafo2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Grafo g = new Grafo(7);
        private void btninsertar_Click(object sender, EventArgs e) {
            int o= int.Parse(textOrigen.Text);
            int d = int.Parse(textDestino.Text);
            int c = int.Parse(textCosto.Text);

            g.insertar(o, d, c);
            g.imprimirArista(o, d, c, listBox1);
        }

        private void btnMatriz_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
            g.imprimirMatriz(richTextBox1);
        }

        private void button1_Click(object sender, EventArgs e) {
            listBox2.Items.Clear();
            g.dijkstra(0, listBox2);
        }
    }
}
