using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Cola c = new Cola();
        private void btnEnqueue_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(textNombre.Text)) {
                bool estado = c.Enqueue(textNombre.Text.Trim());
                if (estado) {
                    listBox1.Items.Clear();
                    c.mostrar(listBox1);
                    textNombre.Clear();
                } else MessageBox.Show("No se permiten duplicados");
                
            } else MessageBox.Show("No se permiten nombres vacios");
        }

        private void btnDequeue_Click(object sender, EventArgs e) {
            string nom = c.Dequeue();

            if (nom != null) {
                MessageBox.Show("Nombre desencolado: "+nom);
                listBox1.Items.Clear();
                c.mostrar(listBox1);
            } else MessageBox.Show("La cola esta vacía");
        }

        private void btnPeek_Click(object sender, EventArgs e) {
            string nom = c.Peek();

            if (nom != null)MessageBox.Show("Primero: " + nom);
            else MessageBox.Show("La cola esta vacía");
        }

        private void btnCount_Click(object sender, EventArgs e) {
            MessageBox.Show("Cantiddad: "+c.Count());
        }

        private void btnClear_Click(object sender, EventArgs e) {
            c.Clear();
            listBox1.Items.Clear();
            MessageBox.Show("Se elimino todos los elementos de la cola!");
        }
    }
}
