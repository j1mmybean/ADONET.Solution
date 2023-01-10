namespace ISpan.EStore.SqlDataLayer
{
	partial class FormMain
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
			this.maintainNewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintainProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintainCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.maintainToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintainNewsToolStripMenuItem,
            this.maintainToolStripMenuItem,
            this.maintainProductsToolStripMenuItem,
            this.maintainCategoriesToolStripMenuItem,
            this.form1ToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.maintainToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1150, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// maintainNewsToolStripMenuItem
			// 
			this.maintainNewsToolStripMenuItem.Name = "maintainNewsToolStripMenuItem";
			this.maintainNewsToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
			this.maintainNewsToolStripMenuItem.Text = "Maintain News(&N)";
			this.maintainNewsToolStripMenuItem.Click += new System.EventHandler(this.maintainNewsToolStripMenuItem_Click);
			// 
			// maintainToolStripMenuItem
			// 
			this.maintainToolStripMenuItem.Name = "maintainToolStripMenuItem";
			this.maintainToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
			this.maintainToolStripMenuItem.Text = "Maintain Users";
			// 
			// maintainProductsToolStripMenuItem
			// 
			this.maintainProductsToolStripMenuItem.Name = "maintainProductsToolStripMenuItem";
			this.maintainProductsToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
			this.maintainProductsToolStripMenuItem.Text = "Maintain Products";
			this.maintainProductsToolStripMenuItem.Click += new System.EventHandler(this.maintainProductsToolStripMenuItem_Click);
			// 
			// maintainCategoriesToolStripMenuItem
			// 
			this.maintainCategoriesToolStripMenuItem.Name = "maintainCategoriesToolStripMenuItem";
			this.maintainCategoriesToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
			this.maintainCategoriesToolStripMenuItem.Text = "Maintain Categories";
			// 
			// form1ToolStripMenuItem
			// 
			this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
			this.form1ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
			this.form1ToolStripMenuItem.Text = "Form 1";
			// 
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
			this.logOutToolStripMenuItem.Text = "Log out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
			// 
			// maintainToolStripMenuItem1
			// 
			this.maintainToolStripMenuItem1.Name = "maintainToolStripMenuItem1";
			this.maintainToolStripMenuItem1.Size = new System.Drawing.Size(84, 24);
			this.maintainToolStripMenuItem1.Text = "Maintain";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem maintainNewsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintainProductsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintainCategoriesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maintainToolStripMenuItem1;
	}
}