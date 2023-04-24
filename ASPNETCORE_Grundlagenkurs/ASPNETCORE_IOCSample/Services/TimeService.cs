namespace ASPNETCORE_IOCSample.Services
{
    public class TimeService : ITimeService
    {
        private string _time;
        public TimeService() 
        { 
            _time = DateTime.Now.ToShortTimeString();

        }
        public string GetTime()
        {
            return _time;
        }
    }

    public class TimeService2 : ITimeService
    {
        private string _time;

        public TimeService2()
        {
            _time = DateTime.Now.ToShortTimeString();

        }
        public string GetTime()
        {
            return _time;
        }
    }
}
