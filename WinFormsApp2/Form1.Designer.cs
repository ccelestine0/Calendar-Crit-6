namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddDate = new System.Windows.Forms.Button();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(4, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Blue;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(590, 768);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(272, 132);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove All";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnAddDate
            // 
            this.btnAddDate.Location = new System.Drawing.Point(50, 270);
            this.btnAddDate.Name = "btnAddDate";
            this.btnAddDate.Size = new System.Drawing.Size(273, 132);
            this.btnAddDate.TabIndex = 2;
            this.btnAddDate.Text = "Add Date ";
            this.btnAddDate.UseVisualStyleBackColor = true;
            this.btnAddDate.Click += new System.EventHandler(this.BtnAddDate_Click);
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(31, 108);
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(130, 31);
            this.numDay.TabIndex = 6;
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(193, 108);
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(130, 31);
            this.numMonth.TabIndex = 7;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(68, 80);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(43, 25);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "Day";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(225, 80);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(65, 25);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.Text = "Month";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.numMonth);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.btnAddDate);
            this.panel1.Controls.Add(this.numDay);
            this.panel1.Location = new System.Drawing.Point(54, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 449);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 209);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 31);
            this.txtName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 1004);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button btnRemove;
        private Button btnAddDate;
        private NumericUpDown numDay;
        private NumericUpDown numMonth;
        private Label lblDay;
        private Label lblMonth;
        private Panel panel1;
        private TextBox txtName;
        private Label label1;
    }
}