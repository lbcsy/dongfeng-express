using System;
using System.IO;
using System.Net;
using System.Reflection;

namespace DongFeng.Jellyfish
{
    /// <summary>
    /// Code examples:
    /// https://github.com/NuGet/NuGet.Client/blob/639386d6542607b60edeeff17a5d5375449fcf27/src/NuGet.Clients/NuGet.CommandLine/Common/MSBuildUser.cs
    /// </summary>
    public class AppAssemblyResolveEventHandler
    {
        public static string BaseUrl;
        public AppAssemblyResolveEventHandler(string baseUrl)
        {
            BaseUrl = baseUrl;            
        }
        public AppAssemblyResolveEventHandler() { 
            // Should read base url from application's configuration, one option is via an DI which will be provided from
            // the application
        }
        public void Init()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;

            currentDomain.AssemblyResolve += new ResolveEventHandler(Handler);
        }
        public Assembly Handler(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);

            if (assemblyName.Name.EndsWith(".resources")) return null;

            var assemblyFileName = $"{assemblyName.Name}.DLL";

            DownloadAssembly(assemblyFileName);

            try
            {
                return Assembly.LoadFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, assemblyFileName));                
            }
            catch (Exception ex)
            {
                return null;

            }
        }
        private static void DownloadAssembly(string assemblyFileName)
        {
            if (!File.Exists($"{assemblyFileName}"))
            //make sure folder created before download file
            {
                var dir = Path.GetDirectoryName(assemblyFileName);
                if (!string.IsNullOrEmpty(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                using (var client = new WebClient())
                {
                    client.DownloadFile($"http://{BaseUrl}/Package/{assemblyFileName}", assemblyFileName);
                }
            }
        }

        public static void CheckResourceFile(string filePath)
        {
            if (File.Exists(filePath)) return;

            var fullPath = Path.GetFullPath(filePath);

            if (fullPath.StartsWith(AppContext.BaseDirectory))
            {
                DownloadAssembly(filePath);
            }
        }
    }
}
