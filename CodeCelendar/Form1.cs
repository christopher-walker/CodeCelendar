using CodeCelendar.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCelendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnDec01_01 = new System.Windows.Forms.Button();
            this.txtDec01_01 = new System.Windows.Forms.TextBox();
            this.btnDec01_02 = new System.Windows.Forms.Button();
            this.txtDec01_02 = new System.Windows.Forms.TextBox();
            this.groupDec01 = new System.Windows.Forms.GroupBox();
            this.groupDec02 = new System.Windows.Forms.GroupBox();
            this.btnDec02_01 = new System.Windows.Forms.Button();
            this.btnDec02_02 = new System.Windows.Forms.Button();
            this.txtDec02_01 = new System.Windows.Forms.TextBox();
            this.txtDec02_02 = new System.Windows.Forms.TextBox();
            this.groupDec01.SuspendLayout();
            this.groupDec02.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDec01_01
            // 
            this.btnDec01_01.Location = new System.Drawing.Point(6, 22);
            this.btnDec01_01.Name = "btnDec01_01";
            this.btnDec01_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec01_01.TabIndex = 0;
            this.btnDec01_01.Text = "01-01";
            this.btnDec01_01.UseVisualStyleBackColor = true;
            this.btnDec01_01.Click += new System.EventHandler(this.btnDec01_01_Click);
            // 
            // txtDec01_01
            // 
            this.txtDec01_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec01_01.Name = "txtDec01_01";
            this.txtDec01_01.Size = new System.Drawing.Size(75, 20);
            this.txtDec01_01.TabIndex = 1;
            // 
            // btnDec01_02
            // 
            this.btnDec01_02.Location = new System.Drawing.Point(88, 21);
            this.btnDec01_02.Name = "btnDec01_02";
            this.btnDec01_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec01_02.TabIndex = 2;
            this.btnDec01_02.Text = "01-02";
            this.btnDec01_02.UseVisualStyleBackColor = true;
            this.btnDec01_02.Click += new System.EventHandler(this.btnDec01_02_Click);
            // 
            // txtDec01_02
            // 
            this.txtDec01_02.Location = new System.Drawing.Point(88, 52);
            this.txtDec01_02.Name = "txtDec01_02";
            this.txtDec01_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec01_02.TabIndex = 3;
            // 
            // groupDec01
            // 
            this.groupDec01.Controls.Add(this.txtDec01_01);
            this.groupDec01.Controls.Add(this.txtDec01_02);
            this.groupDec01.Controls.Add(this.btnDec01_01);
            this.groupDec01.Controls.Add(this.btnDec01_02);
            this.groupDec01.Location = new System.Drawing.Point(12, 12);
            this.groupDec01.Name = "groupDec01";
            this.groupDec01.Size = new System.Drawing.Size(183, 90);
            this.groupDec01.TabIndex = 4;
            this.groupDec01.TabStop = false;
            this.groupDec01.Text = "Dec 01";
            // 
            // groupDec02
            // 
            this.groupDec02.Controls.Add(this.txtDec02_02);
            this.groupDec02.Controls.Add(this.txtDec02_01);
            this.groupDec02.Controls.Add(this.btnDec02_02);
            this.groupDec02.Controls.Add(this.btnDec02_01);
            this.groupDec02.Location = new System.Drawing.Point(201, 12);
            this.groupDec02.Name = "groupDec02";
            this.groupDec02.Size = new System.Drawing.Size(183, 90);
            this.groupDec02.TabIndex = 5;
            this.groupDec02.TabStop = false;
            this.groupDec02.Text = "Dec 02";
            // 
            // btnDec02_01
            // 
            this.btnDec02_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec02_01.Name = "btnDec02_01";
            this.btnDec02_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec02_01.TabIndex = 0;
            this.btnDec02_01.Text = "02-01";
            this.btnDec02_01.UseVisualStyleBackColor = true;
            // 
            // btnDec02_02
            // 
            this.btnDec02_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec02_02.Name = "btnDec02_02";
            this.btnDec02_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec02_02.TabIndex = 1;
            this.btnDec02_02.Text = "02-02";
            this.btnDec02_02.UseVisualStyleBackColor = true;
            // 
            // txtDec02_01
            // 
            this.txtDec02_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec02_01.Name = "txtDec02_01";
            this.txtDec02_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec02_01.TabIndex = 2;
            // 
            // txtDec02_02
            // 
            this.txtDec02_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec02_02.Name = "txtDec02_02";
            this.txtDec02_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec02_02.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1029, 657);
            this.Controls.Add(this.groupDec02);
            this.Controls.Add(this.groupDec01);
            this.Name = "Form1";
            this.Text = "Advent Calendar 2021";
            this.groupDec01.ResumeLayout(false);
            this.groupDec01.PerformLayout();
            this.groupDec02.ResumeLayout(false);
            this.groupDec02.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btnDec01_01_Click(object sender, EventArgs e)
        {
            _01_01_Depths helper = new _01_01_Depths();
            txtDec01_01.Text = helper.GetLargerMeasurements().ToString();
        }

        private void btnDec01_02_Click(object sender, EventArgs e)
        {
            _01_01_Depths helper = new _01_01_Depths();
            txtDec01_02.Text = helper.GetLargerMeasurementsGroupThree().ToString();
        }
    }
}
