namespace DansPrototype
{
    partial class AvailabilityWindow
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.selectedList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.managerBtn = new System.Windows.Forms.CheckBox();
            this.expoBtn = new System.Windows.Forms.CheckBox();
            this.hostBtn = new System.Windows.Forms.CheckBox();
            this.busBtn = new System.Windows.Forms.CheckBox();
            this.bartenderBtn = new System.Windows.Forms.CheckBox();
            this.serverBtn = new System.Windows.Forms.CheckBox();
            this.amBtn = new System.Windows.Forms.CheckBox();
            this.pmBtn = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(255, 27);
            this.monthCalendar1.MaxDate = new System.DateTime(2016, 2, 29, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.MinDate = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Chose Employee";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on the days the Employee requests off.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submitBtn
            // 
            this.submitBtn.Enabled = false;
            this.submitBtn.Location = new System.Drawing.Point(516, 235);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(156, 32);
            this.submitBtn.TabIndex = 17;
            this.submitBtn.Text = "Submit Availability";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectedList
            // 
            this.selectedList.ColumnWidth = 50;
            this.selectedList.Enabled = false;
            this.selectedList.FormattingEnabled = true;
            this.selectedList.Location = new System.Drawing.Point(516, 30);
            this.selectedList.MultiColumn = true;
            this.selectedList.Name = "selectedList";
            this.selectedList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectedList.Size = new System.Drawing.Size(156, 147);
            this.selectedList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Off Days";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.managerBtn);
            this.groupBox1.Controls.Add(this.expoBtn);
            this.groupBox1.Controls.Add(this.hostBtn);
            this.groupBox1.Controls.Add(this.busBtn);
            this.groupBox1.Controls.Add(this.bartenderBtn);
            this.groupBox1.Controls.Add(this.serverBtn);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 83);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // managerBtn
            // 
            this.managerBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.managerBtn.AutoSize = true;
            this.managerBtn.Location = new System.Drawing.Point(53, 48);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(59, 23);
            this.managerBtn.TabIndex = 5;
            this.managerBtn.Text = "Manager";
            this.managerBtn.UseVisualStyleBackColor = true;
            this.managerBtn.CheckedChanged += new System.EventHandler(this.managerBtn_CheckedChanged);
            // 
            // expoBtn
            // 
            this.expoBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.expoBtn.AutoSize = true;
            this.expoBtn.Location = new System.Drawing.Point(6, 48);
            this.expoBtn.Name = "expoBtn";
            this.expoBtn.Size = new System.Drawing.Size(41, 23);
            this.expoBtn.TabIndex = 4;
            this.expoBtn.Text = "Expo";
            this.expoBtn.UseVisualStyleBackColor = true;
            this.expoBtn.CheckedChanged += new System.EventHandler(this.expoBtn_CheckedChanged);
            // 
            // hostBtn
            // 
            this.hostBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.hostBtn.AutoSize = true;
            this.hostBtn.Location = new System.Drawing.Point(170, 19);
            this.hostBtn.Name = "hostBtn";
            this.hostBtn.Size = new System.Drawing.Size(39, 23);
            this.hostBtn.TabIndex = 3;
            this.hostBtn.Text = "Host";
            this.hostBtn.UseVisualStyleBackColor = true;
            this.hostBtn.CheckedChanged += new System.EventHandler(this.hostBtn_CheckedChanged);
            // 
            // busBtn
            // 
            this.busBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.busBtn.AutoSize = true;
            this.busBtn.Location = new System.Drawing.Point(129, 19);
            this.busBtn.Name = "busBtn";
            this.busBtn.Size = new System.Drawing.Size(35, 23);
            this.busBtn.TabIndex = 2;
            this.busBtn.Text = "Bus";
            this.busBtn.UseVisualStyleBackColor = true;
            this.busBtn.CheckedChanged += new System.EventHandler(this.busBtn_CheckedChanged);
            // 
            // bartenderBtn
            // 
            this.bartenderBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.bartenderBtn.AutoSize = true;
            this.bartenderBtn.Location = new System.Drawing.Point(60, 19);
            this.bartenderBtn.Name = "bartenderBtn";
            this.bartenderBtn.Size = new System.Drawing.Size(63, 23);
            this.bartenderBtn.TabIndex = 1;
            this.bartenderBtn.Text = "Bartender";
            this.bartenderBtn.UseVisualStyleBackColor = true;
            this.bartenderBtn.CheckedChanged += new System.EventHandler(this.bartenderBtn_CheckedChanged);
            // 
            // serverBtn
            // 
            this.serverBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.serverBtn.AutoSize = true;
            this.serverBtn.Location = new System.Drawing.Point(6, 19);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(48, 23);
            this.serverBtn.TabIndex = 0;
            this.serverBtn.Text = "Server";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.CheckedChanged += new System.EventHandler(this.serverBtn_CheckedChanged);
            // 
            // amBtn
            // 
            this.amBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.amBtn.AutoSize = true;
            this.amBtn.Enabled = false;
            this.amBtn.Location = new System.Drawing.Point(555, 184);
            this.amBtn.Name = "amBtn";
            this.amBtn.Size = new System.Drawing.Size(33, 23);
            this.amBtn.TabIndex = 15;
            this.amBtn.Text = "AM";
            this.amBtn.UseVisualStyleBackColor = true;
            this.amBtn.CheckedChanged += new System.EventHandler(this.amBtn_CheckedChanged);
            // 
            // pmBtn
            // 
            this.pmBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.pmBtn.AutoSize = true;
            this.pmBtn.Enabled = false;
            this.pmBtn.Location = new System.Drawing.Point(594, 184);
            this.pmBtn.Name = "pmBtn";
            this.pmBtn.Size = new System.Drawing.Size(33, 23);
            this.pmBtn.TabIndex = 16;
            this.pmBtn.Text = "PM";
            this.pmBtn.UseVisualStyleBackColor = true;
            this.pmBtn.CheckedChanged += new System.EventHandler(this.pmBtn_CheckedChanged);
            // 
            // AvailabilityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 317);
            this.Controls.Add(this.pmBtn);
            this.Controls.Add(this.amBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedList);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "AvailabilityWindow";
            this.Text = "Availability";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AvailabilityWindow_FormClosing);
            this.Shown += new System.EventHandler(this.AvailabilityWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ListBox selectedList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox serverBtn;
        private System.Windows.Forms.CheckBox busBtn;
        private System.Windows.Forms.CheckBox bartenderBtn;
        private System.Windows.Forms.CheckBox managerBtn;
        private System.Windows.Forms.CheckBox expoBtn;
        private System.Windows.Forms.CheckBox hostBtn;
        private System.Windows.Forms.CheckBox amBtn;
        private System.Windows.Forms.CheckBox pmBtn;
    }
}