namespace ProgramRunNotifier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog_target = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.label_success = new System.Windows.Forms.Label();
            this.button_icon = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_notification = new System.Windows.Forms.TextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.openFileDialog_icon = new System.Windows.Forms.OpenFileDialog();
            this.radioButton_notification = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_process = new System.Windows.Forms.RadioButton();
            this.textBox_process = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_browseProcess = new System.Windows.Forms.Button();
            this.openFileDialog_process = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_target
            // 
            this.openFileDialog_target.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_error);
            this.groupBox1.Controls.Add(this.label_success);
            this.groupBox1.Controls.Add(this.button_icon);
            this.groupBox1.Controls.Add(this.button_create);
            this.groupBox1.Controls.Add(this.button_browseProcess);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_process);
            this.groupBox1.Controls.Add(this.textBox_notification);
            this.groupBox1.Controls.Add(this.textBox_path);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Shortcut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(149, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "You can change your icon later using file explorer";
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(65, 151);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(85, 25);
            this.label_error.TabIndex = 5;
            this.label_error.Text = "ERROR";
            this.label_error.Visible = false;
            // 
            // label_success
            // 
            this.label_success.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_success.AutoSize = true;
            this.label_success.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_success.ForeColor = System.Drawing.Color.Green;
            this.label_success.Location = new System.Drawing.Point(46, 151);
            this.label_success.Name = "label_success";
            this.label_success.Size = new System.Drawing.Size(118, 25);
            this.label_success.TabIndex = 5;
            this.label_success.Text = "SUCCESS";
            this.label_success.Visible = false;
            // 
            // button_icon
            // 
            this.button_icon.Location = new System.Drawing.Point(11, 118);
            this.button_icon.Name = "button_icon";
            this.button_icon.Size = new System.Drawing.Size(132, 23);
            this.button_icon.TabIndex = 4;
            this.button_icon.Text = "Choose Icon";
            this.button_icon.UseVisualStyleBackColor = true;
            this.button_icon.Click += new System.EventHandler(this.button_icon_Click);
            // 
            // button_create
            // 
            this.button_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_create.Location = new System.Drawing.Point(211, 149);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(142, 34);
            this.button_create.TabIndex = 3;
            this.button_create.Text = "Create Desktop Shortcut";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_browse
            // 
            this.button_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browse.Location = new System.Drawing.Point(262, 19);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(88, 20);
            this.button_browse.TabIndex = 2;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target Path";
            // 
            // textBox_notification
            // 
            this.textBox_notification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_notification.Location = new System.Drawing.Point(151, 45);
            this.textBox_notification.Name = "textBox_notification";
            this.textBox_notification.Size = new System.Drawing.Size(199, 20);
            this.textBox_notification.TabIndex = 0;
            // 
            // textBox_path
            // 
            this.textBox_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_path.Location = new System.Drawing.Point(96, 19);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(160, 20);
            this.textBox_path.TabIndex = 0;
            // 
            // openFileDialog_icon
            // 
            this.openFileDialog_icon.FileName = "openFileDialog1";
            this.openFileDialog_icon.Filter = "icon file | *.ico";
            // 
            // radioButton_notification
            // 
            this.radioButton_notification.AutoSize = true;
            this.radioButton_notification.Checked = true;
            this.radioButton_notification.Location = new System.Drawing.Point(5, 1);
            this.radioButton_notification.Name = "radioButton_notification";
            this.radioButton_notification.Size = new System.Drawing.Size(78, 17);
            this.radioButton_notification.TabIndex = 7;
            this.radioButton_notification.TabStop = true;
            this.radioButton_notification.Text = "Notification";
            this.radioButton_notification.UseVisualStyleBackColor = true;
            this.radioButton_notification.CheckedChanged += new System.EventHandler(this.radioButton_notification_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_process);
            this.panel1.Controls.Add(this.radioButton_notification);
            this.panel1.Location = new System.Drawing.Point(6, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 46);
            this.panel1.TabIndex = 8;
            // 
            // radioButton_process
            // 
            this.radioButton_process.AutoSize = true;
            this.radioButton_process.Location = new System.Drawing.Point(5, 27);
            this.radioButton_process.Name = "radioButton_process";
            this.radioButton_process.Size = new System.Drawing.Size(87, 17);
            this.radioButton_process.TabIndex = 7;
            this.radioButton_process.Text = "Start process";
            this.radioButton_process.UseVisualStyleBackColor = true;
            this.radioButton_process.CheckedChanged += new System.EventHandler(this.radioButton_notification_CheckedChanged);
            // 
            // textBox_process
            // 
            this.textBox_process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_process.Enabled = false;
            this.textBox_process.Location = new System.Drawing.Point(151, 71);
            this.textBox_process.Name = "textBox_process";
            this.textBox_process.Size = new System.Drawing.Size(105, 20);
            this.textBox_process.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Path";
            // 
            // button_browseProcess
            // 
            this.button_browseProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browseProcess.Enabled = false;
            this.button_browseProcess.Location = new System.Drawing.Point(262, 71);
            this.button_browseProcess.Name = "button_browseProcess";
            this.button_browseProcess.Size = new System.Drawing.Size(88, 20);
            this.button_browseProcess.TabIndex = 2;
            this.button_browseProcess.Text = "Browse";
            this.button_browseProcess.UseVisualStyleBackColor = true;
            this.button_browseProcess.Click += new System.EventHandler(this.button_browseProcess_Click);
            // 
            // openFileDialog_process
            // 
            this.openFileDialog_process.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 213);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Program Run Notifier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_target;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_notification;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_icon;
        private System.Windows.Forms.OpenFileDialog openFileDialog_icon;
        private System.Windows.Forms.Label label_success;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_process;
        private System.Windows.Forms.RadioButton radioButton_notification;
        private System.Windows.Forms.Button button_browseProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_process;
        private System.Windows.Forms.OpenFileDialog openFileDialog_process;
    }
}

