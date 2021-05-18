
namespace Proiect_PAW
{
    partial class Share_Portofolium
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Share_Portofolium));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNameShare = new System.Windows.Forms.TextBox();
            this.tbCompanyShare = new System.Windows.Forms.TextBox();
            this.tbPriceShare = new System.Windows.Forms.TextBox();
            this.btnAddShare = new System.Windows.Forms.Button();
            this.lvShares = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditShares = new System.Windows.Forms.Button();
            this.btnDeleteShare = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printTool = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnclipboard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(37, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(37, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(37, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company";
            // 
            // tbNameShare
            // 
            this.tbNameShare.AllowDrop = true;
            this.tbNameShare.Location = new System.Drawing.Point(144, 145);
            this.tbNameShare.Name = "tbNameShare";
            this.tbNameShare.Size = new System.Drawing.Size(100, 20);
            this.tbNameShare.TabIndex = 3;
            this.tbNameShare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbNameShare_MouseDown);
            this.tbNameShare.Validating += new System.ComponentModel.CancelEventHandler(this.tbNameShare_Validating);
            // 
            // tbCompanyShare
            // 
            this.tbCompanyShare.Location = new System.Drawing.Point(144, 235);
            this.tbCompanyShare.Name = "tbCompanyShare";
            this.tbCompanyShare.Size = new System.Drawing.Size(100, 20);
            this.tbCompanyShare.TabIndex = 4;
            this.tbCompanyShare.Validating += new System.ComponentModel.CancelEventHandler(this.tbCompanyShare_Validating);
            // 
            // tbPriceShare
            // 
            this.tbPriceShare.Location = new System.Drawing.Point(144, 188);
            this.tbPriceShare.Name = "tbPriceShare";
            this.tbPriceShare.Size = new System.Drawing.Size(100, 20);
            this.tbPriceShare.TabIndex = 5;
            this.tbPriceShare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPriceShare_KeyPress);
            // 
            // btnAddShare
            // 
            this.btnAddShare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddShare.ForeColor = System.Drawing.Color.Black;
            this.btnAddShare.Location = new System.Drawing.Point(144, 295);
            this.btnAddShare.Name = "btnAddShare";
            this.btnAddShare.Size = new System.Drawing.Size(100, 23);
            this.btnAddShare.TabIndex = 6;
            this.btnAddShare.Text = "Add &Share";
            this.btnAddShare.UseVisualStyleBackColor = false;
            this.btnAddShare.Click += new System.EventHandler(this.btnAddShare_Click);
            // 
            // lvShares
            // 
            this.lvShares.AllowDrop = true;
            this.lvShares.BackColor = System.Drawing.SystemColors.Window;
            this.lvShares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvShares.GridLines = true;
            this.lvShares.HideSelection = false;
            this.lvShares.Location = new System.Drawing.Point(394, 122);
            this.lvShares.Name = "lvShares";
            this.lvShares.Size = new System.Drawing.Size(365, 200);
            this.lvShares.TabIndex = 7;
            this.lvShares.UseCompatibleStateImageBehavior = false;
            this.lvShares.View = System.Windows.Forms.View.Details;
            this.lvShares.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvShares_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Symbol";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 58;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.Width = 243;
            // 
            // btnEditShares
            // 
            this.btnEditShares.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditShares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShares.ForeColor = System.Drawing.Color.Black;
            this.btnEditShares.Location = new System.Drawing.Point(525, 352);
            this.btnEditShares.Name = "btnEditShares";
            this.btnEditShares.Size = new System.Drawing.Size(100, 23);
            this.btnEditShares.TabIndex = 8;
            this.btnEditShares.Text = "&Edit";
            this.btnEditShares.UseVisualStyleBackColor = false;
            this.btnEditShares.Click += new System.EventHandler(this.btnEditShares_Click);
            // 
            // btnDeleteShare
            // 
            this.btnDeleteShare.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShare.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteShare.Location = new System.Drawing.Point(650, 352);
            this.btnDeleteShare.Name = "btnDeleteShare";
            this.btnDeleteShare.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteShare.TabIndex = 9;
            this.btnDeleteShare.TabStop = false;
            this.btnDeleteShare.Text = "&Delete";
            this.btnDeleteShare.UseVisualStyleBackColor = false;
            this.btnDeleteShare.Click += new System.EventHandler(this.btnDeleteShare_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Location = new System.Drawing.Point(390, 352);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 23);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(485, 96);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(269, 20);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.printTool,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // printTool
            // 
            this.printTool.Name = "printTool";
            this.printTool.Size = new System.Drawing.Size(137, 22);
            this.printTool.Text = "Print";
            this.printTool.Click += new System.EventHandler(this.printTool_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Document = this.printDocument;
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(390, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search Box";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnclipboard
            // 
            this.btnclipboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclipboard.ForeColor = System.Drawing.Color.Black;
            this.btnclipboard.Location = new System.Drawing.Point(157, 429);
            this.btnclipboard.Name = "btnclipboard";
            this.btnclipboard.Size = new System.Drawing.Size(100, 23);
            this.btnclipboard.TabIndex = 15;
            this.btnclipboard.Text = "Copy to clipboard";
            this.btnclipboard.UseVisualStyleBackColor = false;
            this.btnclipboard.Click += new System.EventHandler(this.btnclipboard_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(29, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Go to Main";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Share_Portofolium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclipboard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnDeleteShare);
            this.Controls.Add(this.btnEditShares);
            this.Controls.Add(this.lvShares);
            this.Controls.Add(this.btnAddShare);
            this.Controls.Add(this.tbPriceShare);
            this.Controls.Add(this.tbCompanyShare);
            this.Controls.Add(this.tbNameShare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Share_Portofolium";
            this.Text = "Share Portofolium";
            this.Load += new System.EventHandler(this.Share_Portofolium_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNameShare;
        private System.Windows.Forms.TextBox tbCompanyShare;
        private System.Windows.Forms.TextBox tbPriceShare;
        private System.Windows.Forms.Button btnAddShare;
        private System.Windows.Forms.ListView lvShares;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEditShares;
        private System.Windows.Forms.Button btnDeleteShare;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printTool;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnclipboard;
        private System.Windows.Forms.Button button1;
    }
}