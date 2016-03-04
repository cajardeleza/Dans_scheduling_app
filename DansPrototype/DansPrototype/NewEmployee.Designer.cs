using System;

namespace DansPrototype
{
    partial class NewEmployee
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
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.txtposition = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfname
            // 
            this.txtfname.Enabled = false;
            this.txtfname.Location = new System.Drawing.Point(299, 79);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(116, 20);
            this.txtfname.TabIndex = 1;
            // 
            // txtlastname
            // 
            this.txtlastname.Enabled = false;
            this.txtlastname.Location = new System.Drawing.Point(299, 108);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(116, 20);
            this.txtlastname.TabIndex = 2;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 204);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(85, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Add";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 173);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee List";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(299, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(116, 20);
            this.txtid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Position";
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Enabled = false;
            this.deleteEmployee.Location = new System.Drawing.Point(103, 204);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(87, 23);
            this.deleteEmployee.TabIndex = 6;
            this.deleteEmployee.Text = "Remove";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // txtposition
            // 
            this.txtposition.Enabled = false;
            this.txtposition.FormattingEnabled = true;
            this.txtposition.Items.AddRange(new object[] {
            "Server",
            "Bartender",
            "Bus",
            "Host",
            "Expo",
            "Manager"});
            this.txtposition.Location = new System.Drawing.Point(299, 136);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(116, 21);
            this.txtposition.TabIndex = 3;
            this.txtposition.SelectedIndexChanged += new System.EventHandler(this.txtposition_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(299, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfname);
            this.Name = "NewEmployee";
            this.Text = "Add Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewEmployee_FormClosing);
            this.Load += new System.EventHandler(this.NewEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.ComboBox txtposition;
        private System.Windows.Forms.Button button1;
    }
}