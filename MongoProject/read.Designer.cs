namespace MongoProject
{
    partial class read
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
            this.dgvRead = new System.Windows.Forms.DataGridView();
            this.labelNameOfBook = new System.Windows.Forms.Label();
            this.txtNameOfBook = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapReduceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRead
            // 
            this.dgvRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRead.Location = new System.Drawing.Point(21, 97);
            this.dgvRead.Name = "dgvRead";
            this.dgvRead.Size = new System.Drawing.Size(722, 328);
            this.dgvRead.TabIndex = 0;
            // 
            // labelNameOfBook
            // 
            this.labelNameOfBook.AutoSize = true;
            this.labelNameOfBook.Location = new System.Drawing.Point(116, 64);
            this.labelNameOfBook.Name = "labelNameOfBook";
            this.labelNameOfBook.Size = new System.Drawing.Size(102, 13);
            this.labelNameOfBook.TabIndex = 1;
            this.labelNameOfBook.Text = "Enter Name of book";
            // 
            // txtNameOfBook
            // 
            this.txtNameOfBook.Location = new System.Drawing.Point(239, 57);
            this.txtNameOfBook.Name = "txtNameOfBook";
            this.txtNameOfBook.Size = new System.Drawing.Size(178, 20);
            this.txtNameOfBook.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(448, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.showBookToolStripMenuItem,
            this.updateBookToolStripMenuItem,
            this.deleteBookToolStripMenuItem,
            this.mapReduceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // showBookToolStripMenuItem
            // 
            this.showBookToolStripMenuItem.Name = "showBookToolStripMenuItem";
            this.showBookToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.showBookToolStripMenuItem.Text = "Show Book";
            this.showBookToolStripMenuItem.Click += new System.EventHandler(this.showBookToolStripMenuItem_Click_1);
            // 
            // updateBookToolStripMenuItem
            // 
            this.updateBookToolStripMenuItem.Name = "updateBookToolStripMenuItem";
            this.updateBookToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.updateBookToolStripMenuItem.Text = "Update Book";
            this.updateBookToolStripMenuItem.Click += new System.EventHandler(this.updateBookToolStripMenuItem_Click_1);
            // 
            // deleteBookToolStripMenuItem
            // 
            this.deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            this.deleteBookToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.deleteBookToolStripMenuItem.Text = "Delete Book";
            this.deleteBookToolStripMenuItem.Click += new System.EventHandler(this.deleteBookToolStripMenuItem_Click_1);
            // 
            // mapReduceToolStripMenuItem
            // 
            this.mapReduceToolStripMenuItem.Name = "mapReduceToolStripMenuItem";
            this.mapReduceToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.mapReduceToolStripMenuItem.Text = "MapReduce";
            this.mapReduceToolStripMenuItem.Click += new System.EventHandler(this.mapReduceToolStripMenuItem_Click);
            // 
            // read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 447);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNameOfBook);
            this.Controls.Add(this.labelNameOfBook);
            this.Controls.Add(this.dgvRead);
            this.Name = "read";
            this.Text = "read";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRead)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRead;
        private System.Windows.Forms.Label labelNameOfBook;
        private System.Windows.Forms.TextBox txtNameOfBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapReduceToolStripMenuItem;
    }
}