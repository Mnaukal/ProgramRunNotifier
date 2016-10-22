using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Shell32;
using IWshRuntimeLibrary;
using System.Reflection;

namespace ProgramRunNotifier
{   
    public partial class Form1 : Form
    {
        string iconPath = "";
        string fileName = "";

        public Form1()
        {
            InitializeComponent();

            iconPath = AppDomain.CurrentDomain.BaseDirectory + "default.ico";
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            openFileDialog_target.FileName = textBox_path.Text;
            DialogResult result = openFileDialog_target.ShowDialog();

            if(result == System.Windows.Forms.DialogResult.OK)
            {
                textBox_path.Text = openFileDialog_target.FileName;

                fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog_target.FileName);
            }
        }

        private void button_icon_Click(object sender, EventArgs e)
        {
            openFileDialog_icon.FileName = iconPath;
            DialogResult result = openFileDialog_icon.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                iconPath = openFileDialog_icon.FileName;
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (checkBox_desktop.Checked)
            {
                string desktopDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                CreateShortcut(desktopDir);
            }
            if (checkBox_start.Checked)
            {
                string startDir = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
                CreateShortcut(startDir);
            }
            if (checkBox_customLocation.Checked)
            {
                string customDir = textBox_customLocation.Text;
                CreateShortcut(customDir);
            }
        }

        private void CreateShortcut(string path)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(textBox_path.Text))
                {
                    Error("Target path can't be empty");
                    return;
                }

                string shortcutLocation = System.IO.Path.Combine(path, fileName + ".lnk");

                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

                shortcut.Description = fileName;        // The description of the shortcut
                shortcut.IconLocation = iconPath;       // The icon of the shortcut

                shortcut.TargetPath = Assembly.GetExecutingAssembly().Location;

                string arguments;
                if (radioButton_notification.Checked)
                {
                    arguments = "\"" +
                        textBox_path.Text + "\" \"" +           //target path
                        "n" + "\" \"" +                         //type (Notification)
                        textBox_notification.Text + "\"";       //alert (notification) text
                }
                else
                {
                    arguments = "\"" +
                        textBox_path.Text + "\" \"" +           //target path
                        "p" + "\" \"" +                         //type (Process)
                        textBox_process.Text + "\"";            //process to start
                }

                shortcut.Arguments = arguments;
                shortcut.Save();

                Success();
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private void Success()
        {
            label_success.Visible = true;
            label_error.Visible = false;
        }

        private void Error(string message)
        {
            MessageBox.Show(message, "Error");
            label_success.Visible = false;
            label_error.Visible = true;
        }

        private void button_browseProcess_Click(object sender, EventArgs e)
        {
            openFileDialog_process.FileName = textBox_process.Text;
            DialogResult result = openFileDialog_process.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox_process.Text = openFileDialog_process.FileName;
            }
        }

        private void radioButton_notification_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_notification.Checked)
            {
                textBox_notification.Enabled = true;
                textBox_process.Enabled = false;
                button_browseProcess.Enabled = false;
            }
            else if(radioButton_process.Checked)
            {
                textBox_notification.Enabled = false;
                textBox_process.Enabled = true;
                button_browseProcess.Enabled = true;
            }
        }

        private void button_browseCustomLocation_Click(object sender, EventArgs e)
        {
            folderBrowserDialog_customLocation.SelectedPath = textBox_customLocation.Text;
            DialogResult result = folderBrowserDialog_customLocation.ShowDialog();

            if(result == DialogResult.OK)
            {
                textBox_customLocation.Text = folderBrowserDialog_customLocation.SelectedPath;
            }
        }

        private void checkBox_customLocation_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_customLocation.Checked)
            {
                textBox_customLocation.Enabled = true;
                button_browseCustomLocation.Enabled = true;
            }
            else
            {
                textBox_customLocation.Enabled = false;
                button_browseCustomLocation.Enabled = false;
            }
        }
    }
}
