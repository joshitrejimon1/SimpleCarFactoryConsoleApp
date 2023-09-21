using SimpleFactoryLibrary;
using SimpleFactoryLibrary.Model;

namespace SimpleCarFactoryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoFactory factory = new AutoFactory();
            var car = factory.MakeCar(AutoType.BMW);

            car.Start();
            car.Stop();

        }
    }
}