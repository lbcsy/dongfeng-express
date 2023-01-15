using System;

namespace DongFeng.Launcher
{
    [Serializable]
    public class AppStarterFiles
    {
        public string StartFile { get; set;}
        public string[] SupportFiles { get; set; } = new string[0];
    }
}
