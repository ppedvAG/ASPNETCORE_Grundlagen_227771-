namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programmierer B

            ICarService carService =new CarService();
            carService.Repair(new TestCar()); //Funktionert meine Methode?

            // WEnn Programmmier A fertig mit Klasse Car ist ->
            carService.Repair(new Car());
        }
    }

    #region BadCode
   
    //Programmier A: 5 Tage (Tag1 - Tag5)
    public class BadCar
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int ConstructionYear { get; set; }
    }

    //Programmier B: 3 Tage (Tag5/6 bis Tag 8/9)
    public class BadCarService
    {
        public void Repair(BadCar car) // Feste Kopplung (Wechselwirkungen bekommen wir mit) 
        {

            Console.WriteLine("Auto wird repariert " + car.Model);
        }
    }

    #endregion

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