public class Nodo
{
    public string Valor;
    public Nodo? Izquierdo;
    public Nodo? Derecho;

    public Nodo(string valor)
    {
        Valor = valor;
        Izquierdo = null;
        Derecho = null;
    }
}
