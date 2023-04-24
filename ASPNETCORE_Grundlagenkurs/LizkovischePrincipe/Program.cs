namespace LizkovischePrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class BadErbeere
    {
        public string GetColor()
            => "red";
    }

    public class BadKirsche : BadErbeere
    {
        public string GetColor()
            => base.GetColor();
    }



    //Bessere Variante 

    public abstract class Fruits
    {
        public abstract string GetColor();
    }

    public class Banane : Fruits
    {
        public override string GetColor()
        {
            return "red";
        }
    }
}