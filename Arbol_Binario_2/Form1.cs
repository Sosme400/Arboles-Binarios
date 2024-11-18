using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ArbolBinarioApp
{
    public partial class Form1 : Form
    {
        private ArbolBinario arbol;

        public Form1()
        {
            InitializeComponent();
            CrearArbol();
        }

        private void CrearArbol()
        {
            // Crear el árbol binario del ejemplo 2
            arbol = new ArbolBinario();
            arbol.Raiz = new Nodo("F");
            arbol.Raiz.Izquierdo = new Nodo("B");
            arbol.Raiz.Derecho = new Nodo("G");

            arbol.Raiz.Izquierdo.Izquierdo = new Nodo("A");
            arbol.Raiz.Izquierdo.Derecho = new Nodo("D");
            arbol.Raiz.Izquierdo.Derecho.Izquierdo = new Nodo("C");
            arbol.Raiz.Izquierdo.Derecho.Derecho = new Nodo("E");

            arbol.Raiz.Derecho.Derecho = new Nodo("I");
            arbol.Raiz.Derecho.Derecho.Izquierdo = new Nodo("H");
        }

        private void btnAmplitud_Click(object sender, EventArgs e)
        {
            List<string> resultado = arbol.RecorridoEnAmplitud();
            textBoxResultado.Text = string.Join(", ", resultado);
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            List<string> resultado = new List<string>();
            arbol.RecorridoPreorden(arbol.Raiz, resultado);
            textBoxResultado.Text = string.Join(", ", resultado);
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            List<string> resultado = new List<string>();
            arbol.RecorridoInorden(arbol.Raiz, resultado);
            textBoxResultado.Text = string.Join(", ", resultado);
        }

        private void btnPostorden_Click(object sender, EventArgs e)
        {
            List<string> resultado = new List<string>();
            arbol.RecorridoPostorden(arbol.Raiz, resultado);
            textBoxResultado.Text = string.Join(", ", resultado);
        }
    }
}
