using System.Threading.Channels;

namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    #region Anti-Beispiel
    public class BadEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public decimal Salary { get; set; }

        public void GenerateReport()
        {
            //Erstellt ein Report 
        }

        public void InsertEmployeeToDb (BadEmployee employee)
        {
            //Speichere einen Datensatz in die DB
        }

    }
    #endregion


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    //Repository Design Pattern repräsentieren ein CRUD ((Create, Read, Update, Delete) ->  für eine Tabelle
    public class EmployeeRepository
    {
        public void Insert(Employee employee)
        {
            //Speicher Employee in Db
        }
    }

    public class Reporter
    {
        public void GenerateReport(Employee employee)
            => Console.WriteLine("Report wird erstellt");
    }


}
