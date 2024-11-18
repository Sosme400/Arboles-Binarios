using System.Collections.Generic;

public class ArbolBinario
{
    public Nodo? Raiz;

    public ArbolBinario()
    {
        Raiz = null;
    }

    public List<string> RecorridoEnAmplitud()
    {
        List<string> resultado = new List<string>();
        if (Raiz == null) return resultado;

        Queue<Nodo> cola = new Queue<Nodo>();
        cola.Enqueue(Raiz);

        while (cola.Count > 0)
        {
            Nodo actual = cola.Dequeue();
            resultado.Add(actual.Valor);

            if (actual.Izquierdo != null)
                cola.Enqueue(actual.Izquierdo);
            if (actual.Derecho != null)
                cola.Enqueue(actual.Derecho);
        }

        return resultado;
    }

    public void RecorridoPreorden(Nodo? nodo, List<string> resultado)
    {
        if (nodo == null) return;

        resultado.Add(nodo.Valor);
        RecorridoPreorden(nodo.Izquierdo, resultado);
        RecorridoPreorden(nodo.Derecho, resultado);
    }

    public void RecorridoInorden(Nodo? nodo, List<string> resultado)
    {
        if (nodo == null) return;

        RecorridoInorden(nodo.Izquierdo, resultado);
        resultado.Add(nodo.Valor);
        RecorridoInorden(nodo.Derecho, resultado);
    }

    public void RecorridoPostorden(Nodo? nodo, List<string> resultado)
    {
        if (nodo == null) return;

        RecorridoPostorden(nodo.Izquierdo, resultado);
        RecorridoPostorden(nodo.Derecho, resultado);
        resultado.Add(nodo.Valor);
    }
}