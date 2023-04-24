using Microsoft.Extensions.DependencyInjection;

namespace IOCSample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Initalisierung des IOC Containers (Hinzufügen von DIENSTEN)
            IServiceCollection services = new ServiceCollection();
            
            services.AddSingleton<ICar, TestCar>(); //Legen die Klasse 

            IServiceProvider serviceProvider = services.BuildServiceProvider(); //Nach BuildServiceProvider ist die Initialisierung - Phase fertig

            #endregion

            #region Zugriff auf den IOC Container


            //serviceProvider.GetService<ICar>(); -> Wenn ICar nicht im IOC Container ist, wird NULL zurück gegeben
            ICar? car = serviceProvider.GetService<ICar>();


            //GetRequiredService liefert eine Exception, wenn im IOC - Container keine ICar gefunden wird
            ICar car2 = serviceProvider.GetRequiredService<ICar>();

            #endregion

        }
    }


    #region Better Code

    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }

        int ConstructionYear { get; set; }
    }

    public interface ICarService
    {
        void Repair(ICar car);

    }

    //Programmierer A: 5 Tage
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ConstructionYear { get; set; }
    }


    //Programmierer B: 3 Tage
    public class CarService : ICarService
    {
        public void Repair(ICar car) //Lose Kopplung
        {
            //Auto wiord repariert
        }
    }

    //Programmierer B könnte jetzt mit Mock-Objekten arbeiten
    public class TestCar : ICar
    {
        public string Brand { get; set; } = "VW";
        public string Model { get; set; } = "POLO";
        public int ConstructionYear { get; set; } = 2020;
    }

    #endregion
}