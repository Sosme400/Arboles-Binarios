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
            // Crear el Árbol Binario 4
            arbol = new ArbolBinario();
            arbol.Raiz = new Nodo("A");

            arbol.Raiz.Izquierdo = new Nodo("B");
            arbol.Raiz.Derecho = new Nodo("C");

            arbol.Raiz.Izquierdo.Izquierdo = new Nodo("D");
            arbol.Raiz.Izquierdo.Derecho = new Nodo("E");
            arbol.Raiz.Izquierdo.Izquierdo.Izquierdo = new Nodo("K");
            arbol.Raiz.Izquierdo.Izquierdo.Derecho = new Nodo("F");

            arbol.Raiz.Izquierdo.Izquierdo.Izquierdo.Izquierdo = new Nodo("Q");
            arbol.Raiz.Izquierdo.Izquierdo.Izquierdo.Derecho = new Nodo("R");

            arbol.Raiz.Derecho.Izquierdo = new Nodo("G");
            arbol.Raiz.Derecho.Derecho = new Nodo("I");

            arbol.Raiz.Derecho.Izquierdo.Derecho = new Nodo("H");
            arbol.Raiz.Derecho.Izquierdo.Derecho.Izquierdo = new Nodo("Ñ");
            arbol.Raiz.Derecho.Izquierdo.Derecho.Derecho = new Nodo("O");
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
