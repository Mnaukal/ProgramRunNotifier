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

            iconPath = AppDomain.CurrentDomain.BaseDirectory + "m.ico";
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
            try
            {
                string desktopDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string shortcutLocation = System.IO.Path.Combine(desktopDir, fileName + ".lnk");

                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

                shortcut.Description = fileName;        // The description of the shortcut
                shortcut.IconLocation = iconPath;       // The icon of the shortcut

                shortcut.TargetPath = Assembly.GetExecutingAssembly().Location;

                string arguments;
                if(radioButton_notification.Checked)
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

                label_success.Visible = true;
                label_error.Visible = false;
            }
            catch
            {
                label_success.Visible = false;
                label_error.Visible = true;
            }
        }

        private void button_browseProcess_Click(object sender, EventArgs e)
        {
            openFileDialog_process.FileName = textBox_process.Text;
            DialogResult result = openFileDialog_process.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                textBox_process.Text = openFileDialog_process.FileName;

                //fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog_target.FileName);
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
    }
}
