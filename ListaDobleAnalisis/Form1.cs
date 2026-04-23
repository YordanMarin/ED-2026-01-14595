using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleAnalisis {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Lista l = new Lista();
        private void btnInsertar_Click(object sender, EventArgs e) {
            string n = textNombre.Text.Trim();

            if (!string.IsNullOrWhiteSpace(n)) {
                if (byte.TryParse(textEdad.Text, out byte ed) && ed <= 150) {
                    listView1.Items.Clear();
                    l.insertar(n, ed);
                    l.mostrar(listView1);
                    textNombre.Clear();
                    textEdad.Clear();
                } else {
                    MessageBox.Show("Solo se permiten edades de 0 a 150");
                }
            } else {
                MessageBox.Show("No se permiten nombres vacios");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            string n = textNombre.Text.Trim();

            if (!string.IsNullOrWhiteSpace(n)) {
                Nodo buscar = l.buscar(n);
                if (buscar != null) {
                    MessageBox.Show($"Nombre: {buscar.Nombre}\nEdad: {buscar.Edad}");
                } else
                    MessageBox.Show("El nombre no existe");
            } else {
                MessageBox.Show("No se permiten buscar nombres vacios");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {
            if(listView1.SelectedItems.Count > 0) {
                string selec = listView1.SelectedItems[0].Text;

                string n = textNombre.Text.Trim();
                byte ed = byte.Parse(textEdad.Text);

                l.modificar(selec,n,ed);
                listView1.Items.Clear();
                l.mostrar(listView1 );
                textNombre.Clear();
                textEdad.Clear();

            } else MessageBox.Show("Selecione un nombre a modificar");
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count > 0) {
                string selec = listView1.SelectedItems[0].Text;

                l.eliminar(selec);
                listView1.Items.Clear();
                l.mostrar(listView1);

            } else MessageBox.Show("Selecione un nombre a eliminar");
        }
    }
}
