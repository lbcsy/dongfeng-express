namespace DongFeng.Launcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseUrl = "BOOK3:8888/DongFeng-Express";
            
            //Download Starter files setting
            var appStarterFiles = new AppStarterFiles()
            {
                StartFile = "CustomerMaintenanceNet48.exe",
                SupportFiles= new string[] {
                    "CustomerMaintenanceNet48.exe.config",
                    "JellyFish.dll"
                }
            };

            new Launcher(baseUrl).Launch();
        }
    }
}
