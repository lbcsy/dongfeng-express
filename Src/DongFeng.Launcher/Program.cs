namespace DongFeng.Launcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseUrl = "BOOK3:8888/DongFeng-Express";
            
            new Launcher(baseUrl).Launch();
        }
    }
}
