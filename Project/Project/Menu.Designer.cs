namespace Project
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucSaveUser1 = new Project.ucSaveUser();
            this.logoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveUserToolStripMenuItem,
            this.listUserToolStripMenuItem,
            this.synchronizeToolStripMenuItem,
            this.logoutItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // saveUserToolStripMenuItem
            // 
            this.saveUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveUserToolStripMenuItem.Name = "saveUserToolStripMenuItem";
            this.saveUserToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.saveUserToolStripMenuItem.Text = "Save User";
            this.saveUserToolStripMenuItem.Click += new System.EventHandler(this.saveUserToolStripMenuItem_Click);
            // 
            // listUserToolStripMenuItem
            // 
            this.listUserToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listUserToolStripMenuItem.Name = "listUserToolStripMenuItem";
            this.listUserToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.listUserToolStripMenuItem.Text = "List User";
            // 
            // synchronizeToolStripMenuItem
            // 
            this.synchronizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.cloudToolStripMenuItem});
            this.synchronizeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.synchronizeToolStripMenuItem.Name = "synchronizeToolStripMenuItem";
            this.synchronizeToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.synchronizeToolStripMenuItem.Text = "Synchronize";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // cloudToolStripMenuItem
            // 
            this.cloudToolStripMenuItem.Name = "cloudToolStripMenuItem";
            this.cloudToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cloudToolStripMenuItem.Text = "Cloud";
            // 
            // ucSaveUser1
            // 
            this.ucSaveUser1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucSaveUser1.Location = new System.Drawing.Point(2, 33);
            this.ucSaveUser1.Name = "ucSaveUser1";
            this.ucSaveUser1.Size = new System.Drawing.Size(627, 307);
            this.ucSaveUser1.TabIndex = 2;
            // 
            // logoutItem
            // 
            this.logoutItem.Name = "logoutItem";
            this.logoutItem.Size = new System.Drawing.Size(58, 26);
            this.logoutItem.Text = "Logout";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 341);
            this.Controls.Add(this.ucSaveUser1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem synchronizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloudToolStripMenuItem;
        private ucSaveUser ucSaveUser1;
        private System.Windows.Forms.ToolStripMenuItem logoutItem;





    }
}

