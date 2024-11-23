namespace PilasColasColasDobles.Colas
{
    public class Cola<T>
    {
        private List<T> elementos;

        public Cola()
        {
            elementos = new List<T>();
        }

        public void Encolar(T elemento)
        {
            elementos.Add(elemento);
        }

        public T Desencolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            T primero = elementos[0];
            elementos.RemoveAt(0);
            return primero;
        }

        public T VerPrimero()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía.");

            return elementos[0];
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
