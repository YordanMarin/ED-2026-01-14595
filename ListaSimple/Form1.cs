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
    }
}
