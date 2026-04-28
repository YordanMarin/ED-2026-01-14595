using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaListaSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conversion c = new Conversion();
        Lista l = new Lista();
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            l.insertar(textInfija.Text, c.infijaPrefija(textInfija.Text), c.infijaPostfija(textInfija.Text));
            listView1.Items.Clear();
            l.mostrar(listView1);
            textInfija.Clear();
        }
    }
}
