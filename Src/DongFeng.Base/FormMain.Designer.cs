namespace DongFeng.Base
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxBasePath = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxLauncherPath = new System.Windows.Forms.TextBox();
            this.buttonLauncher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBase = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLog = new System.Windows.Forms.Label();
            this.panelLogArea = new System.Windows.Forms.Panel();
            this.panelLog = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogArea.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(838, 421);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxBasePath
            // 
            this.textBoxBasePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBasePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBasePath.Location = new System.Drawing.Point(150, 1);
            this.textBoxBasePath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxBasePath.Name = "textBoxBasePath";
            this.textBoxBasePath.ReadOnly = true;
            this.textBoxBasePath.Size = new System.Drawing.Size(577, 29);
            this.textBoxBasePath.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tableLayoutPanel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(842, 70);
            this.panelTop.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.72117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxLauncherPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonLauncher, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBasePath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonBase, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 70);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textBoxLauncherPath
            // 
            this.textBoxLauncherPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLauncherPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLauncherPath.Location = new System.Drawing.Point(150, 36);
            this.textBoxLauncherPath.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxLauncherPath.Name = "textBoxLauncherPath";
            this.textBoxLauncherPath.ReadOnly = true;
            this.textBoxLauncherPath.Size = new System.Drawing.Size(577, 29);
            this.textBoxLauncherPath.TabIndex = 1;
            // 
            // buttonLauncher
            // 
            this.buttonLauncher.AutoSize = true;
            this.buttonLauncher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLauncher.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLauncher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLauncher.Location = new System.Drawing.Point(753, 36);
            this.buttonLauncher.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.buttonLauncher.Name = "buttonLauncher";
            this.buttonLauncher.Size = new System.Drawing.Size(84, 33);
            this.buttonLauncher.TabIndex = 3;
            this.buttonLauncher.Text = "Browse ...";
            this.buttonLauncher.UseVisualStyleBackColor = true;
            this.buttonLauncher.Click += new System.EventHandler(this.buttonLauncher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Launcher Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "App Base Folder";
            // 
            // buttonBase
            // 
            this.buttonBase.AutoSize = true;
            this.buttonBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBase.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBase.Location = new System.Drawing.Point(753, 1);
            this.buttonBase.Margin = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.buttonBase.Name = "buttonBase";
            this.buttonBase.Size = new System.Drawing.Size(84, 33);
            this.buttonBase.TabIndex = 3;
            this.buttonBase.Text = "Browse ...";
            this.buttonBase.UseVisualStyleBackColor = true;
            this.buttonBase.Click += new System.EventHandler(this.buttonBase_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 32);
            this.panel1.TabIndex = 3;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLog.Location = new System.Drawing.Point(0, 0);
            this.labelLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(36, 21);
            this.labelLog.TabIndex = 0;
            this.labelLog.Text = "Log";
            // 
            // panelLogArea
            // 
            this.panelLogArea.Controls.Add(this.panelLog);
            this.panelLogArea.Controls.Add(this.panel1);
            this.panelLogArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogArea.Location = new System.Drawing.Point(0, 70);
            this.panelLogArea.Name = "panelLogArea";
            this.panelLogArea.Size = new System.Drawing.Size(842, 457);
            this.panelLogArea.TabIndex = 5;
            // 
            // panelLog
            // 
            this.panelLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLog.Controls.Add(this.textBox1);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(0, 32);
            this.panelLog.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(842, 425);
            this.panelLog.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 527);
            this.Controls.Add(this.panelLogArea);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormMain";
            this.Text = "东风基地-Base";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogArea.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxBasePath;
        private Panel panelTop;
        private Label label1;
        private Button buttonBase;
        private FolderBrowserDialog folderBrowserDialog;
        private Panel panel1;
        private Label labelLog;
        private Button buttonLauncher;
        private TextBox textBoxLauncherPath;
        private Label label2;
        private Panel panelLogArea;
        private Panel panelLog;
        private TableLayoutPanel tableLayoutPanel1;
        private OpenFileDialog openFileDialog;
    }
}