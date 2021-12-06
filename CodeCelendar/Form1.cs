using CodeCelendar.Helpers;
using CodeCelendar.Helpers.Day3;
using CodeCelendar.Helpers.Day4;
using CodeCelendar.Helpers.Day5;
using CodeCelendar.Helpers.Day6;
using CodeCelendar.Helpers.Day7;
using CodeCelendar.Interface;
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
            this.txtDec02_02 = new System.Windows.Forms.TextBox();
            this.txtDec02_01 = new System.Windows.Forms.TextBox();
            this.btnDec02_02 = new System.Windows.Forms.Button();
            this.btnDec02_01 = new System.Windows.Forms.Button();
            this.groupDec03 = new System.Windows.Forms.GroupBox();
            this.txtDec03_02 = new System.Windows.Forms.TextBox();
            this.txtDec03_01 = new System.Windows.Forms.TextBox();
            this.btnDec02_03 = new System.Windows.Forms.Button();
            this.btnDec03_01 = new System.Windows.Forms.Button();
            this.groupDec04 = new System.Windows.Forms.GroupBox();
            this.txtDec04_02 = new System.Windows.Forms.TextBox();
            this.txtDec04_01 = new System.Windows.Forms.TextBox();
            this.btnDec02_04 = new System.Windows.Forms.Button();
            this.btnDec04_01 = new System.Windows.Forms.Button();
            this.groupDec05 = new System.Windows.Forms.GroupBox();
            this.txtDec05_02 = new System.Windows.Forms.TextBox();
            this.txtDec05_01 = new System.Windows.Forms.TextBox();
            this.btnDec05_02 = new System.Windows.Forms.Button();
            this.btnDec05_01 = new System.Windows.Forms.Button();
            this.groupDec09 = new System.Windows.Forms.GroupBox();
            this.txtDec09_02 = new System.Windows.Forms.TextBox();
            this.txtDec09_01 = new System.Windows.Forms.TextBox();
            this.btnDec09_02 = new System.Windows.Forms.Button();
            this.btnDec09_01 = new System.Windows.Forms.Button();
            this.groupDec08 = new System.Windows.Forms.GroupBox();
            this.txtDec08_02 = new System.Windows.Forms.TextBox();
            this.txtDec08_01 = new System.Windows.Forms.TextBox();
            this.btnDec08_02 = new System.Windows.Forms.Button();
            this.btnDec08_01 = new System.Windows.Forms.Button();
            this.groupDec07 = new System.Windows.Forms.GroupBox();
            this.txtDec07_02 = new System.Windows.Forms.TextBox();
            this.txtDec07_01 = new System.Windows.Forms.TextBox();
            this.btnDec07_02 = new System.Windows.Forms.Button();
            this.btnDec07_01 = new System.Windows.Forms.Button();
            this.groupDec06 = new System.Windows.Forms.GroupBox();
            this.txtDec06_02 = new System.Windows.Forms.TextBox();
            this.txtDec06_01 = new System.Windows.Forms.TextBox();
            this.btnDec06_02 = new System.Windows.Forms.Button();
            this.btnDec06_01 = new System.Windows.Forms.Button();
            this.groupDec10 = new System.Windows.Forms.GroupBox();
            this.txtDec10_02 = new System.Windows.Forms.TextBox();
            this.txtDec10_01 = new System.Windows.Forms.TextBox();
            this.btnDec10_02 = new System.Windows.Forms.Button();
            this.btnDec10_01 = new System.Windows.Forms.Button();
            this.groupDec15 = new System.Windows.Forms.GroupBox();
            this.txtDec15_02 = new System.Windows.Forms.TextBox();
            this.txtDec15_01 = new System.Windows.Forms.TextBox();
            this.btnDec15_02 = new System.Windows.Forms.Button();
            this.btnDec15_01 = new System.Windows.Forms.Button();
            this.groupDec14 = new System.Windows.Forms.GroupBox();
            this.txtDec14_02 = new System.Windows.Forms.TextBox();
            this.txtDec14_01 = new System.Windows.Forms.TextBox();
            this.btnDec14_02 = new System.Windows.Forms.Button();
            this.btnDec14_01 = new System.Windows.Forms.Button();
            this.groupDec13 = new System.Windows.Forms.GroupBox();
            this.txtDec13_02 = new System.Windows.Forms.TextBox();
            this.txtDec13_01 = new System.Windows.Forms.TextBox();
            this.btnDec13_02 = new System.Windows.Forms.Button();
            this.btnDec13_01 = new System.Windows.Forms.Button();
            this.groupDec12 = new System.Windows.Forms.GroupBox();
            this.txtDec12_02 = new System.Windows.Forms.TextBox();
            this.txtDec12_01 = new System.Windows.Forms.TextBox();
            this.btnDec12_02 = new System.Windows.Forms.Button();
            this.btnDec12_01 = new System.Windows.Forms.Button();
            this.groupDec11 = new System.Windows.Forms.GroupBox();
            this.txtDec11_02 = new System.Windows.Forms.TextBox();
            this.txtDec11_01 = new System.Windows.Forms.TextBox();
            this.btnDec11_02 = new System.Windows.Forms.Button();
            this.btnDec11_01 = new System.Windows.Forms.Button();
            this.groupDec20 = new System.Windows.Forms.GroupBox();
            this.txtDec20_02 = new System.Windows.Forms.TextBox();
            this.txtDec20_01 = new System.Windows.Forms.TextBox();
            this.btnDec20_02 = new System.Windows.Forms.Button();
            this.btnDec20_01 = new System.Windows.Forms.Button();
            this.groupDec19 = new System.Windows.Forms.GroupBox();
            this.txtDec19_02 = new System.Windows.Forms.TextBox();
            this.txtDec19_01 = new System.Windows.Forms.TextBox();
            this.btnDec19_02 = new System.Windows.Forms.Button();
            this.btnDec19_01 = new System.Windows.Forms.Button();
            this.groupDec18 = new System.Windows.Forms.GroupBox();
            this.txtDec18_02 = new System.Windows.Forms.TextBox();
            this.txtDec18_01 = new System.Windows.Forms.TextBox();
            this.btnDec18_02 = new System.Windows.Forms.Button();
            this.btnDec18_01 = new System.Windows.Forms.Button();
            this.groupDec17 = new System.Windows.Forms.GroupBox();
            this.txtDec17_02 = new System.Windows.Forms.TextBox();
            this.txtDec17_01 = new System.Windows.Forms.TextBox();
            this.btnDec17_02 = new System.Windows.Forms.Button();
            this.btnDec17_01 = new System.Windows.Forms.Button();
            this.groupDec16 = new System.Windows.Forms.GroupBox();
            this.txtDec16_02 = new System.Windows.Forms.TextBox();
            this.txtDec16_01 = new System.Windows.Forms.TextBox();
            this.btnDec16_02 = new System.Windows.Forms.Button();
            this.btnDec16_01 = new System.Windows.Forms.Button();
            this.groupDec25 = new System.Windows.Forms.GroupBox();
            this.txtDec25_02 = new System.Windows.Forms.TextBox();
            this.txtDec25_01 = new System.Windows.Forms.TextBox();
            this.btnDec25_02 = new System.Windows.Forms.Button();
            this.btnDec25_01 = new System.Windows.Forms.Button();
            this.groupDec24 = new System.Windows.Forms.GroupBox();
            this.txtDec24_02 = new System.Windows.Forms.TextBox();
            this.txtDec24_01 = new System.Windows.Forms.TextBox();
            this.btnDec24_02 = new System.Windows.Forms.Button();
            this.btnDec24_01 = new System.Windows.Forms.Button();
            this.groupDec23 = new System.Windows.Forms.GroupBox();
            this.txtDec23_02 = new System.Windows.Forms.TextBox();
            this.txtDec23_01 = new System.Windows.Forms.TextBox();
            this.btnDec23_02 = new System.Windows.Forms.Button();
            this.btnDec23_01 = new System.Windows.Forms.Button();
            this.groupDec22 = new System.Windows.Forms.GroupBox();
            this.txtDec22_02 = new System.Windows.Forms.TextBox();
            this.txtDec22_01 = new System.Windows.Forms.TextBox();
            this.btnDec22_02 = new System.Windows.Forms.Button();
            this.btnDec22_01 = new System.Windows.Forms.Button();
            this.groupDec21 = new System.Windows.Forms.GroupBox();
            this.txtDec21_02 = new System.Windows.Forms.TextBox();
            this.txtDec21_01 = new System.Windows.Forms.TextBox();
            this.btnDec21_02 = new System.Windows.Forms.Button();
            this.btnDec21_01 = new System.Windows.Forms.Button();
            this.groupDec01.SuspendLayout();
            this.groupDec02.SuspendLayout();
            this.groupDec03.SuspendLayout();
            this.groupDec04.SuspendLayout();
            this.groupDec05.SuspendLayout();
            this.groupDec09.SuspendLayout();
            this.groupDec08.SuspendLayout();
            this.groupDec07.SuspendLayout();
            this.groupDec06.SuspendLayout();
            this.groupDec10.SuspendLayout();
            this.groupDec15.SuspendLayout();
            this.groupDec14.SuspendLayout();
            this.groupDec13.SuspendLayout();
            this.groupDec12.SuspendLayout();
            this.groupDec11.SuspendLayout();
            this.groupDec20.SuspendLayout();
            this.groupDec19.SuspendLayout();
            this.groupDec18.SuspendLayout();
            this.groupDec17.SuspendLayout();
            this.groupDec16.SuspendLayout();
            this.groupDec25.SuspendLayout();
            this.groupDec24.SuspendLayout();
            this.groupDec23.SuspendLayout();
            this.groupDec22.SuspendLayout();
            this.groupDec21.SuspendLayout();
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
            // txtDec02_02
            // 
            this.txtDec02_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec02_02.Name = "txtDec02_02";
            this.txtDec02_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec02_02.TabIndex = 3;
            // 
            // txtDec02_01
            // 
            this.txtDec02_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec02_01.Name = "txtDec02_01";
            this.txtDec02_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec02_01.TabIndex = 2;
            // 
            // btnDec02_02
            // 
            this.btnDec02_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec02_02.Name = "btnDec02_02";
            this.btnDec02_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec02_02.TabIndex = 1;
            this.btnDec02_02.Text = "02-02";
            this.btnDec02_02.UseVisualStyleBackColor = true;
            this.btnDec02_02.Click += new System.EventHandler(this.btnDec02_02_Click);
            // 
            // btnDec02_01
            // 
            this.btnDec02_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec02_01.Name = "btnDec02_01";
            this.btnDec02_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec02_01.TabIndex = 0;
            this.btnDec02_01.Text = "02-01";
            this.btnDec02_01.UseVisualStyleBackColor = true;
            this.btnDec02_01.Click += new System.EventHandler(this.btnDec02_01_Click);
            // 
            // groupDec03
            // 
            this.groupDec03.Controls.Add(this.txtDec03_02);
            this.groupDec03.Controls.Add(this.txtDec03_01);
            this.groupDec03.Controls.Add(this.btnDec02_03);
            this.groupDec03.Controls.Add(this.btnDec03_01);
            this.groupDec03.Location = new System.Drawing.Point(390, 12);
            this.groupDec03.Name = "groupDec03";
            this.groupDec03.Size = new System.Drawing.Size(183, 90);
            this.groupDec03.TabIndex = 6;
            this.groupDec03.TabStop = false;
            this.groupDec03.Text = "Dec 03";
            // 
            // txtDec03_02
            // 
            this.txtDec03_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec03_02.Name = "txtDec03_02";
            this.txtDec03_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec03_02.TabIndex = 3;
            // 
            // txtDec03_01
            // 
            this.txtDec03_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec03_01.Name = "txtDec03_01";
            this.txtDec03_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec03_01.TabIndex = 2;
            // 
            // btnDec02_03
            // 
            this.btnDec02_03.Location = new System.Drawing.Point(87, 22);
            this.btnDec02_03.Name = "btnDec02_03";
            this.btnDec02_03.Size = new System.Drawing.Size(75, 23);
            this.btnDec02_03.TabIndex = 1;
            this.btnDec02_03.Text = "03-02";
            this.btnDec02_03.UseVisualStyleBackColor = true;
            this.btnDec02_03.Click += new System.EventHandler(this.btnDec02_03_Click);
            // 
            // btnDec03_01
            // 
            this.btnDec03_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec03_01.Name = "btnDec03_01";
            this.btnDec03_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec03_01.TabIndex = 0;
            this.btnDec03_01.Text = "03-01";
            this.btnDec03_01.UseVisualStyleBackColor = true;
            this.btnDec03_01.Click += new System.EventHandler(this.btnDec03_01_Click);
            // 
            // groupDec04
            // 
            this.groupDec04.Controls.Add(this.txtDec04_02);
            this.groupDec04.Controls.Add(this.txtDec04_01);
            this.groupDec04.Controls.Add(this.btnDec02_04);
            this.groupDec04.Controls.Add(this.btnDec04_01);
            this.groupDec04.Location = new System.Drawing.Point(579, 12);
            this.groupDec04.Name = "groupDec04";
            this.groupDec04.Size = new System.Drawing.Size(183, 90);
            this.groupDec04.TabIndex = 7;
            this.groupDec04.TabStop = false;
            this.groupDec04.Text = "Dec 04";
            // 
            // txtDec04_02
            // 
            this.txtDec04_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec04_02.Name = "txtDec04_02";
            this.txtDec04_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec04_02.TabIndex = 3;
            // 
            // txtDec04_01
            // 
            this.txtDec04_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec04_01.Name = "txtDec04_01";
            this.txtDec04_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec04_01.TabIndex = 2;
            // 
            // btnDec02_04
            // 
            this.btnDec02_04.Location = new System.Drawing.Point(87, 22);
            this.btnDec02_04.Name = "btnDec02_04";
            this.btnDec02_04.Size = new System.Drawing.Size(75, 23);
            this.btnDec02_04.TabIndex = 1;
            this.btnDec02_04.Text = "04-02";
            this.btnDec02_04.UseVisualStyleBackColor = true;
            this.btnDec02_04.Click += new System.EventHandler(this.btnDec02_04_Click);
            // 
            // btnDec04_01
            // 
            this.btnDec04_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec04_01.Name = "btnDec04_01";
            this.btnDec04_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec04_01.TabIndex = 0;
            this.btnDec04_01.Text = "04-01";
            this.btnDec04_01.UseVisualStyleBackColor = true;
            this.btnDec04_01.Click += new System.EventHandler(this.btnDec04_01_Click);
            // 
            // groupDec05
            // 
            this.groupDec05.Controls.Add(this.txtDec05_02);
            this.groupDec05.Controls.Add(this.txtDec05_01);
            this.groupDec05.Controls.Add(this.btnDec05_02);
            this.groupDec05.Controls.Add(this.btnDec05_01);
            this.groupDec05.Location = new System.Drawing.Point(768, 12);
            this.groupDec05.Name = "groupDec05";
            this.groupDec05.Size = new System.Drawing.Size(183, 90);
            this.groupDec05.TabIndex = 8;
            this.groupDec05.TabStop = false;
            this.groupDec05.Text = "Dec 05";
            // 
            // txtDec05_02
            // 
            this.txtDec05_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec05_02.Name = "txtDec05_02";
            this.txtDec05_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec05_02.TabIndex = 3;
            // 
            // txtDec05_01
            // 
            this.txtDec05_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec05_01.Name = "txtDec05_01";
            this.txtDec05_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec05_01.TabIndex = 2;
            // 
            // btnDec05_02
            // 
            this.btnDec05_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec05_02.Name = "btnDec05_02";
            this.btnDec05_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec05_02.TabIndex = 1;
            this.btnDec05_02.Text = "05-02";
            this.btnDec05_02.UseVisualStyleBackColor = true;
            this.btnDec05_02.Click += new System.EventHandler(this.btnDec05_02_Click);
            // 
            // btnDec05_01
            // 
            this.btnDec05_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec05_01.Name = "btnDec05_01";
            this.btnDec05_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec05_01.TabIndex = 0;
            this.btnDec05_01.Text = "05-01";
            this.btnDec05_01.UseVisualStyleBackColor = true;
            this.btnDec05_01.Click += new System.EventHandler(this.btnDec05_01_Click);
            // 
            // groupDec09
            // 
            this.groupDec09.Controls.Add(this.txtDec09_02);
            this.groupDec09.Controls.Add(this.txtDec09_01);
            this.groupDec09.Controls.Add(this.btnDec09_02);
            this.groupDec09.Controls.Add(this.btnDec09_01);
            this.groupDec09.Location = new System.Drawing.Point(579, 108);
            this.groupDec09.Name = "groupDec09";
            this.groupDec09.Size = new System.Drawing.Size(183, 90);
            this.groupDec09.TabIndex = 12;
            this.groupDec09.TabStop = false;
            this.groupDec09.Text = "Dec 09";
            // 
            // txtDec09_02
            // 
            this.txtDec09_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec09_02.Name = "txtDec09_02";
            this.txtDec09_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec09_02.TabIndex = 3;
            // 
            // txtDec09_01
            // 
            this.txtDec09_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec09_01.Name = "txtDec09_01";
            this.txtDec09_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec09_01.TabIndex = 2;
            // 
            // btnDec09_02
            // 
            this.btnDec09_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec09_02.Name = "btnDec09_02";
            this.btnDec09_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec09_02.TabIndex = 1;
            this.btnDec09_02.Text = "09-02";
            this.btnDec09_02.UseVisualStyleBackColor = true;
            // 
            // btnDec09_01
            // 
            this.btnDec09_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec09_01.Name = "btnDec09_01";
            this.btnDec09_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec09_01.TabIndex = 0;
            this.btnDec09_01.Text = "09-01";
            this.btnDec09_01.UseVisualStyleBackColor = true;
            // 
            // groupDec08
            // 
            this.groupDec08.Controls.Add(this.txtDec08_02);
            this.groupDec08.Controls.Add(this.txtDec08_01);
            this.groupDec08.Controls.Add(this.btnDec08_02);
            this.groupDec08.Controls.Add(this.btnDec08_01);
            this.groupDec08.Location = new System.Drawing.Point(390, 108);
            this.groupDec08.Name = "groupDec08";
            this.groupDec08.Size = new System.Drawing.Size(183, 90);
            this.groupDec08.TabIndex = 11;
            this.groupDec08.TabStop = false;
            this.groupDec08.Text = "Dec 08";
            // 
            // txtDec08_02
            // 
            this.txtDec08_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec08_02.Name = "txtDec08_02";
            this.txtDec08_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec08_02.TabIndex = 3;
            // 
            // txtDec08_01
            // 
            this.txtDec08_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec08_01.Name = "txtDec08_01";
            this.txtDec08_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec08_01.TabIndex = 2;
            // 
            // btnDec08_02
            // 
            this.btnDec08_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec08_02.Name = "btnDec08_02";
            this.btnDec08_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec08_02.TabIndex = 1;
            this.btnDec08_02.Text = "08-02";
            this.btnDec08_02.UseVisualStyleBackColor = true;
            // 
            // btnDec08_01
            // 
            this.btnDec08_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec08_01.Name = "btnDec08_01";
            this.btnDec08_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec08_01.TabIndex = 0;
            this.btnDec08_01.Text = "08-01";
            this.btnDec08_01.UseVisualStyleBackColor = true;
            // 
            // groupDec07
            // 
            this.groupDec07.Controls.Add(this.txtDec07_02);
            this.groupDec07.Controls.Add(this.txtDec07_01);
            this.groupDec07.Controls.Add(this.btnDec07_02);
            this.groupDec07.Controls.Add(this.btnDec07_01);
            this.groupDec07.Location = new System.Drawing.Point(201, 108);
            this.groupDec07.Name = "groupDec07";
            this.groupDec07.Size = new System.Drawing.Size(183, 90);
            this.groupDec07.TabIndex = 10;
            this.groupDec07.TabStop = false;
            this.groupDec07.Text = "Dec 07";
            // 
            // txtDec07_02
            // 
            this.txtDec07_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec07_02.Name = "txtDec07_02";
            this.txtDec07_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec07_02.TabIndex = 3;
            // 
            // txtDec07_01
            // 
            this.txtDec07_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec07_01.Name = "txtDec07_01";
            this.txtDec07_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec07_01.TabIndex = 2;
            // 
            // btnDec07_02
            // 
            this.btnDec07_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec07_02.Name = "btnDec07_02";
            this.btnDec07_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec07_02.TabIndex = 1;
            this.btnDec07_02.Text = "07-02";
            this.btnDec07_02.UseVisualStyleBackColor = true;
            this.btnDec07_02.Click += new System.EventHandler(this.btnDec07_02_Click);
            // 
            // btnDec07_01
            // 
            this.btnDec07_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec07_01.Name = "btnDec07_01";
            this.btnDec07_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec07_01.TabIndex = 0;
            this.btnDec07_01.Text = "07-01";
            this.btnDec07_01.UseVisualStyleBackColor = true;
            this.btnDec07_01.Click += new System.EventHandler(this.btnDec07_01_Click);
            // 
            // groupDec06
            // 
            this.groupDec06.Controls.Add(this.txtDec06_02);
            this.groupDec06.Controls.Add(this.txtDec06_01);
            this.groupDec06.Controls.Add(this.btnDec06_02);
            this.groupDec06.Controls.Add(this.btnDec06_01);
            this.groupDec06.Location = new System.Drawing.Point(12, 108);
            this.groupDec06.Name = "groupDec06";
            this.groupDec06.Size = new System.Drawing.Size(183, 90);
            this.groupDec06.TabIndex = 9;
            this.groupDec06.TabStop = false;
            this.groupDec06.Text = "Dec 06";
            // 
            // txtDec06_02
            // 
            this.txtDec06_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec06_02.Name = "txtDec06_02";
            this.txtDec06_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec06_02.TabIndex = 3;
            // 
            // txtDec06_01
            // 
            this.txtDec06_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec06_01.Name = "txtDec06_01";
            this.txtDec06_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec06_01.TabIndex = 2;
            // 
            // btnDec06_02
            // 
            this.btnDec06_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec06_02.Name = "btnDec06_02";
            this.btnDec06_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec06_02.TabIndex = 1;
            this.btnDec06_02.Text = "06-02";
            this.btnDec06_02.UseVisualStyleBackColor = true;
            this.btnDec06_02.Click += new System.EventHandler(this.btnDec06_02_Click);
            // 
            // btnDec06_01
            // 
            this.btnDec06_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec06_01.Name = "btnDec06_01";
            this.btnDec06_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec06_01.TabIndex = 0;
            this.btnDec06_01.Text = "06-01";
            this.btnDec06_01.UseVisualStyleBackColor = true;
            this.btnDec06_01.Click += new System.EventHandler(this.btnDec06_01_Click);
            // 
            // groupDec10
            // 
            this.groupDec10.Controls.Add(this.txtDec10_02);
            this.groupDec10.Controls.Add(this.txtDec10_01);
            this.groupDec10.Controls.Add(this.btnDec10_02);
            this.groupDec10.Controls.Add(this.btnDec10_01);
            this.groupDec10.Location = new System.Drawing.Point(768, 108);
            this.groupDec10.Name = "groupDec10";
            this.groupDec10.Size = new System.Drawing.Size(183, 90);
            this.groupDec10.TabIndex = 13;
            this.groupDec10.TabStop = false;
            this.groupDec10.Text = "Dec 10";
            // 
            // txtDec10_02
            // 
            this.txtDec10_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec10_02.Name = "txtDec10_02";
            this.txtDec10_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec10_02.TabIndex = 3;
            // 
            // txtDec10_01
            // 
            this.txtDec10_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec10_01.Name = "txtDec10_01";
            this.txtDec10_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec10_01.TabIndex = 2;
            // 
            // btnDec10_02
            // 
            this.btnDec10_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec10_02.Name = "btnDec10_02";
            this.btnDec10_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec10_02.TabIndex = 1;
            this.btnDec10_02.Text = "10-02";
            this.btnDec10_02.UseVisualStyleBackColor = true;
            // 
            // btnDec10_01
            // 
            this.btnDec10_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec10_01.Name = "btnDec10_01";
            this.btnDec10_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec10_01.TabIndex = 0;
            this.btnDec10_01.Text = "10-01";
            this.btnDec10_01.UseVisualStyleBackColor = true;
            // 
            // groupDec15
            // 
            this.groupDec15.Controls.Add(this.txtDec15_02);
            this.groupDec15.Controls.Add(this.txtDec15_01);
            this.groupDec15.Controls.Add(this.btnDec15_02);
            this.groupDec15.Controls.Add(this.btnDec15_01);
            this.groupDec15.Location = new System.Drawing.Point(768, 204);
            this.groupDec15.Name = "groupDec15";
            this.groupDec15.Size = new System.Drawing.Size(183, 90);
            this.groupDec15.TabIndex = 18;
            this.groupDec15.TabStop = false;
            this.groupDec15.Text = "Dec 15";
            // 
            // txtDec15_02
            // 
            this.txtDec15_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec15_02.Name = "txtDec15_02";
            this.txtDec15_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec15_02.TabIndex = 3;
            // 
            // txtDec15_01
            // 
            this.txtDec15_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec15_01.Name = "txtDec15_01";
            this.txtDec15_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec15_01.TabIndex = 2;
            // 
            // btnDec15_02
            // 
            this.btnDec15_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec15_02.Name = "btnDec15_02";
            this.btnDec15_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec15_02.TabIndex = 1;
            this.btnDec15_02.Text = "15-02";
            this.btnDec15_02.UseVisualStyleBackColor = true;
            // 
            // btnDec15_01
            // 
            this.btnDec15_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec15_01.Name = "btnDec15_01";
            this.btnDec15_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec15_01.TabIndex = 0;
            this.btnDec15_01.Text = "15-01";
            this.btnDec15_01.UseVisualStyleBackColor = true;
            // 
            // groupDec14
            // 
            this.groupDec14.Controls.Add(this.txtDec14_02);
            this.groupDec14.Controls.Add(this.txtDec14_01);
            this.groupDec14.Controls.Add(this.btnDec14_02);
            this.groupDec14.Controls.Add(this.btnDec14_01);
            this.groupDec14.Location = new System.Drawing.Point(579, 204);
            this.groupDec14.Name = "groupDec14";
            this.groupDec14.Size = new System.Drawing.Size(183, 90);
            this.groupDec14.TabIndex = 17;
            this.groupDec14.TabStop = false;
            this.groupDec14.Text = "Dec 14";
            // 
            // txtDec14_02
            // 
            this.txtDec14_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec14_02.Name = "txtDec14_02";
            this.txtDec14_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec14_02.TabIndex = 3;
            // 
            // txtDec14_01
            // 
            this.txtDec14_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec14_01.Name = "txtDec14_01";
            this.txtDec14_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec14_01.TabIndex = 2;
            // 
            // btnDec14_02
            // 
            this.btnDec14_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec14_02.Name = "btnDec14_02";
            this.btnDec14_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec14_02.TabIndex = 1;
            this.btnDec14_02.Text = "14-02";
            this.btnDec14_02.UseVisualStyleBackColor = true;
            // 
            // btnDec14_01
            // 
            this.btnDec14_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec14_01.Name = "btnDec14_01";
            this.btnDec14_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec14_01.TabIndex = 0;
            this.btnDec14_01.Text = "14-01";
            this.btnDec14_01.UseVisualStyleBackColor = true;
            // 
            // groupDec13
            // 
            this.groupDec13.Controls.Add(this.txtDec13_02);
            this.groupDec13.Controls.Add(this.txtDec13_01);
            this.groupDec13.Controls.Add(this.btnDec13_02);
            this.groupDec13.Controls.Add(this.btnDec13_01);
            this.groupDec13.Location = new System.Drawing.Point(390, 204);
            this.groupDec13.Name = "groupDec13";
            this.groupDec13.Size = new System.Drawing.Size(183, 90);
            this.groupDec13.TabIndex = 16;
            this.groupDec13.TabStop = false;
            this.groupDec13.Text = "Dec 13";
            // 
            // txtDec13_02
            // 
            this.txtDec13_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec13_02.Name = "txtDec13_02";
            this.txtDec13_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec13_02.TabIndex = 3;
            // 
            // txtDec13_01
            // 
            this.txtDec13_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec13_01.Name = "txtDec13_01";
            this.txtDec13_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec13_01.TabIndex = 2;
            // 
            // btnDec13_02
            // 
            this.btnDec13_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec13_02.Name = "btnDec13_02";
            this.btnDec13_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec13_02.TabIndex = 1;
            this.btnDec13_02.Text = "13-02";
            this.btnDec13_02.UseVisualStyleBackColor = true;
            // 
            // btnDec13_01
            // 
            this.btnDec13_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec13_01.Name = "btnDec13_01";
            this.btnDec13_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec13_01.TabIndex = 0;
            this.btnDec13_01.Text = "13-01";
            this.btnDec13_01.UseVisualStyleBackColor = true;
            // 
            // groupDec12
            // 
            this.groupDec12.Controls.Add(this.txtDec12_02);
            this.groupDec12.Controls.Add(this.txtDec12_01);
            this.groupDec12.Controls.Add(this.btnDec12_02);
            this.groupDec12.Controls.Add(this.btnDec12_01);
            this.groupDec12.Location = new System.Drawing.Point(201, 204);
            this.groupDec12.Name = "groupDec12";
            this.groupDec12.Size = new System.Drawing.Size(183, 90);
            this.groupDec12.TabIndex = 15;
            this.groupDec12.TabStop = false;
            this.groupDec12.Text = "Dec 12";
            // 
            // txtDec12_02
            // 
            this.txtDec12_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec12_02.Name = "txtDec12_02";
            this.txtDec12_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec12_02.TabIndex = 3;
            // 
            // txtDec12_01
            // 
            this.txtDec12_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec12_01.Name = "txtDec12_01";
            this.txtDec12_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec12_01.TabIndex = 2;
            // 
            // btnDec12_02
            // 
            this.btnDec12_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec12_02.Name = "btnDec12_02";
            this.btnDec12_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec12_02.TabIndex = 1;
            this.btnDec12_02.Text = "12-02";
            this.btnDec12_02.UseVisualStyleBackColor = true;
            // 
            // btnDec12_01
            // 
            this.btnDec12_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec12_01.Name = "btnDec12_01";
            this.btnDec12_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec12_01.TabIndex = 0;
            this.btnDec12_01.Text = "12-01";
            this.btnDec12_01.UseVisualStyleBackColor = true;
            // 
            // groupDec11
            // 
            this.groupDec11.Controls.Add(this.txtDec11_02);
            this.groupDec11.Controls.Add(this.txtDec11_01);
            this.groupDec11.Controls.Add(this.btnDec11_02);
            this.groupDec11.Controls.Add(this.btnDec11_01);
            this.groupDec11.Location = new System.Drawing.Point(12, 204);
            this.groupDec11.Name = "groupDec11";
            this.groupDec11.Size = new System.Drawing.Size(183, 90);
            this.groupDec11.TabIndex = 14;
            this.groupDec11.TabStop = false;
            this.groupDec11.Text = "Dec 11";
            // 
            // txtDec11_02
            // 
            this.txtDec11_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec11_02.Name = "txtDec11_02";
            this.txtDec11_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec11_02.TabIndex = 3;
            // 
            // txtDec11_01
            // 
            this.txtDec11_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec11_01.Name = "txtDec11_01";
            this.txtDec11_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec11_01.TabIndex = 2;
            // 
            // btnDec11_02
            // 
            this.btnDec11_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec11_02.Name = "btnDec11_02";
            this.btnDec11_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec11_02.TabIndex = 1;
            this.btnDec11_02.Text = "11-02";
            this.btnDec11_02.UseVisualStyleBackColor = true;
            // 
            // btnDec11_01
            // 
            this.btnDec11_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec11_01.Name = "btnDec11_01";
            this.btnDec11_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec11_01.TabIndex = 0;
            this.btnDec11_01.Text = "11-01";
            this.btnDec11_01.UseVisualStyleBackColor = true;
            // 
            // groupDec20
            // 
            this.groupDec20.Controls.Add(this.txtDec20_02);
            this.groupDec20.Controls.Add(this.txtDec20_01);
            this.groupDec20.Controls.Add(this.btnDec20_02);
            this.groupDec20.Controls.Add(this.btnDec20_01);
            this.groupDec20.Location = new System.Drawing.Point(768, 300);
            this.groupDec20.Name = "groupDec20";
            this.groupDec20.Size = new System.Drawing.Size(183, 90);
            this.groupDec20.TabIndex = 23;
            this.groupDec20.TabStop = false;
            this.groupDec20.Text = "Dec 20";
            // 
            // txtDec20_02
            // 
            this.txtDec20_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec20_02.Name = "txtDec20_02";
            this.txtDec20_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec20_02.TabIndex = 3;
            // 
            // txtDec20_01
            // 
            this.txtDec20_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec20_01.Name = "txtDec20_01";
            this.txtDec20_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec20_01.TabIndex = 2;
            // 
            // btnDec20_02
            // 
            this.btnDec20_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec20_02.Name = "btnDec20_02";
            this.btnDec20_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec20_02.TabIndex = 1;
            this.btnDec20_02.Text = "20-02";
            this.btnDec20_02.UseVisualStyleBackColor = true;
            // 
            // btnDec20_01
            // 
            this.btnDec20_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec20_01.Name = "btnDec20_01";
            this.btnDec20_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec20_01.TabIndex = 0;
            this.btnDec20_01.Text = "20-01";
            this.btnDec20_01.UseVisualStyleBackColor = true;
            // 
            // groupDec19
            // 
            this.groupDec19.Controls.Add(this.txtDec19_02);
            this.groupDec19.Controls.Add(this.txtDec19_01);
            this.groupDec19.Controls.Add(this.btnDec19_02);
            this.groupDec19.Controls.Add(this.btnDec19_01);
            this.groupDec19.Location = new System.Drawing.Point(579, 300);
            this.groupDec19.Name = "groupDec19";
            this.groupDec19.Size = new System.Drawing.Size(183, 90);
            this.groupDec19.TabIndex = 22;
            this.groupDec19.TabStop = false;
            this.groupDec19.Text = "Dec 19";
            // 
            // txtDec19_02
            // 
            this.txtDec19_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec19_02.Name = "txtDec19_02";
            this.txtDec19_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec19_02.TabIndex = 3;
            // 
            // txtDec19_01
            // 
            this.txtDec19_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec19_01.Name = "txtDec19_01";
            this.txtDec19_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec19_01.TabIndex = 2;
            // 
            // btnDec19_02
            // 
            this.btnDec19_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec19_02.Name = "btnDec19_02";
            this.btnDec19_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec19_02.TabIndex = 1;
            this.btnDec19_02.Text = "19-02";
            this.btnDec19_02.UseVisualStyleBackColor = true;
            // 
            // btnDec19_01
            // 
            this.btnDec19_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec19_01.Name = "btnDec19_01";
            this.btnDec19_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec19_01.TabIndex = 0;
            this.btnDec19_01.Text = "19-01";
            this.btnDec19_01.UseVisualStyleBackColor = true;
            // 
            // groupDec18
            // 
            this.groupDec18.Controls.Add(this.txtDec18_02);
            this.groupDec18.Controls.Add(this.txtDec18_01);
            this.groupDec18.Controls.Add(this.btnDec18_02);
            this.groupDec18.Controls.Add(this.btnDec18_01);
            this.groupDec18.Location = new System.Drawing.Point(390, 300);
            this.groupDec18.Name = "groupDec18";
            this.groupDec18.Size = new System.Drawing.Size(183, 90);
            this.groupDec18.TabIndex = 21;
            this.groupDec18.TabStop = false;
            this.groupDec18.Text = "Dec 18";
            // 
            // txtDec18_02
            // 
            this.txtDec18_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec18_02.Name = "txtDec18_02";
            this.txtDec18_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec18_02.TabIndex = 3;
            // 
            // txtDec18_01
            // 
            this.txtDec18_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec18_01.Name = "txtDec18_01";
            this.txtDec18_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec18_01.TabIndex = 2;
            // 
            // btnDec18_02
            // 
            this.btnDec18_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec18_02.Name = "btnDec18_02";
            this.btnDec18_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec18_02.TabIndex = 1;
            this.btnDec18_02.Text = "18-02";
            this.btnDec18_02.UseVisualStyleBackColor = true;
            // 
            // btnDec18_01
            // 
            this.btnDec18_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec18_01.Name = "btnDec18_01";
            this.btnDec18_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec18_01.TabIndex = 0;
            this.btnDec18_01.Text = "18-01";
            this.btnDec18_01.UseVisualStyleBackColor = true;
            // 
            // groupDec17
            // 
            this.groupDec17.Controls.Add(this.txtDec17_02);
            this.groupDec17.Controls.Add(this.txtDec17_01);
            this.groupDec17.Controls.Add(this.btnDec17_02);
            this.groupDec17.Controls.Add(this.btnDec17_01);
            this.groupDec17.Location = new System.Drawing.Point(201, 300);
            this.groupDec17.Name = "groupDec17";
            this.groupDec17.Size = new System.Drawing.Size(183, 90);
            this.groupDec17.TabIndex = 20;
            this.groupDec17.TabStop = false;
            this.groupDec17.Text = "Dec 17";
            // 
            // txtDec17_02
            // 
            this.txtDec17_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec17_02.Name = "txtDec17_02";
            this.txtDec17_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec17_02.TabIndex = 3;
            // 
            // txtDec17_01
            // 
            this.txtDec17_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec17_01.Name = "txtDec17_01";
            this.txtDec17_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec17_01.TabIndex = 2;
            // 
            // btnDec17_02
            // 
            this.btnDec17_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec17_02.Name = "btnDec17_02";
            this.btnDec17_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec17_02.TabIndex = 1;
            this.btnDec17_02.Text = "17-02";
            this.btnDec17_02.UseVisualStyleBackColor = true;
            // 
            // btnDec17_01
            // 
            this.btnDec17_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec17_01.Name = "btnDec17_01";
            this.btnDec17_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec17_01.TabIndex = 0;
            this.btnDec17_01.Text = "17-01";
            this.btnDec17_01.UseVisualStyleBackColor = true;
            // 
            // groupDec16
            // 
            this.groupDec16.Controls.Add(this.txtDec16_02);
            this.groupDec16.Controls.Add(this.txtDec16_01);
            this.groupDec16.Controls.Add(this.btnDec16_02);
            this.groupDec16.Controls.Add(this.btnDec16_01);
            this.groupDec16.Location = new System.Drawing.Point(12, 300);
            this.groupDec16.Name = "groupDec16";
            this.groupDec16.Size = new System.Drawing.Size(183, 90);
            this.groupDec16.TabIndex = 19;
            this.groupDec16.TabStop = false;
            this.groupDec16.Text = "Dec 16";
            // 
            // txtDec16_02
            // 
            this.txtDec16_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec16_02.Name = "txtDec16_02";
            this.txtDec16_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec16_02.TabIndex = 3;
            // 
            // txtDec16_01
            // 
            this.txtDec16_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec16_01.Name = "txtDec16_01";
            this.txtDec16_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec16_01.TabIndex = 2;
            // 
            // btnDec16_02
            // 
            this.btnDec16_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec16_02.Name = "btnDec16_02";
            this.btnDec16_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec16_02.TabIndex = 1;
            this.btnDec16_02.Text = "16-02";
            this.btnDec16_02.UseVisualStyleBackColor = true;
            // 
            // btnDec16_01
            // 
            this.btnDec16_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec16_01.Name = "btnDec16_01";
            this.btnDec16_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec16_01.TabIndex = 0;
            this.btnDec16_01.Text = "16-01";
            this.btnDec16_01.UseVisualStyleBackColor = true;
            // 
            // groupDec25
            // 
            this.groupDec25.Controls.Add(this.txtDec25_02);
            this.groupDec25.Controls.Add(this.txtDec25_01);
            this.groupDec25.Controls.Add(this.btnDec25_02);
            this.groupDec25.Controls.Add(this.btnDec25_01);
            this.groupDec25.Location = new System.Drawing.Point(768, 396);
            this.groupDec25.Name = "groupDec25";
            this.groupDec25.Size = new System.Drawing.Size(183, 90);
            this.groupDec25.TabIndex = 28;
            this.groupDec25.TabStop = false;
            this.groupDec25.Text = "Dec 25";
            // 
            // txtDec25_02
            // 
            this.txtDec25_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec25_02.Name = "txtDec25_02";
            this.txtDec25_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec25_02.TabIndex = 3;
            // 
            // txtDec25_01
            // 
            this.txtDec25_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec25_01.Name = "txtDec25_01";
            this.txtDec25_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec25_01.TabIndex = 2;
            // 
            // btnDec25_02
            // 
            this.btnDec25_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec25_02.Name = "btnDec25_02";
            this.btnDec25_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec25_02.TabIndex = 1;
            this.btnDec25_02.Text = "25-02";
            this.btnDec25_02.UseVisualStyleBackColor = true;
            // 
            // btnDec25_01
            // 
            this.btnDec25_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec25_01.Name = "btnDec25_01";
            this.btnDec25_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec25_01.TabIndex = 0;
            this.btnDec25_01.Text = "25-01";
            this.btnDec25_01.UseVisualStyleBackColor = true;
            // 
            // groupDec24
            // 
            this.groupDec24.Controls.Add(this.txtDec24_02);
            this.groupDec24.Controls.Add(this.txtDec24_01);
            this.groupDec24.Controls.Add(this.btnDec24_02);
            this.groupDec24.Controls.Add(this.btnDec24_01);
            this.groupDec24.Location = new System.Drawing.Point(579, 396);
            this.groupDec24.Name = "groupDec24";
            this.groupDec24.Size = new System.Drawing.Size(183, 90);
            this.groupDec24.TabIndex = 27;
            this.groupDec24.TabStop = false;
            this.groupDec24.Text = "Dec 24";
            // 
            // txtDec24_02
            // 
            this.txtDec24_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec24_02.Name = "txtDec24_02";
            this.txtDec24_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec24_02.TabIndex = 3;
            // 
            // txtDec24_01
            // 
            this.txtDec24_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec24_01.Name = "txtDec24_01";
            this.txtDec24_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec24_01.TabIndex = 2;
            // 
            // btnDec24_02
            // 
            this.btnDec24_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec24_02.Name = "btnDec24_02";
            this.btnDec24_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec24_02.TabIndex = 1;
            this.btnDec24_02.Text = "24-02";
            this.btnDec24_02.UseVisualStyleBackColor = true;
            // 
            // btnDec24_01
            // 
            this.btnDec24_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec24_01.Name = "btnDec24_01";
            this.btnDec24_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec24_01.TabIndex = 0;
            this.btnDec24_01.Text = "24-01";
            this.btnDec24_01.UseVisualStyleBackColor = true;
            // 
            // groupDec23
            // 
            this.groupDec23.Controls.Add(this.txtDec23_02);
            this.groupDec23.Controls.Add(this.txtDec23_01);
            this.groupDec23.Controls.Add(this.btnDec23_02);
            this.groupDec23.Controls.Add(this.btnDec23_01);
            this.groupDec23.Location = new System.Drawing.Point(390, 396);
            this.groupDec23.Name = "groupDec23";
            this.groupDec23.Size = new System.Drawing.Size(183, 90);
            this.groupDec23.TabIndex = 26;
            this.groupDec23.TabStop = false;
            this.groupDec23.Text = "Dec 23";
            // 
            // txtDec23_02
            // 
            this.txtDec23_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec23_02.Name = "txtDec23_02";
            this.txtDec23_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec23_02.TabIndex = 3;
            // 
            // txtDec23_01
            // 
            this.txtDec23_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec23_01.Name = "txtDec23_01";
            this.txtDec23_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec23_01.TabIndex = 2;
            // 
            // btnDec23_02
            // 
            this.btnDec23_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec23_02.Name = "btnDec23_02";
            this.btnDec23_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec23_02.TabIndex = 1;
            this.btnDec23_02.Text = "23-02";
            this.btnDec23_02.UseVisualStyleBackColor = true;
            // 
            // btnDec23_01
            // 
            this.btnDec23_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec23_01.Name = "btnDec23_01";
            this.btnDec23_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec23_01.TabIndex = 0;
            this.btnDec23_01.Text = "23-01";
            this.btnDec23_01.UseVisualStyleBackColor = true;
            // 
            // groupDec22
            // 
            this.groupDec22.Controls.Add(this.txtDec22_02);
            this.groupDec22.Controls.Add(this.txtDec22_01);
            this.groupDec22.Controls.Add(this.btnDec22_02);
            this.groupDec22.Controls.Add(this.btnDec22_01);
            this.groupDec22.Location = new System.Drawing.Point(201, 396);
            this.groupDec22.Name = "groupDec22";
            this.groupDec22.Size = new System.Drawing.Size(183, 90);
            this.groupDec22.TabIndex = 25;
            this.groupDec22.TabStop = false;
            this.groupDec22.Text = "Dec 22";
            // 
            // txtDec22_02
            // 
            this.txtDec22_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec22_02.Name = "txtDec22_02";
            this.txtDec22_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec22_02.TabIndex = 3;
            // 
            // txtDec22_01
            // 
            this.txtDec22_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec22_01.Name = "txtDec22_01";
            this.txtDec22_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec22_01.TabIndex = 2;
            // 
            // btnDec22_02
            // 
            this.btnDec22_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec22_02.Name = "btnDec22_02";
            this.btnDec22_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec22_02.TabIndex = 1;
            this.btnDec22_02.Text = "22-02";
            this.btnDec22_02.UseVisualStyleBackColor = true;
            // 
            // btnDec22_01
            // 
            this.btnDec22_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec22_01.Name = "btnDec22_01";
            this.btnDec22_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec22_01.TabIndex = 0;
            this.btnDec22_01.Text = "22-01";
            this.btnDec22_01.UseVisualStyleBackColor = true;
            // 
            // groupDec21
            // 
            this.groupDec21.Controls.Add(this.txtDec21_02);
            this.groupDec21.Controls.Add(this.txtDec21_01);
            this.groupDec21.Controls.Add(this.btnDec21_02);
            this.groupDec21.Controls.Add(this.btnDec21_01);
            this.groupDec21.Location = new System.Drawing.Point(12, 396);
            this.groupDec21.Name = "groupDec21";
            this.groupDec21.Size = new System.Drawing.Size(183, 90);
            this.groupDec21.TabIndex = 24;
            this.groupDec21.TabStop = false;
            this.groupDec21.Text = "Dec 21";
            // 
            // txtDec21_02
            // 
            this.txtDec21_02.Location = new System.Drawing.Point(87, 52);
            this.txtDec21_02.Name = "txtDec21_02";
            this.txtDec21_02.Size = new System.Drawing.Size(75, 20);
            this.txtDec21_02.TabIndex = 3;
            // 
            // txtDec21_01
            // 
            this.txtDec21_01.Location = new System.Drawing.Point(6, 52);
            this.txtDec21_01.Name = "txtDec21_01";
            this.txtDec21_01.Size = new System.Drawing.Size(74, 20);
            this.txtDec21_01.TabIndex = 2;
            // 
            // btnDec21_02
            // 
            this.btnDec21_02.Location = new System.Drawing.Point(87, 22);
            this.btnDec21_02.Name = "btnDec21_02";
            this.btnDec21_02.Size = new System.Drawing.Size(75, 23);
            this.btnDec21_02.TabIndex = 1;
            this.btnDec21_02.Text = "21-02";
            this.btnDec21_02.UseVisualStyleBackColor = true;
            // 
            // btnDec21_01
            // 
            this.btnDec21_01.Location = new System.Drawing.Point(5, 23);
            this.btnDec21_01.Name = "btnDec21_01";
            this.btnDec21_01.Size = new System.Drawing.Size(75, 23);
            this.btnDec21_01.TabIndex = 0;
            this.btnDec21_01.Text = "21-01";
            this.btnDec21_01.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1029, 657);
            this.Controls.Add(this.groupDec25);
            this.Controls.Add(this.groupDec24);
            this.Controls.Add(this.groupDec23);
            this.Controls.Add(this.groupDec22);
            this.Controls.Add(this.groupDec21);
            this.Controls.Add(this.groupDec20);
            this.Controls.Add(this.groupDec19);
            this.Controls.Add(this.groupDec18);
            this.Controls.Add(this.groupDec17);
            this.Controls.Add(this.groupDec16);
            this.Controls.Add(this.groupDec15);
            this.Controls.Add(this.groupDec14);
            this.Controls.Add(this.groupDec13);
            this.Controls.Add(this.groupDec12);
            this.Controls.Add(this.groupDec11);
            this.Controls.Add(this.groupDec10);
            this.Controls.Add(this.groupDec09);
            this.Controls.Add(this.groupDec08);
            this.Controls.Add(this.groupDec07);
            this.Controls.Add(this.groupDec06);
            this.Controls.Add(this.groupDec05);
            this.Controls.Add(this.groupDec04);
            this.Controls.Add(this.groupDec03);
            this.Controls.Add(this.groupDec02);
            this.Controls.Add(this.groupDec01);
            this.Name = "Form1";
            this.Text = "Advent Calendar 2021";
            this.groupDec01.ResumeLayout(false);
            this.groupDec01.PerformLayout();
            this.groupDec02.ResumeLayout(false);
            this.groupDec02.PerformLayout();
            this.groupDec03.ResumeLayout(false);
            this.groupDec03.PerformLayout();
            this.groupDec04.ResumeLayout(false);
            this.groupDec04.PerformLayout();
            this.groupDec05.ResumeLayout(false);
            this.groupDec05.PerformLayout();
            this.groupDec09.ResumeLayout(false);
            this.groupDec09.PerformLayout();
            this.groupDec08.ResumeLayout(false);
            this.groupDec08.PerformLayout();
            this.groupDec07.ResumeLayout(false);
            this.groupDec07.PerformLayout();
            this.groupDec06.ResumeLayout(false);
            this.groupDec06.PerformLayout();
            this.groupDec10.ResumeLayout(false);
            this.groupDec10.PerformLayout();
            this.groupDec15.ResumeLayout(false);
            this.groupDec15.PerformLayout();
            this.groupDec14.ResumeLayout(false);
            this.groupDec14.PerformLayout();
            this.groupDec13.ResumeLayout(false);
            this.groupDec13.PerformLayout();
            this.groupDec12.ResumeLayout(false);
            this.groupDec12.PerformLayout();
            this.groupDec11.ResumeLayout(false);
            this.groupDec11.PerformLayout();
            this.groupDec20.ResumeLayout(false);
            this.groupDec20.PerformLayout();
            this.groupDec19.ResumeLayout(false);
            this.groupDec19.PerformLayout();
            this.groupDec18.ResumeLayout(false);
            this.groupDec18.PerformLayout();
            this.groupDec17.ResumeLayout(false);
            this.groupDec17.PerformLayout();
            this.groupDec16.ResumeLayout(false);
            this.groupDec16.PerformLayout();
            this.groupDec25.ResumeLayout(false);
            this.groupDec25.PerformLayout();
            this.groupDec24.ResumeLayout(false);
            this.groupDec24.PerformLayout();
            this.groupDec23.ResumeLayout(false);
            this.groupDec23.PerformLayout();
            this.groupDec22.ResumeLayout(false);
            this.groupDec22.PerformLayout();
            this.groupDec21.ResumeLayout(false);
            this.groupDec21.PerformLayout();
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

        private void btnDec02_01_Click(object sender, EventArgs e)
        {
            Dec_02 helper = new Dec_02();
            txtDec02_01.Text = helper.calculateForwardDown();
        }

        private void btnDec02_02_Click(object sender, EventArgs e)
        {
            Dec_02 helper = new Dec_02();
            txtDec02_02.Text = helper.calculateForwardDownWithAim();
        }

        private void btnDec03_01_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day3.txt");
            string[] output = dataInput.GetData();
            Day3_BinaryHandler bh = new Day3_BinaryHandler(output);
            txtDec03_01.Text = bh.GetPowerConsumption().ToString();
        }

        private void btnDec02_03_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day3.txt");
            string[] output = dataInput.GetData();
            Day3_BinaryHandler bh = new Day3_BinaryHandler(output);
            txtDec03_02.Text = bh.GetLifeSupportRating().ToString();
        }

        private void btnDec04_01_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day4.txt");
            string[] output = dataInput.GetData();

            Day4_Bingo bingo = new Day4_Bingo(output);
            Bingo_Card card = bingo.GetWinningCard();
            //Assert.AreEqual(188, card.CalculateBordScore(false));
            //Assert.AreEqual(24, bingo.GetLastCalledNumber());
            //Assert.AreEqual(4512, card.CalculateBordScore(false) * bingo.GetLastCalledNumber());
            txtDec04_01.Text = (card.CalculateBordScore(false) * bingo.GetLastCalledNumber()).ToString();
        }

        private void btnDec02_04_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day4.txt");
            string[] output = dataInput.GetData();

            Day4_Bingo bingo = new Day4_Bingo(output);
            Bingo_Card card = bingo.GetLoosingCard();
            txtDec04_02.Text = (card.CalculateBordScore(false) * bingo.GetLastCalledNumber()).ToString();
        }

        private void btnDec05_01_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day5.txt");
            string[] output = dataInput.GetData();

            Day5_HydroVents hv = new Day5_HydroVents(output);
            txtDec05_01.Text = hv.GetOverlaps(2).ToString();
        }

        private void btnDec05_02_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day5.txt");
            string[] output = dataInput.GetData();

            Day5_HydroVents hv = new Day5_HydroVents(output);
            txtDec05_02.Text = hv.GetOverlapsAllDirections(2).ToString();
        }

        private void btnDec06_01_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day6.txt", ",");
            string[] output = dataInput.GetData();
            Day6 lfClass = new Day6(output);
            lfClass.Breed(80);
            txtDec06_01.Text = lfClass.GetNumberOfFish().ToString();
        }

        private void btnDec06_02_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day6.txt", ",");
            string[] output = dataInput.GetData();
            Day6 lfClass = new Day6(output);
            lfClass.Breed(256);
            txtDec06_02.Text = lfClass.GetNumberOfFish().ToString();
        }

        private void btnDec07_01_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day7.txt", ",");
            string[] output = dataInput.GetData();
            Day7 lfClass = new Day7(output);

            txtDec07_01.Text = "Hello";
        }

        private void btnDec07_02_Click(object sender, EventArgs e)
        {
            IDataInput dataInput = new FileInput(@"C:\Users\christopher.walker\Source\Repos\christopher-walker\CodeCelendar\CodeCelendar\Day7.txt", ",");
            string[] output = dataInput.GetData();
            Day7 lfClass = new Day7(output);

            txtDec07_02.Text = "Hello";
        }
    }
}
