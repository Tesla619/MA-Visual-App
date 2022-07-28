using PC_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_App
{
    public partial class Form1 : Form
    {
        string last_path;
        bool rightclicked;
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            last_path = Settings.Default["last_path"].ToString();
            path_textBox.Text = last_path;
            path_textBox.Enabled = false;
        }

        private void path_button_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (fbd.ShowDialog() == DialogResult.OK
                && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path_textBox.Text = fbd.SelectedPath;
                    Settings.Default["last_path"] = fbd.SelectedPath;
                    Settings.Default.Save();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                fbd.SelectedPath = AskForInput("Enter the folder path:", "User Input");
                path_textBox.Text = fbd.SelectedPath;
                Settings.Default["last_path"] = fbd.SelectedPath;
                Settings.Default.Save();
            }            
        }

        public static string AskForInput(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 50, Top = 25, Text = text };   //top was 20
            TextBox textBox = new TextBox() { Left = 50, Top = 45, Width = 400 }; //top was 50
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            textLabel.AutoSize = true;
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void wrntyNumber_maskedTextBox_Click(object sender, EventArgs e)
        {
            if (wrntyNumber_maskedTextBox.Text == "    -")
                wrntyNumber_maskedTextBox.Text = String.Empty;
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (wrntyNumber_maskedTextBox.Text == "    -")
                MessageBox.Show("You left a field empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //maybe make if conditions to clean string e.g. "187 -22"
                Process();
            }
        }

        private void Process()
        {
            int length = 5;

            for (int i = 0; i < length; i++)
            {
                fbd.SelectedPath = path_textBox.Text;
                Directory.CreateDirectory(fbd.SelectedPath + "\\" + wrntyNumber_maskedTextBox.Text + "#" + (i + 1).ToString());
            }

            //probably recivive images here
            //probably won't need to give warranty number here but will be give via mobile app
        }
    }
}