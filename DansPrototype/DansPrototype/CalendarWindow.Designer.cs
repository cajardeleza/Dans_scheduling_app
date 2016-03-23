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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Server", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Bartender", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Bus", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Host", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Expo", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Manager", System.Windows.Forms.HorizontalAlignment.Left);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.managerChkBox = new System.Windows.Forms.CheckBox();
            this.expoChkBox = new System.Windows.Forms.CheckBox();
            this.hostChkBox = new System.Windows.Forms.CheckBox();
            this.busChkBox = new System.Windows.Forms.CheckBox();
            this.bartenderChkBox = new System.Windows.Forms.CheckBox();
            this.serverChkBox = new System.Windows.Forms.CheckBox();
            this.addToWorking = new System.Windows.Forms.Button();
            this.addToAvailable = new System.Windows.Forms.Button();
            this.workingList = new System.Windows.Forms.ListView();
            this.availableList = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(187, 29);
            this.monthCalendar1.MaxDate = new System.DateTime(2016, 2, 29, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.MinDate = new System.DateTime(2016, 2, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Currently Working";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available to Work";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.managerChkBox);
            this.groupBox1.Controls.Add(this.expoChkBox);
            this.groupBox1.Controls.Add(this.hostChkBox);
            this.groupBox1.Controls.Add(this.busChkBox);
            this.groupBox1.Controls.Add(this.bartenderChkBox);
            this.groupBox1.Controls.Add(this.serverChkBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // managerChkBox
            // 
            this.managerChkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.managerChkBox.AutoSize = true;
            this.managerChkBox.Location = new System.Drawing.Point(6, 78);
            this.managerChkBox.Name = "managerChkBox";
            this.managerChkBox.Size = new System.Drawing.Size(59, 23);
            this.managerChkBox.TabIndex = 5;
            this.managerChkBox.Text = "Manager";
            this.managerChkBox.UseVisualStyleBackColor = true;
            this.managerChkBox.CheckedChanged += new System.EventHandler(this.managerChkBox_CheckedChanged);
            // 
            // expoChkBox
            // 
            this.expoChkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.expoChkBox.AutoSize = true;
            this.expoChkBox.Location = new System.Drawing.Point(93, 49);
            this.expoChkBox.Name = "expoChkBox";
            this.expoChkBox.Size = new System.Drawing.Size(41, 23);
            this.expoChkBox.TabIndex = 4;
            this.expoChkBox.Text = "Expo";
            this.expoChkBox.UseVisualStyleBackColor = true;
            this.expoChkBox.CheckedChanged += new System.EventHandler(this.expoChkBox_CheckedChanged);
            // 
            // hostChkBox
            // 
            this.hostChkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.hostChkBox.AutoSize = true;
            this.hostChkBox.Location = new System.Drawing.Point(48, 49);
            this.hostChkBox.Name = "hostChkBox";
            this.hostChkBox.Size = new System.Drawing.Size(39, 23);
            this.hostChkBox.TabIndex = 3;
            this.hostChkBox.Text = "Host";
            this.hostChkBox.UseVisualStyleBackColor = true;
            this.hostChkBox.CheckedChanged += new System.EventHandler(this.hostChkBox_CheckedChanged);
            // 
            // busChkBox
            // 
            this.busChkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.busChkBox.AutoSize = true;
            this.busChkBox.Location = new System.Drawing.Point(7, 49);
            this.busChkBox.Name = "busChkBox";
            this.busChkBox.Size = new System.Drawing.Size(35, 23);
            this.busChkBox.TabIndex = 2;
            this.busChkBox.Text = "Bus";
            this.busChkBox.UseVisualStyleBackColor = true;
            this.busChkBox.CheckedChanged += new System.EventHandler(this.busChkBox_CheckedChanged);
            // 
            // bartenderChkBox
            // 
            this.bartenderChkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.bartenderChkBox.AutoSize = true;
            this.bartenderChkBox.Location = new System.Drawing.Point(61, 19);
            this.bartenderChkBox.Name = "bartenderChkBox";
            this.bartenderChkBox.Size = new System.Drawing.Size(63, 23);
            this.bartenderChkBox.TabIndex = 1;
            this.bartenderChkBox.Text = "Bartender";
            this.bartenderChkBox.UseVisualStyleBackColor = true;
            this.bartenderChkBox.CheckedChanged += new System.EventHandler(this.bartenderChkBox_CheckedChanged);
            // 
            // serverChkBox
            // 
            this.serverChkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.serverChkBox.AutoSize = true;
            this.serverChkBox.Location = new System.Drawing.Point(7, 20);
            this.serverChkBox.Name = "serverChkBox";
            this.serverChkBox.Size = new System.Drawing.Size(48, 23);
            this.serverChkBox.TabIndex = 0;
            this.serverChkBox.Text = "Server";
            this.serverChkBox.UseVisualStyleBackColor = true;
            this.serverChkBox.CheckedChanged += new System.EventHandler(this.serverChkBox_CheckedChanged);
            // 
            // addToWorking
            // 
            this.addToWorking.Location = new System.Drawing.Point(583, 146);
            this.addToWorking.Name = "addToWorking";
            this.addToWorking.Size = new System.Drawing.Size(24, 23);
            this.addToWorking.TabIndex = 6;
            this.addToWorking.Text = ">";
            this.addToWorking.UseVisualStyleBackColor = true;
            this.addToWorking.Click += new System.EventHandler(this.addToWorking_Click);
            // 
            // addToAvailable
            // 
            this.addToAvailable.Location = new System.Drawing.Point(583, 175);
            this.addToAvailable.Name = "addToAvailable";
            this.addToAvailable.Size = new System.Drawing.Size(24, 23);
            this.addToAvailable.TabIndex = 7;
            this.addToAvailable.Text = "<";
            this.addToAvailable.UseVisualStyleBackColor = true;
            this.addToAvailable.Click += new System.EventHandler(this.addToAvailable_Click);
            // 
            // workingList
            // 
            this.workingList.Location = new System.Drawing.Point(616, 33);
            this.workingList.Name = "workingList";
            this.workingList.Size = new System.Drawing.Size(145, 286);
            this.workingList.TabIndex = 8;
            this.workingList.UseCompatibleStateImageBehavior = false;
            this.workingList.SelectedIndexChanged += new System.EventHandler(this.workingList_SelectedIndexChanged);
            // 
            // availableList
            // 
            this.availableList.FullRowSelect = true;
            listViewGroup1.Header = "Server";
            listViewGroup1.Name = "serverGroup";
            listViewGroup2.Header = "Bartender";
            listViewGroup2.Name = "bartenderGroup";
            listViewGroup3.Header = "Bus";
            listViewGroup3.Name = "busGroup";
            listViewGroup4.Header = "Host";
            listViewGroup4.Name = "hostGroup";
            listViewGroup5.Header = "Expo";
            listViewGroup5.Name = "expoGroup";
            listViewGroup6.Header = "Manager";
            listViewGroup6.Name = "managerGroup";
            this.availableList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.availableList.Location = new System.Drawing.Point(427, 29);
            this.availableList.Name = "availableList";
            this.availableList.Size = new System.Drawing.Size(150, 290);
            this.availableList.TabIndex = 9;
            this.availableList.UseCompatibleStateImageBehavior = false;
            this.availableList.View = System.Windows.Forms.View.SmallIcon;
            this.availableList.SelectedIndexChanged += new System.EventHandler(this.availableList_SelectedIndexChanged);
            // 
            // CalendarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 326);
            this.Controls.Add(this.availableList);
            this.Controls.Add(this.workingList);
            this.Controls.Add(this.addToAvailable);
            this.Controls.Add(this.addToWorking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "CalendarWindow";
            this.Text = "Calander Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalendarWindow_FormClosing);
            this.Load += new System.EventHandler(this.CalendarWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox busChkBox;
        private System.Windows.Forms.CheckBox bartenderChkBox;
        private System.Windows.Forms.CheckBox serverChkBox;
        private System.Windows.Forms.CheckBox hostChkBox;
        private System.Windows.Forms.CheckBox managerChkBox;
        private System.Windows.Forms.CheckBox expoChkBox;
        private System.Windows.Forms.Button addToWorking;
        private System.Windows.Forms.Button addToAvailable;
        private System.Windows.Forms.ListView workingList;
        private System.Windows.Forms.ListView availableList;
    }
}