namespace InterfaceSegerationPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    #region BadSample

    public interface IVehicle
    {
        public void Drive();
        public void Fly();
        public void Swim();
    }

    public class Vehicle : IVehicle
    {
        public void Drive()
        {
            
        }

        public void Fly()
        {
            
        }

        public void Swim()
        {
            
        }
    }

    public class AmbVehicle : IVehicle
    {
        public void Drive()
        {
            //....
        }

        public void Fly()
        {
            throw new NotImplementedException(); //Problem liegt hier. 
        }

        public void Swim()
        {
            //...
        }
    }

    #endregion

    public interface IDrive
    {
        public void Drive();
    }

    public interface IFly
    {
        public void Fly();
    }


    public interface ISwim
    {
        public void Swim();
    }


    public class AmphibischesVehcile : ISwim, IDrive
    {
        public void Drive()
        {
            
        }

        public void Swim()
        {
            
        }
    }
}