namespace WATS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Assign_Unassign_Office_Assets_Button = new System.Windows.Forms.Button();
            this.Assign_Unassign_Computer_Assets_Button = new System.Windows.Forms.Button();
            this.Create_Inactivate_Employees_Button = new System.Windows.Forms.Button();
            this.Create_Inactivate_Offices_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Test_Database_Connection_Button = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Create_Dispose_Assets_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Show_All_Offices_Button = new System.Windows.Forms.Button();
            this.Show_All_Assets_Button = new System.Windows.Forms.Button();
            this.Show_All_Office_Assets_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1168, 81);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Assign_Unassign_Office_Assets_Button
            // 
            this.Assign_Unassign_Office_Assets_Button.Location = new System.Drawing.Point(10, 104);
            this.Assign_Unassign_Office_Assets_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Assign_Unassign_Office_Assets_Button.Name = "Assign_Unassign_Office_Assets_Button";
            this.Assign_Unassign_Office_Assets_Button.Size = new System.Drawing.Size(215, 24);
            this.Assign_Unassign_Office_Assets_Button.TabIndex = 1;
            this.Assign_Unassign_Office_Assets_Button.Text = "Assign \\ Unassign Office Assets";
            this.Assign_Unassign_Office_Assets_Button.UseVisualStyleBackColor = true;
            this.Assign_Unassign_Office_Assets_Button.Click += new System.EventHandler(this.Assign_Unassign_Office_Assets_Button_Click);
            // 
            // Assign_Unassign_Computer_Assets_Button
            // 
            this.Assign_Unassign_Computer_Assets_Button.Location = new System.Drawing.Point(10, 144);
            this.Assign_Unassign_Computer_Assets_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Assign_Unassign_Computer_Assets_Button.Name = "Assign_Unassign_Computer_Assets_Button";
            this.Assign_Unassign_Computer_Assets_Button.Size = new System.Drawing.Size(215, 24);
            this.Assign_Unassign_Computer_Assets_Button.TabIndex = 2;
            this.Assign_Unassign_Computer_Assets_Button.Text = "Assign \\ Unassign Computer Assets";
            this.Assign_Unassign_Computer_Assets_Button.UseVisualStyleBackColor = true;
            this.Assign_Unassign_Computer_Assets_Button.Click += new System.EventHandler(this.Assign_Unassign_Computer_Assets_Button_Click);
            // 
            // Create_Inactivate_Employees_Button
            // 
            this.Create_Inactivate_Employees_Button.Location = new System.Drawing.Point(10, 216);
            this.Create_Inactivate_Employees_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Create_Inactivate_Employees_Button.Name = "Create_Inactivate_Employees_Button";
            this.Create_Inactivate_Employees_Button.Size = new System.Drawing.Size(215, 24);
            this.Create_Inactivate_Employees_Button.TabIndex = 3;
            this.Create_Inactivate_Employees_Button.Text = "Create \\ Inactivate Employees";
            this.Create_Inactivate_Employees_Button.UseVisualStyleBackColor = true;
            this.Create_Inactivate_Employees_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Create_Inactivate_Offices_Button
            // 
            this.Create_Inactivate_Offices_Button.Location = new System.Drawing.Point(10, 252);
            this.Create_Inactivate_Offices_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Create_Inactivate_Offices_Button.Name = "Create_Inactivate_Offices_Button";
            this.Create_Inactivate_Offices_Button.Size = new System.Drawing.Size(215, 24);
            this.Create_Inactivate_Offices_Button.TabIndex = 4;
            this.Create_Inactivate_Offices_Button.Text = "Create \\ Inactivate Offices";
            this.Create_Inactivate_Offices_Button.UseVisualStyleBackColor = true;
            this.Create_Inactivate_Offices_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "WATS (Warehouse Asset Tracking System)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 193);
            this.dataGridView1.TabIndex = 6;
            // 
            // Test_Database_Connection_Button
            // 
            this.Test_Database_Connection_Button.Location = new System.Drawing.Point(270, 277);
            this.Test_Database_Connection_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Test_Database_Connection_Button.Name = "Test_Database_Connection_Button";
            this.Test_Database_Connection_Button.Size = new System.Drawing.Size(86, 48);
            this.Test_Database_Connection_Button.TabIndex = 8;
            this.Test_Database_Connection_Button.Text = "Test Database Connection";
            this.Test_Database_Connection_Button.UseVisualStyleBackColor = true;
            this.Test_Database_Connection_Button.Click += new System.EventHandler(this.Test_Database_Connection_Button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(445, 278);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 48);
            this.button6.TabIndex = 9;
            this.button6.Text = "Show All Employees";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Create_Dispose_Assets_Button
            // 
            this.Create_Dispose_Assets_Button.Location = new System.Drawing.Point(10, 289);
            this.Create_Dispose_Assets_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Create_Dispose_Assets_Button.Name = "Create_Dispose_Assets_Button";
            this.Create_Dispose_Assets_Button.Size = new System.Drawing.Size(215, 24);
            this.Create_Dispose_Assets_Button.TabIndex = 10;
            this.Create_Dispose_Assets_Button.Text = "Create \\ Dispose Assets";
            this.Create_Dispose_Assets_Button.UseVisualStyleBackColor = true;
            this.Create_Dispose_Assets_Button.Click += new System.EventHandler(this.Create_Dispose_Assets_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Asset Assignment Screens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(68, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Creation Screens";
            // 
            // Show_All_Offices_Button
            // 
            this.Show_All_Offices_Button.AutoSize = true;
            this.Show_All_Offices_Button.Location = new System.Drawing.Point(620, 278);
            this.Show_All_Offices_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Show_All_Offices_Button.Name = "Show_All_Offices_Button";
            this.Show_All_Offices_Button.Size = new System.Drawing.Size(95, 48);
            this.Show_All_Offices_Button.TabIndex = 14;
            this.Show_All_Offices_Button.Text = "Show All Offices";
            this.Show_All_Offices_Button.UseVisualStyleBackColor = true;
            this.Show_All_Offices_Button.Click += new System.EventHandler(this.Show_All_Offices_Button_Click);
            // 
            // Show_All_Assets_Button
            // 
            this.Show_All_Assets_Button.Location = new System.Drawing.Point(858, 278);
            this.Show_All_Assets_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Show_All_Assets_Button.Name = "Show_All_Assets_Button";
            this.Show_All_Assets_Button.Size = new System.Drawing.Size(86, 48);
            this.Show_All_Assets_Button.TabIndex = 15;
            this.Show_All_Assets_Button.Text = "Show All Computer Assets";
            this.Show_All_Assets_Button.UseVisualStyleBackColor = true;
            this.Show_All_Assets_Button.Click += new System.EventHandler(this.Show_All_Assets_Button_Click);
            // 
            // Show_All_Office_Assets_Button
            // 
            this.Show_All_Office_Assets_Button.Location = new System.Drawing.Point(1073, 278);
            this.Show_All_Office_Assets_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Show_All_Office_Assets_Button.Name = "Show_All_Office_Assets_Button";
            this.Show_All_Office_Assets_Button.Size = new System.Drawing.Size(86, 48);
            this.Show_All_Office_Assets_Button.TabIndex = 16;
            this.Show_All_Office_Assets_Button.Text = "Show All Office Assets";
            this.Show_All_Office_Assets_Button.UseVisualStyleBackColor = true;
            this.Show_All_Office_Assets_Button.Click += new System.EventHandler(this.Show_All_Office_Assets_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1411, 331);
            this.Controls.Add(this.Show_All_Office_Assets_Button);
            this.Controls.Add(this.Show_All_Assets_Button);
            this.Controls.Add(this.Show_All_Offices_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Create_Dispose_Assets_Button);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Test_Database_Connection_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_Inactivate_Offices_Button);
            this.Controls.Add(this.Create_Inactivate_Employees_Button);
            this.Controls.Add(this.Assign_Unassign_Computer_Assets_Button);
            this.Controls.Add(this.Assign_Unassign_Office_Assets_Button);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "WATS©";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button Assign_Unassign_Office_Assets_Button;
        private System.Windows.Forms.Button Assign_Unassign_Computer_Assets_Button;
        private System.Windows.Forms.Button Create_Inactivate_Employees_Button;
        private System.Windows.Forms.Button Create_Inactivate_Offices_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Test_Database_Connection_Button;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Create_Dispose_Assets_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Show_All_Offices_Button;
        private System.Windows.Forms.Button Show_All_Assets_Button;
        private System.Windows.Forms.Button Show_All_Office_Assets_Button;
    }
}

