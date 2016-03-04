namespace DansPrototype
{
    partial class HomeScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarButton = new System.Windows.Forms.Button();
            this.AvailabilityButton = new System.Windows.Forms.Button();
            this.NewEmployeeButton = new System.Windows.Forms.Button();
            this.ViewSchedButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // calendarButton
            // 
            this.calendarButton.Location = new System.Drawing.Point(30, 142);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(93, 89);
            this.calendarButton.TabIndex = 2;
            this.calendarButton.Text = "Calendar\r\n";
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AvailabilityButton
            // 
            this.AvailabilityButton.Location = new System.Drawing.Point(148, 38);
            this.AvailabilityButton.Name = "AvailabilityButton";
            this.AvailabilityButton.Size = new System.Drawing.Size(93, 84);
            this.AvailabilityButton.TabIndex = 1;
            this.AvailabilityButton.Text = "Availability";
            this.AvailabilityButton.UseVisualStyleBackColor = true;
            this.AvailabilityButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewEmployeeButton
            // 
            this.NewEmployeeButton.Location = new System.Drawing.Point(30, 38);
            this.NewEmployeeButton.Name = "NewEmployeeButton";
            this.NewEmployeeButton.Size = new System.Drawing.Size(93, 84);
            this.NewEmployeeButton.TabIndex = 0;
            this.NewEmployeeButton.Text = "Add New Employee";
            this.NewEmployeeButton.UseVisualStyleBackColor = true;
            this.NewEmployeeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewSchedButton
            // 
            this.ViewSchedButton.Location = new System.Drawing.Point(148, 142);
            this.ViewSchedButton.Name = "ViewSchedButton";
            this.ViewSchedButton.Size = new System.Drawing.Size(93, 89);
            this.ViewSchedButton.TabIndex = 3;
            this.ViewSchedButton.Text = "View Schedule";
            this.ViewSchedButton.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 266);
            this.Controls.Add(this.ViewSchedButton);
            this.Controls.Add(this.NewEmployeeButton);
            this.Controls.Add(this.AvailabilityButton);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeScreen";
            this.Text = "Scheduler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeScreen_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button AvailabilityButton;
        private System.Windows.Forms.Button NewEmployeeButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button ViewSchedButton;



    }
}

