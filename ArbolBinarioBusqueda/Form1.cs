using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinarioBusqueda {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Arbol a = new Arbol();
        Nodo raiz;
        private void btninsertar_Click(object sender, EventArgs e) {
            if (raiz == null) {
                raiz = a.insertar(null, int.Parse(textNumero.Text));
                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                textNumero.Clear();
            }else {
                a.insertar(raiz, int.Parse(textNumero.Text));
                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1, null);
                treeView1.ExpandAll();
                textNumero.Clear();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e) {
            textPre.Clear();
            textPost.Clear();
            textIn.Clear();
            a.Preorden(raiz,textPre);
            a.Inorden(raiz,textIn);
            a.Postorden(raiz,textPost);
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            Nodo buscar = a.Buscar(raiz, int.Parse(textNumero.Text));

            if (buscar != null) {
                MessageBox.Show($"El número {buscar.numero} se encuentra en el árbol");
            } else MessageBox.Show("El número no existe en el árbol");
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            Nodo buscar = a.Buscar(raiz, int.Parse(textNumero.Text));

            if (buscar != null) {

                raiz = a.Eliminar(raiz, int.Parse(textNumero.Text));
                treeView1.Nodes.Clear();
                a.mostrar(raiz, treeView1,null);
                textNumero.Clear();

            } else MessageBox.Show("No se puede eliminar. El número no existe en el árbol");
        }
    }
}
