using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            radioIzquierda.Checked = true;
        }
        Arbol a = new Arbol();
        Nodo raiz;
        Nodo seleccionado;
        private void btninsertarRaiz_Click(object sender, EventArgs e) {
            if (int.TryParse(textNumero.Text, out int num) && num >= 0) {
                raiz = a.insertar(null,num);
                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            } else MessageBox.Show("Ingrese un número entero válido positivo!");
        }

        private void btnInsertarRamas_Click(object sender, EventArgs e) {
            if (int.TryParse(textNumero.Text, out int num) && num >= 0) {
                if (seleccionado != null) {
                    if(radioIzquierda.Checked == true)
                        seleccionado.izquierda = a.insertar(seleccionado.izquierda,num);
                    if (radioDerecha.Checked == true)
                        seleccionado.derecha = a.insertar(seleccionado.derecha, num);

                    treeView1.Nodes.Clear();
                    a.mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();
                    textNumero.Clear();

                } else MessageBox.Show("Seleccione un nodo!");
            } else MessageBox.Show("Ingrese un número entero válido positivo!");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            seleccionado = (Nodo)e.Node.Tag;
        }

        private void btnAltura_Click(object sender, EventArgs e) {
            MessageBox.Show("Altura: "+a.Altura(raiz));
        }
    }
}
