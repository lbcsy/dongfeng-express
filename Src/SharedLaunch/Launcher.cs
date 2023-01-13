using System;
using System.Collections.Generic;
using System.Text;

namespace DongFeng.Launcher
{
    public class Launcher
    {        
        private string _baseUrl;
        public Launcher(baseUrl)
        {
            _baseUrl = _baseUrl;
        }
        public void Launch(AppStarterFiles appStarterFiles) {                    
            // download files
            var downloader = new Downloader(_baseUrl);
            var tasks = downloader.DownloadInitialFiles(
                appStarterFiles.SupportFiles.Append(appStarterFiles.StartFile));

            Task.WaitAll(tasks.ToArray());

            //Launch app
            Process.Start(appStarterFiles.StartFile);
        }
    }
}
