namespace PilasColasColasDobles.Pilas
{
    public class Pila<T>
    {
        private List<T> elementos;

        public Pila()
        {
            elementos = new List<T>();
        }

        public void Apilar(T elemento)
        {
            elementos.Add(elemento);
        }

        public T Desapilar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacía.");

            T tope = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return tope;
        }

        public T VerTope()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La pila está vacía.");

            return elementos[elementos.Count - 1];
        }

        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        public int ObtenerLongitud()
        {
            return elementos.Count;
        }
    }
}
