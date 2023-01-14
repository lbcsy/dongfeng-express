using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace DongFeng.Launcher
{
    internal class Downloader
    {
        private readonly string baseUrl ;
        public Downloader(string baseUrl) {
            this.baseUrl = baseUrl;
        }
        public IEnumerable<Task> DownloadInitialFiles(IEnumerable<string> files)
        {
            var downloadTasks = new List<Task>();
            foreach (var file in files)
            {
                Console.WriteLine($"Downloading file {file}");
                downloadTasks.Add(DownloadSingleFile(file));
            }
            return downloadTasks;
        }

        private async Task DownloadSingleFile(string fileName)
        {
            var httpClient = new HttpClient();
            

            using (var stream = await httpClient.GetStreamAsync($"http://{baseUrl}/Package/{fileName}"))
            {
                using (var fileStream = new FileStream(fileName, FileMode.CreateNew))
                {
                    await stream.CopyToAsync(fileStream);
                    Console.WriteLine($"Downloaded file {fileName}");
                }
            }
        }
    }
}