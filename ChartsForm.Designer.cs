﻿
namespace Proiect_PAW
{
    partial class ChartsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIntermediary = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvIntermediary = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userControl11 = new Proiect_PAW.UserControl1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year Position";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(146, 62);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(100, 20);
            this.tbYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Intermediary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Transaction Value";
            // 
            // tbIntermediary
            // 
            this.tbIntermediary.Location = new System.Drawing.Point(146, 114);
            this.tbIntermediary.Name = "tbIntermediary";
            this.tbIntermediary.Size = new System.Drawing.Size(100, 20);
            this.tbIntermediary.TabIndex = 5;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(146, 155);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvIntermediary
            // 
            this.lvIntermediary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvIntermediary.GridLines = true;
            this.lvIntermediary.HideSelection = false;
            this.lvIntermediary.Location = new System.Drawing.Point(278, 45);
            this.lvIntermediary.Name = "lvIntermediary";
            this.lvIntermediary.Size = new System.Drawing.Size(374, 180);
            this.lvIntermediary.TabIndex = 8;
            this.lvIntermediary.UseCompatibleStateImageBehavior = false;
            this.lvIntermediary.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Year Position";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Intermediary";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Transaction Value";
            this.columnHeader3.Width = 150;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 231);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(359, 191);
            this.userControl11.TabIndex = 9;
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.lvIntermediary);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbIntermediary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label1);
            this.Name = "ChartsForm";
            this.Text = "ChartsForm";
            this.Load += new System.EventHandler(this.ChartsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIntermediary;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvIntermediary;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private UserControl1 userControl11;
    }
}