
namespace software1
{
    partial class Form5
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
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rigisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advirtiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportOfProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.reportOfUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.advirtiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rigisterToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.displayItemsToolStripMenuItem,
            this.reportOfUserToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(59, 27);
            this.userToolStripMenuItem.Text = "User";
            // 
            // rigisterToolStripMenuItem
            // 
            this.rigisterToolStripMenuItem.Name = "rigisterToolStripMenuItem";
            this.rigisterToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.rigisterToolStripMenuItem.Text = "Register";
            this.rigisterToolStripMenuItem.Click += new System.EventHandler(this.rigisterToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // displayItemsToolStripMenuItem
            // 
            this.displayItemsToolStripMenuItem.Name = "displayItemsToolStripMenuItem";
            this.displayItemsToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.displayItemsToolStripMenuItem.Text = "Display Items";
            this.displayItemsToolStripMenuItem.Click += new System.EventHandler(this.displayItemsToolStripMenuItem_Click);
            // 
            // advirtiserToolStripMenuItem
            // 
            this.advirtiserToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.advirtiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPToolStripMenuItem,
            this.reportOfProductToolStripMenuItem});
            this.advirtiserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advirtiserToolStripMenuItem.Name = "advirtiserToolStripMenuItem";
            this.advirtiserToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.advirtiserToolStripMenuItem.Text = "Advertiser";
            // 
            // editPToolStripMenuItem
            // 
            this.editPToolStripMenuItem.Name = "editPToolStripMenuItem";
            this.editPToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.editPToolStripMenuItem.Text = "Edit product ";
            this.editPToolStripMenuItem.Click += new System.EventHandler(this.editPToolStripMenuItem_Click);
            // 
            // reportOfProductToolStripMenuItem
            // 
            this.reportOfProductToolStripMenuItem.Name = "reportOfProductToolStripMenuItem";
            this.reportOfProductToolStripMenuItem.Size = new System.Drawing.Size(240, 28);
            this.reportOfProductToolStripMenuItem.Text = "Report of product";
            this.reportOfProductToolStripMenuItem.Click += new System.EventHandler(this.reportOfProductToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Run to the Hills Personal Use", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 116);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to \r\nthe Action Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportOfUserToolStripMenuItem
            // 
            this.reportOfUserToolStripMenuItem.Name = "reportOfUserToolStripMenuItem";
            this.reportOfUserToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.reportOfUserToolStripMenuItem.Text = "Report of user";
            this.reportOfUserToolStripMenuItem.Click += new System.EventHandler(this.reportOfUserToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rigisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advirtiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportOfProductToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem reportOfUserToolStripMenuItem;
    }
}