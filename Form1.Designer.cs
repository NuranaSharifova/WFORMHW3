
namespace WFORMHW3
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.givenDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sname = new System.Windows.Forms.Label();
            this.StextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.NtextBox = new System.Windows.Forms.TextBox();
            this.FtextBox = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.Label();
            this.BDtextBox = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.Label();
            this.BPtextBox = new System.Windows.Forms.TextBox();
            this.BirthPlace = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bullToolStripMenuItem,
            this.givenDateToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // bullToolStripMenuItem
            // 
            this.bullToolStripMenuItem.Name = "bullToolStripMenuItem";
            this.bullToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bullToolStripMenuItem.Text = "BullYear";
            this.bullToolStripMenuItem.Click += new System.EventHandler(this.bullToolStripMenuItem_Click);
            // 
            // givenDateToolStripMenuItem
            // 
            this.givenDateToolStripMenuItem.Name = "givenDateToolStripMenuItem";
            this.givenDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.givenDateToolStripMenuItem.Text = "GivenDate";
            this.givenDateToolStripMenuItem.Click += new System.EventHandler(this.givenDateToolStripMenuItem_Click);
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Location = new System.Drawing.Point(461, 24);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(49, 13);
            this.Sname.TabIndex = 1;
            this.Sname.Text = "Surname";
            // 
            // StextBox
            // 
            this.StextBox.Location = new System.Drawing.Point(464, 52);
            this.StextBox.Name = "StextBox";
            this.StextBox.Size = new System.Drawing.Size(190, 20);
            this.StextBox.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(461, 85);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // NtextBox
            // 
            this.NtextBox.Location = new System.Drawing.Point(464, 116);
            this.NtextBox.Name = "NtextBox";
            this.NtextBox.Size = new System.Drawing.Size(190, 20);
            this.NtextBox.TabIndex = 4;
            // 
            // FtextBox
            // 
            this.FtextBox.Location = new System.Drawing.Point(464, 178);
            this.FtextBox.Name = "FtextBox";
            this.FtextBox.Size = new System.Drawing.Size(190, 20);
            this.FtextBox.TabIndex = 6;
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Location = new System.Drawing.Point(464, 148);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(65, 13);
            this.Fname.TabIndex = 5;
            this.Fname.Text = "FatherName";
            // 
            // BDtextBox
            // 
            this.BDtextBox.Location = new System.Drawing.Point(464, 245);
            this.BDtextBox.Name = "BDtextBox";
            this.BDtextBox.Size = new System.Drawing.Size(190, 20);
            this.BDtextBox.TabIndex = 8;
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(464, 212);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(45, 13);
            this.Birthday.TabIndex = 7;
            this.Birthday.Text = "Birthday";
            // 
            // BPtextBox
            // 
            this.BPtextBox.Location = new System.Drawing.Point(464, 310);
            this.BPtextBox.Name = "BPtextBox";
            this.BPtextBox.Size = new System.Drawing.Size(190, 20);
            this.BPtextBox.TabIndex = 10;
            // 
            // BirthPlace
            // 
            this.BirthPlace.AutoSize = true;
            this.BirthPlace.Location = new System.Drawing.Point(464, 277);
            this.BirthPlace.Name = "BirthPlace";
            this.BirthPlace.Size = new System.Drawing.Size(55, 13);
            this.BirthPlace.TabIndex = 9;
            this.BirthPlace.Text = "BirthPlace";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(401, 212);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 344);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BPtextBox);
            this.Controls.Add(this.BirthPlace);
            this.Controls.Add(this.BDtextBox);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.FtextBox);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.NtextBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.StextBox);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
          
            this.Text = "Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.TextBox StextBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NtextBox;
        private System.Windows.Forms.TextBox FtextBox;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.TextBox BDtextBox;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.TextBox BPtextBox;
        private System.Windows.Forms.Label BirthPlace;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bullToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem givenDateToolStripMenuItem;
    }
}

