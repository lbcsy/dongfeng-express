using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(System.IO.Path.GetDirectoryName(Application.ExecutablePath));
            button1.Visible = false;
            button2.Visible= true;
            textBox1.Text = "As you can see, there is no Newtonsoft.Json.DLL. Press above button to serialize an EventArgs object to JSON by using Newtonsoft.Json.DLL, it will be downloaed on the fly.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Newtonsoft.Json.JsonConvert.SerializeObject(e));
            textBox1.Text = "Go back to application folder to check if Newtonsoft.Json.DLL is there.";
        }
    }
    
}
