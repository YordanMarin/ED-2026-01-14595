using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaListaSimple
{
    internal class Conversion
    {
        Pila p = new Pila();

        public int obtenerPrioridad(string operador)
        {
            if (operador == "*" || operador == "/") return 2;
            if(operador =="+" || operador =="-") return 1;
            return 0;
        }

        public bool EsOperador(string c)
        {
            return c=="*" || c=="/" || c=="+" || c=="-";
        }

        public string infijaPrefija(string infija)
        {
            StringBuilder prefija = new StringBuilder();

            for(int i = infija.Length -1; i >= 0; i--)
            {
                string c = infija[i].ToString();

                if (char.IsLetterOrDigit(infija[i]))
                {
                    prefija.Insert(0, c);
                }else if (c == ")")
                {
                    p.Push(c);
                }else if(c == "(")
                {
                    while(!p.Estavacio() && p.Peek() != ")")
                    {
                        prefija.Insert(0, p.Pop());
                    }
                    p.Pop();
                }
                else if(EsOperador(c))
                {
                    while(!p.Estavacio() & obtenerPrioridad(p.Peek()) > obtenerPrioridad(c))
                    {
                        prefija.Insert(0, p.Pop());
                    }
                    p.Push(c);
                }
            }

            while (!p.Estavacio())
            {
                prefija.Insert(0, p.Pop());
            }
            return prefija.ToString();
        }

        public string infijaPostfija(string infija)
        {
            StringBuilder postfija = new StringBuilder();

            for (int i = 0; i < infija.Length; i++)
            {
                string c = infija[i].ToString();

                if (char.IsLetterOrDigit(infija[i]))
                {
                    postfija.Append(c);
                }
                else if (c == "(")
                {
                    p.Push(c);
                }
                else if (c == ")")
                {
                    while (!p.Estavacio() && p.Peek() != "(")
                    {
                        postfija.Append(p.Pop());
                    }
                    p.Pop();
                }
                else if(EsOperador(c))
                {
                    while (!p.Estavacio() & obtenerPrioridad(p.Peek()) > obtenerPrioridad(c))
                    {
                        postfija.Append(p.Pop());
                    }
                    p.Push(c);
                }
            }

            while (!p.Estavacio())
            {
                postfija.Append(p.Pop());
            }
            return postfija.ToString();
        }
    }
}
