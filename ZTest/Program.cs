class Animal { }
class Perro : Animal { }
class Gato : Animal { }
interface IProcesador<in T> //contravarianza generics
{
    void Procesar(T item);
}
class ProcesadorAnimal : IProcesador<Animal> 
{
    public void Procesar(Animal a)public class Sensor
    {
        public static event EventHandler TemperaturaDetectada;

        public static void Detectar()
        {
            Console.WriteLine("Temperatura detectada (estática).");
            TemperaturaDetectada?.Invoke(null, EventArgs.Empty);
        }
    }

    class Programa
    {
        static void Main()
        {
            Sensor.TemperaturaDetectada += (s, e) => Console.WriteLine("⚠ Evento estático recibido");
            Sensor.Detectar();
        }
    }

    {
        Console.WriteLine("Procesando un animal");
    }
}
class Program
{
    static void Main()
    {
        IProcesador<Perro> procesador = new ProcesadorAnimal(); //contravarianza IProcesador<Animal> -> IProcesador<Perro>
        procesador.Procesar(new Perro());
    }
}
