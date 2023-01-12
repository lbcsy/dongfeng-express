using SimpleHttp;
using System.Net;

namespace DongFeng.Base
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string RootPath { get; set; } = ".";
        private string LauncherPath { get; set; } = @".\Laucher.exe";
        private void SetupRoutes()
        {
            var baseUrl = "/DongFeng-Express";
            Route.Before = MyOnBefore;
            Route.Add($"{baseUrl}", (request, response, props) =>
            {
                response.AsText($"<html><body><p>Hello world, you can download the launcher <a href='{baseUrl}/Launcher'>here</a><p></body></html>");
            });

            Route.Add($"{baseUrl}/Package/{{name}}", (req, res, props) =>
            {
                var name = props["name"];
                var fileName = $"{RootPath}\\{name}";
                if (!File.Exists(fileName))
                {
                    res.StatusCode = (int)HttpStatusCode.NotFound;
                    res.AsText("Not found");
                    return;
                }
                res.Headers.Add("Content-Disposition", $"attachment; filename={name}");
                //res.Headers.Add ("filename", "myfile.txt");
                res.AsStream(req, new FileStream(fileName, FileMode.Open, FileAccess.Read));
            });

            Route.Add($"{baseUrl}/Launcher", (req, res, props) =>
            {
                res.Headers.Add("Content-Disposition", "attachment; filename=Launcher.exe");
                //res.Headers.Add ("filename", "myfile.txt");
                res.AsStream(req, new FileStream($"{LauncherPath}", FileMode.Open, FileAccess.Read));
            });

            HttpServer.ListenAsync(8888, CancellationToken.None, Route.OnHttpRequestAsync);
        }
        public bool MyOnBefore(HttpListenerRequest request, HttpListenerResponse response)
        {
            textBox1.BeginInvoke((Action)delegate () {
                textBox1.AppendText($"Receive request: {request.HttpMethod} {request.RawUrl}\r\n");
            }
            );
            return false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBoxBasePath.Text = RootPath;
            folderBrowserDialog.InitialDirectory = AppContext.BaseDirectory;
            SetupRoutes();
        }

        private void buttonBase_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog()==DialogResult.OK)
            {
                textBoxBasePath.Text = folderBrowserDialog.SelectedPath;
                RootPath= folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonLauncher_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxLauncherPath.Text = openFileDialog.FileName;
                LauncherPath = openFileDialog.FileName;
            }
        }
    }
}