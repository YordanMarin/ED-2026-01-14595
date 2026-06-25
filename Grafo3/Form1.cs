using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafo3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Grafo g;

        private void btnVertices_Click(object sender, EventArgs e) {
            g = new Grafo(int.Parse(textVertice.Text));
            listBox1.Items.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
        }

        private void btninsertar_Click(object sender, EventArgs e) {
            if (g != null) {
                int o = int.Parse(textOrigen.Text);
                int d = int.Parse(textDestino.Text);
                int c = int.Parse(textCosto.Text);

                g.insertar(o, d, c);
                g.imprimirArista(o, d, c,listBox1);
                textOrigen.Clear();
                textDestino.Clear();
                textCosto.Clear();

            } else MessageBox.Show("Error. Ingrese primero los vertices.");
        }

        private void btnMatriz_Click(object sender, EventArgs e) {
            if (g != null) {
                richTextBox1.Clear();
                g.imprimirMatriz(richTextBox1);

            } else MessageBox.Show("Error. Ingrese primero los vertices.");
        }

        private void btnFloyd_Click(object sender, EventArgs e) {
            if (g != null) {
                richTextBox2.Clear();
                g.floyd(richTextBox2);

            } else MessageBox.Show("Error. Ingrese primero los vertices.");
        }
    }
}
