using PilasColasColasDobles.Colas;
using PilasColasColasDobles.Pilas;

namespace PilasColasColasDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probar Puesto de Limonadas");
            ProbarPuestoLimonadas();
        }

        static void ProbarPuestoLimonadas()
        {
            int[] puesto1 = { 5, 5, 5, 10, 20 };
            int[] puesto2 = { 5, 5, 10, 10, 20 };
            int[] puesto3 = { 10, 10 };
            int[] puesto4 = { 5, 5, 10 };

            Console.WriteLine($"Puesto 1: {PuestoLimonadas(puesto1)}");
            Console.WriteLine($"Puesto 2: {PuestoLimonadas(puesto2)}");
            Console.WriteLine($"Puesto 3: {PuestoLimonadas(puesto3)}");
            Console.WriteLine($"Puesto 4: {PuestoLimonadas(puesto4)}");
        }

        static bool PuestoLimonadas(int[] billetes)
        {
            Cola<int> filaClientes = new Cola<int>();
            Pila<int> cambio = new Pila<int>();


            foreach (var billete in billetes)
                filaClientes.Encolar(billete);

            while (!filaClientes.EstaVacia())
            {
                int billete = filaClientes.Desencolar();

                if (billete == 5)
                {
                    cambio.Apilar(5);
                }
                else if (billete == 10)
                {
                    if (!cambio.EstaVacia() && cambio.VerTope() == 5)
                    {
                        cambio.Desapilar();
                        cambio.Apilar(10);
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (billete == 20)
                {
                    if (!cambio.EstaVacia() && cambio.VerTope() == 10)
                    {
                        cambio.Desapilar();
                        if (!cambio.EstaVacia() && cambio.VerTope() == 5)
                        {
                            cambio.Desapilar();
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (cambio.ObtenerLongitud() >= 3)
                    {

                        cambio.Desapilar();
                        cambio.Desapilar();
                        cambio.Desapilar();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
