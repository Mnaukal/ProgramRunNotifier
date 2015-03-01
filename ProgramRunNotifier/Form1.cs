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
            string desktopDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string shortcutLocation = System.IO.Path.Combine(desktopDir, fileName + ".lnk");

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = fileName;        // The description of the shortcut
            shortcut.IconLocation = iconPath;       // The icon of the shortcut

            shortcut.TargetPath = Assembly.GetExecutingAssembly().Location;
            shortcut.Arguments = "\"" + 
                textBox_path.Text + "\" \"" +           //target path
                textBox_notification.Text + "\"";       //alert (notification) text
            shortcut.Save();

            label_success.Text = "SUCCESS";
        }        
    }
}
