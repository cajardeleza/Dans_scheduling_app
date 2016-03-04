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
            this.button1 = new System.Windows.Forms.Button();
            this.Selected = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bartenderBtn = new System.Windows.Forms.Button();
            this.serverBtn = new System.Windows.Forms.Button();
            this.busBtn = new System.Windows.Forms.Button();
            this.hostBtn = new System.Windows.Forms.Button();
            this.expoBtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.managerBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
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
            this.comboBox1.Location = new System.Drawing.Point(34, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Chose Employee";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click on the days the Employee requests off.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit Availability";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Selected
            // 
            this.Selected.ColumnWidth = 50;
            this.Selected.FormattingEnabled = true;
            this.Selected.Location = new System.Drawing.Point(516, 30);
            this.Selected.MultiColumn = true;
            this.Selected.Name = "Selected";
            this.Selected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Selected.Size = new System.Drawing.Size(156, 147);
            this.Selected.TabIndex = 5;
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
            // bartenderBtn
            // 
            this.bartenderBtn.Location = new System.Drawing.Point(6, 55);
            this.bartenderBtn.Name = "bartenderBtn";
            this.bartenderBtn.Size = new System.Drawing.Size(203, 24);
            this.bartenderBtn.TabIndex = 0;
            this.bartenderBtn.Text = "Bartender";
            this.bartenderBtn.UseVisualStyleBackColor = true;
            // 
            // serverBtn
            // 
            this.serverBtn.Location = new System.Drawing.Point(6, 27);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(203, 22);
            this.serverBtn.TabIndex = 0;
            this.serverBtn.Text = "Server";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // busBtn
            // 
            this.busBtn.Location = new System.Drawing.Point(6, 85);
            this.busBtn.Name = "busBtn";
            this.busBtn.Size = new System.Drawing.Size(203, 24);
            this.busBtn.TabIndex = 0;
            this.busBtn.Text = "Bus";
            this.busBtn.UseVisualStyleBackColor = true;
            // 
            // hostBtn
            // 
            this.hostBtn.Location = new System.Drawing.Point(6, 115);
            this.hostBtn.Name = "hostBtn";
            this.hostBtn.Size = new System.Drawing.Size(203, 24);
            this.hostBtn.TabIndex = 0;
            this.hostBtn.Text = "Host";
            this.hostBtn.UseVisualStyleBackColor = true;
            // 
            // expoBtn
            // 
            this.expoBtn.Location = new System.Drawing.Point(6, 145);
            this.expoBtn.Name = "expoBtn";
            this.expoBtn.Size = new System.Drawing.Size(203, 22);
            this.expoBtn.TabIndex = 0;
            this.expoBtn.Text = "Expo";
            this.expoBtn.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(516, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "AM";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(597, 193);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "PM";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.managerBtn);
            this.groupBox1.Controls.Add(this.expoBtn);
            this.groupBox1.Controls.Add(this.hostBtn);
            this.groupBox1.Controls.Add(this.busBtn);
            this.groupBox1.Controls.Add(this.serverBtn);
            this.groupBox1.Controls.Add(this.bartenderBtn);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // managerBtn
            // 
            this.managerBtn.Location = new System.Drawing.Point(6, 173);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(203, 23);
            this.managerBtn.TabIndex = 1;
            this.managerBtn.Text = "Manager";
            this.managerBtn.UseVisualStyleBackColor = true;
            // 
            // AvailabilityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Selected);
            this.Controls.Add(this.button1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Selected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bartenderBtn;
        private System.Windows.Forms.Button serverBtn;
        private System.Windows.Forms.Button busBtn;
        private System.Windows.Forms.Button hostBtn;
        private System.Windows.Forms.Button expoBtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button managerBtn;
    }
}