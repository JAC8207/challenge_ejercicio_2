using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consecionario!!!");
            Console.WriteLine("");
            Console.WriteLine("Autos");
            Console.WriteLine("");

            Auto auto = new Auto();
            auto.ArrancarVehiculo();
            auto.EncenderLuces();
            auto.EncenderRadio();
            auto.ApagarRadio();
            auto.HacerSonarBocina();
            auto.Avanzar();
            auto.Frenar();

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Camiones");
            Console.WriteLine("");
            Camion camion = new Camion();
            camion.ArrancarVehiculo();
            camion.EncenderLuces();
            camion.EncenderRadio();
            camion.ApagarRadio();
            camion.HacerSonarBocina();
            camion.Avanzar();
            camion.Frenar();

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Monopatines");
            Console.WriteLine("");
            Monopatin monopatin  = new Monopatin();
            monopatin.ArrancarVehiculo();
            monopatin.EncenderLuces();
            monopatin.EncenderRadio();
            monopatin.ApagarRadio();
            monopatin.HacerSonarBocina();
            monopatin.Avanzar();
            monopatin.Frenar();

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Bicicletas");
            Console.WriteLine("");
            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Avanzar();
            bicicleta.Frenar();

            Console.ReadLine();

        }
    }

    public class Vehiculo
    {
        public void Avanzar()
        {
            Console.WriteLine("Avanzando!");
        }
        public void Frenar()
        {
            Console.WriteLine("Frenando!");
        }
    }

    public class Auto : Vehiculo, IVehiculos 
    {
        public void ArrancarVehiculo()
        {
            Console.WriteLine("Arrancando Vehiculo");
        }
        public void EncenderRadio()
        {
            Console.WriteLine("Encendiendo radio");
        }
        public void ApagarRadio()
        {
            Console.WriteLine("Apagando radio");
        }
        public void HacerSonarBocina()
        {
            Console.WriteLine("Haciendo sonar la bocina");
        }
        public void EncenderLuces()
        {
            Console.WriteLine("Apagando luces");
        }
    }

    public class Camion : Vehiculo, IVehiculos
    {
        public void ArrancarVehiculo()
        {
            Console.WriteLine("Arrancando Vehiculo");
        }
        public void EncenderRadio()
        {
            Console.WriteLine("Encendiendo radio");
        }
        public void ApagarRadio()
        {
            Console.WriteLine("Apagando radio");
        }
        public void HacerSonarBocina()
        {
            Console.WriteLine("Haciendo sonar la bocina");
        }
        public void EncenderLuces()
        {
            Console.WriteLine("Apagando luces");
        }
    }

    public class Monopatin : Vehiculo, IVehiculos
    {
        public void ArrancarVehiculo()
        {
            Console.WriteLine("Arrancando Vehiculo");
        }
        public void EncenderRadio()
        {
            Console.WriteLine("Encendiendo radio");
        }
        public void ApagarRadio()
        {
            Console.WriteLine("Apagando radio");
        }
        public void HacerSonarBocina()
        {
            Console.WriteLine("Haciendo sonar la bocina");
        }
        public void EncenderLuces()
        {
            Console.WriteLine("Apagando luces");
        }
    }

    public class Bicicleta : Vehiculo
    {

    }

    public interface IVehiculos
    {
        void ArrancarVehiculo();
        void EncenderRadio();
        void ApagarRadio();
        void HacerSonarBocina();
        void EncenderLuces();
    }
}
