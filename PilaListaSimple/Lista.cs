using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaListaSimple
{
    internal class Lista
    {
        Nodo primero = null;
        Nodo ultimo = null;

        public void insertar(string i, string pre, string po)
        {
            Nodo nuevo = new Nodo();
            nuevo.Infija = i;
            nuevo.Prefija = pre;
            nuevo.Postfija = po;

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
        }

        public void mostrar(ListView l)
        {
            Nodo actual = primero;

            while (actual != null)
            {
                ListViewItem item = new ListViewItem(actual.Infija);
                item.SubItems.Add(actual.Prefija);
                item.SubItems.Add(actual.Postfija);
                l.Items.Add(item);
                actual = actual.Siguiente;
            }
        }
    }
}
