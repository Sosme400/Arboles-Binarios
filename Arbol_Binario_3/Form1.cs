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
            // Crear el Árbol Binario 3
            arbol = new ArbolBinario();
            arbol.Raiz = new Nodo("55");

            arbol.Raiz.Izquierdo = new Nodo("53");
            arbol.Raiz.Derecho = new Nodo("59");

            arbol.Raiz.Izquierdo.Izquierdo = new Nodo("48");
            arbol.Raiz.Izquierdo.Derecho = new Nodo("54");

            arbol.Raiz.Izquierdo.Izquierdo.Derecho = new Nodo("51");

            arbol.Raiz.Derecho.Izquierdo = new Nodo("56");
            arbol.Raiz.Derecho.Derecho = new Nodo("63");

            arbol.Raiz.Derecho.Izquierdo.Derecho = new Nodo("57");
            arbol.Raiz.Derecho.Derecho.Izquierdo = new Nodo("61");
            arbol.Raiz.Derecho.Derecho.Derecho = new Nodo("70");
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
