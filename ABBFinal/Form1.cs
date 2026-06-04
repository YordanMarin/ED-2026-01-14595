using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABBFinal {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Arbol a = new Arbol();
        Nodo raiz;
        private void btninsertar_Click(object sender, EventArgs e) {
            string num = textNumero.Text.Trim();
            double num2;

            if (Regex.IsMatch(num, @"^\d+(\,\d{2,})$")) {
                num2 = double.Parse(num);

                if (raiz == null) raiz = a.Insertar(null, num2);
                else { 
                    a.Insertar(raiz, num2);
                }
                textNumero.Clear();

            } else {
                MessageBox.Show("Solo se permiten números con 2 decimales");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e) {
            if (raiz != null) {
                if (a.Count() >= 4) {
                    treeView1.Nodes.Clear();
                    a.Mostrar(raiz, treeView1, null);
                    treeView1.ExpandAll();
                }else MessageBox.Show("Como mínimo debes de ingresar 8 decimales");
            } else MessageBox.Show("Árbol vacio!");
        }
    }
}
