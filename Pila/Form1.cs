using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Pila p = new Pila();
        private void btnPush_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(textNombre.Text)) {
                p.Push(textNombre.Text);
                listBox1.Items.Clear();
                p.mostrar(listBox1);
                textNombre.Clear();
            } else MessageBox.Show("No se permiten nombres vacios");
            
        }

        private void btnPop_Click(object sender, EventArgs e) {
            string nom = p.Pop();
            if (nom != null) {
                MessageBox.Show($"Desapilado: {nom}");
                listBox1.Items.Clear();
                p.mostrar(listBox1);
            } else MessageBox.Show("Pila vacia");
        }

        private void btnPeek_Click(object sender, EventArgs e) {
            if(p.Peek() != null) {
                MessageBox.Show($"Cima: {p.Peek()}");
            } else MessageBox.Show("Pila vacia");
        }

        private void btnCount_Click(object sender, EventArgs e) {
            MessageBox.Show("Cantidad elementos: "+p.Count());
        }

        private void btnClear_Click(object sender, EventArgs e) {
            p.Clear();
            listBox1.Items.Clear ();
            MessageBox.Show("Le elimino la pila");
        }
    }
}
