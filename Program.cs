namespace SensorStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            InvestigationManager manager = new InvestigationManager();
            manager.Start();
        }
    }
}
