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
            // Crear el árbol binario del ejemplo
            arbol = new ArbolBinario();
            arbol.Raiz = new Nodo("h");
            arbol.Raiz.Izquierdo = new Nodo("i");
            arbol.Raiz.Derecho = new Nodo("m");
            arbol.Raiz.Izquierdo.Izquierdo = new Nodo("e");
            arbol.Raiz.Derecho.Derecho = new Nodo("a");
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
