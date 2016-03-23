namespace DansPrototype
{
    partial class CalendarWindow
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.managerBtn = new System.Windows.Forms.CheckBox();
            this.hostBtn = new System.Windows.Forms.CheckBox();
            this.expoBtn = new System.Windows.Forms.CheckBox();
            this.busBtn = new System.Windows.Forms.CheckBox();
            this.bartenderBtn = new System.Windows.Forms.CheckBox();
            this.serverBtn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.am_Btn = new System.Windows.Forms.Button();
            this.pmBtn = new System.Windows.Forms.Button();
            this.doubleBtn = new System.Windows.Forms.Button();
            this.selected_Employee = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 154);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(284, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 108);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(284, 218);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(186, 108);
            this.listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(638, 62);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(175, 264);
            this.listBox3.TabIndex = 8;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(303, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = "Sumbit To Schedule";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Currently Working";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Available To Work";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Click on Employee to \r\nadd to currently working";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.managerBtn);
            this.groupBox1.Controls.Add(this.hostBtn);
            this.groupBox1.Controls.Add(this.expoBtn);
            this.groupBox1.Controls.Add(this.busBtn);
            this.groupBox1.Controls.Add(this.bartenderBtn);
            this.groupBox1.Controls.Add(this.serverBtn);
            this.groupBox1.Location = new System.Drawing.Point(18, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 96);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "filter";
            // 
            // managerBtn
            // 
            this.managerBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.managerBtn.AutoSize = true;
            this.managerBtn.Location = new System.Drawing.Point(160, 48);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(64, 23);
            this.managerBtn.TabIndex = 20;
            this.managerBtn.Text = "Managers";
            this.managerBtn.UseVisualStyleBackColor = true;
            this.managerBtn.CheckedChanged += new System.EventHandler(this.managerBtn_CheckedChanged_1);
            // 
            // hostBtn
            // 
            this.hostBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.hostBtn.AutoSize = true;
            this.hostBtn.Location = new System.Drawing.Point(83, 48);
            this.hostBtn.Name = "hostBtn";
            this.hostBtn.Size = new System.Drawing.Size(39, 23);
            this.hostBtn.TabIndex = 19;
            this.hostBtn.Text = "Host\r\n";
            this.hostBtn.UseVisualStyleBackColor = true;
            this.hostBtn.CheckedChanged += new System.EventHandler(this.hostBtn_CheckedChanged_1);
            // 
            // expoBtn
            // 
            this.expoBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.expoBtn.AutoSize = true;
            this.expoBtn.Location = new System.Drawing.Point(6, 48);
            this.expoBtn.Name = "expoBtn";
            this.expoBtn.Size = new System.Drawing.Size(41, 23);
            this.expoBtn.TabIndex = 18;
            this.expoBtn.Text = "Expo";
            this.expoBtn.UseVisualStyleBackColor = true;
            this.expoBtn.CheckedChanged += new System.EventHandler(this.expoBtn_CheckedChanged_1);
            // 
            // busBtn
            // 
            this.busBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.busBtn.AutoSize = true;
            this.busBtn.Location = new System.Drawing.Point(160, 19);
            this.busBtn.Name = "busBtn";
            this.busBtn.Size = new System.Drawing.Size(49, 23);
            this.busBtn.TabIndex = 17;
            this.busBtn.Text = "Busers";
            this.busBtn.UseVisualStyleBackColor = true;
            this.busBtn.CheckedChanged += new System.EventHandler(this.busBtn_CheckedChanged_1);
            // 
            // bartenderBtn
            // 
            this.bartenderBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.bartenderBtn.AutoSize = true;
            this.bartenderBtn.Location = new System.Drawing.Point(83, 19);
            this.bartenderBtn.Name = "bartenderBtn";
            this.bartenderBtn.Size = new System.Drawing.Size(68, 23);
            this.bartenderBtn.TabIndex = 16;
            this.bartenderBtn.Text = "Bartenders";
            this.bartenderBtn.UseVisualStyleBackColor = true;
            this.bartenderBtn.CheckedChanged += new System.EventHandler(this.bartenderBtn_CheckedChanged_1);
            // 
            // serverBtn
            // 
            this.serverBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.serverBtn.AutoSize = true;
            this.serverBtn.Location = new System.Drawing.Point(6, 16);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(53, 23);
            this.serverBtn.TabIndex = 15;
            this.serverBtn.Text = "Servers";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Morning Shift";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Evening Shift";
            // 
            // am_Btn
            // 
            this.am_Btn.Location = new System.Drawing.Point(482, 187);
            this.am_Btn.Name = "am_Btn";
            this.am_Btn.Size = new System.Drawing.Size(35, 28);
            this.am_Btn.TabIndex = 17;
            this.am_Btn.Text = "AM";
            this.am_Btn.UseVisualStyleBackColor = true;
            this.am_Btn.Click += new System.EventHandler(this.am_Btn_Click);
            // 
            // pmBtn
            // 
            this.pmBtn.Location = new System.Drawing.Point(523, 187);
            this.pmBtn.Name = "pmBtn";
            this.pmBtn.Size = new System.Drawing.Size(35, 28);
            this.pmBtn.TabIndex = 18;
            this.pmBtn.Text = "PM";
            this.pmBtn.UseVisualStyleBackColor = true;
            this.pmBtn.Click += new System.EventHandler(this.pmBtn_Click);
            // 
            // doubleBtn
            // 
            this.doubleBtn.Location = new System.Drawing.Point(564, 187);
            this.doubleBtn.Name = "doubleBtn";
            this.doubleBtn.Size = new System.Drawing.Size(68, 28);
            this.doubleBtn.TabIndex = 19;
            this.doubleBtn.Text = "Double";
            this.doubleBtn.UseVisualStyleBackColor = true;
            this.doubleBtn.Click += new System.EventHandler(this.doubleBtn_Click);
            // 
            // selected_Employee
            // 
            this.selected_Employee.Enabled = false;
            this.selected_Employee.Location = new System.Drawing.Point(482, 157);
            this.selected_Employee.Name = "selected_Employee";
            this.selected_Employee.Size = new System.Drawing.Size(150, 20);
            this.selected_Employee.TabIndex = 20;
            // 
            // CalendarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 387);
            this.Controls.Add(this.selected_Employee);
            this.Controls.Add(this.doubleBtn);
            this.Controls.Add(this.pmBtn);
            this.Controls.Add(this.am_Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "CalendarWindow";
            this.Text = "Calander Window";
            this.Load += new System.EventHandler(this.calanderWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox serverBtn;
        private System.Windows.Forms.CheckBox managerBtn;
        private System.Windows.Forms.CheckBox hostBtn;
        private System.Windows.Forms.CheckBox expoBtn;
        private System.Windows.Forms.CheckBox busBtn;
        private System.Windows.Forms.CheckBox bartenderBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button am_Btn;
        private System.Windows.Forms.Button pmBtn;
        private System.Windows.Forms.Button doubleBtn;
        private System.Windows.Forms.TextBox selected_Employee;
    }
}