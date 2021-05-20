
namespace Proiect_PAW
{
    partial class EditShares
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
            this.btnok = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPriceShare = new System.Windows.Forms.TextBox();
            this.tbCompanyShare = new System.Windows.Forms.TextBox();
            this.tbNameShare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.ForeColor = System.Drawing.Color.Black;
            this.btnok.Location = new System.Drawing.Point(117, 296);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(100, 23);
            this.btnok.TabIndex = 13;
            this.btnok.Text = "&Ok";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(261, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbPriceShare
            // 
            this.tbPriceShare.Location = new System.Drawing.Point(211, 214);
            this.tbPriceShare.Name = "tbPriceShare";
            this.tbPriceShare.Size = new System.Drawing.Size(100, 20);
            this.tbPriceShare.TabIndex = 20;
            // 
            // tbCompanyShare
            // 
            this.tbCompanyShare.Location = new System.Drawing.Point(211, 261);
            this.tbCompanyShare.Name = "tbCompanyShare";
            this.tbCompanyShare.Size = new System.Drawing.Size(100, 20);
            this.tbCompanyShare.TabIndex = 19;
            // 
            // tbNameShare
            // 
            this.tbNameShare.AllowDrop = true;
            this.tbNameShare.Location = new System.Drawing.Point(211, 171);
            this.tbNameShare.Name = "tbNameShare";
            this.tbNameShare.Size = new System.Drawing.Size(100, 20);
            this.tbNameShare.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(104, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(104, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(104, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Symbol";
            // 
            // EditShares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.tbPriceShare);
            this.Controls.Add(this.tbCompanyShare);
            this.Controls.Add(this.tbNameShare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnok);
            this.Name = "EditShares";
            this.Text = "EditShares";
            this.Load += new System.EventHandler(this.EditShares_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbPriceShare;
        private System.Windows.Forms.TextBox tbCompanyShare;
        private System.Windows.Forms.TextBox tbNameShare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}