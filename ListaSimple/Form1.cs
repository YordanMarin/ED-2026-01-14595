using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista l = new Lista();

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            l.insertar(int.Parse(textNumero.Text));
            l.mostrar(listBox1);
            textNumero.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            l.eliminar(int.Parse(textNumero.Text));
            listBox1.Items.Clear();
            l.mostrar(listBox1);
            textNumero.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (l.buscar(int.Parse(textNumero.Text)) == true)
                MessageBox.Show("El número existe en la lista");
            else MessageBox.Show("El número no existe en la lista");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            l.ordenar();
            listBox1.Items.Clear();
            l.mostrar(listBox1);
        }
    }
}
