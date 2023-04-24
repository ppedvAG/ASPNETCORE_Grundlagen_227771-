namespace OpenClosePrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Salary { get; set; }

    }

    #region Open Close
    public class EmployeeReporter
    {
        public void GenerateReport(Employee em, int reportType)
        {
            if (reportType == 1)
            {
                //Erstelle ein Crystal Report
            }
            else if(reportType == 2)
            {
                //Erstelle List10
            }
            else if (reportType == 3)
            {
                //PDF Report
            }
            else
            {
                //Irgendwas anders 
            }
        }
    }
    #endregion

    #region Better Code

    //Open Part
    public abstract class BaseReportGenerator
    {
        public abstract void GenerateReport(Employee em);   
    }


    public class EmployeeCrystalReporter : BaseReportGenerator
    {
        public override void GenerateReport(Employee em)
        {
            //Report wird erstellt
        }
    }


    public class EmployeeList10Reporter : BaseReportGenerator
    {
        public override void GenerateReport(Employee em)
        {
            //Report wird erstellt
        }
    }
    #endregion
}