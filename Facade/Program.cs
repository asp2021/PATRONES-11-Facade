using System;

namespace Facade
{
    public class HomeController
    {
        private WifiController _wifiController = new WifiController();
        private AirConditionerController _airconditionerController = new AirConditionerController();
        private LightController _liightController = new LightController();

        public void TurnOn()
        {
            _wifiController.TurnOn();
            _airconditionerController.TurnOn();
            _liightController.TurnOn();

        }

        public void TurnOff()
        {
            _wifiController.TurnOff();
            _airconditionerController.TurnOff();
            _liightController.TurnOff();
        }
    }

    public class LightController
    {
        public void TurnOn()
        {
            Console.WriteLine("Luz is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Luz is off");
        }
    }

    public class AirConditionerController
    {
        public void TurnOn()
        {
            Console.WriteLine("Aire is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Aire is off");
        }
    }

    public class WifiController
    {
        public void TurnOn()
        {
            Console.WriteLine("Wifi is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Wifi is off");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("FACADE" + '\n');
            Console.WriteLine("Permite automatizar unsa serie de acciones." + '\n');


            HomeController homeController = new HomeController();


            Console.WriteLine("Llegando a casa...");
            homeController.TurnOn();
            Console.WriteLine("Saliendo de casa...");
            homeController.TurnOff();

            Console.ReadLine();
        }
    }
}
