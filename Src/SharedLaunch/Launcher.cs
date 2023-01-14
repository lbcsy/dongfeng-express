using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DongFeng.Launcher
{
    public class Launcher
    {        
        private string _baseUrl;
        public Launcher(string baseUrl)
        {
            _baseUrl = baseUrl;
        }
        public void Launch(AppStarterFiles appStarterFiles) {  
            var downloader = new Downloader(_baseUrl);
            
            // download files
            var tasks = downloader.DownloadInitialFiles(
                appStarterFiles.SupportFiles.Append(appStarterFiles.StartFile));

            Task.WaitAll(tasks.ToArray());

            //Launch app
            Process.Start(appStarterFiles.StartFile);
        }
        public void Launch()
        {
            var downloader = new Downloader(_baseUrl);
            // download file list
            var tasks = downloader.DownloadInitialFiles(new string[] { "DongFengBaoguo.txt" });
            Task.WaitAll(tasks.ToArray());

            string fileName = "DongFengBaoguo.txt";
            
            var appStarterFiles = File.ReadLines(fileName);

            // download files
            tasks = downloader.DownloadInitialFiles(appStarterFiles);

            Task.WaitAll(tasks.ToArray());

            //Launch app
            Process.Start(appStarterFiles.First());
        }
    }
}
