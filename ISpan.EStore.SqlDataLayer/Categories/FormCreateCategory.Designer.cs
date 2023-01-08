namespace ISpan.EStore.SqlDataLayer.Categories
{
	partial class FormCreateCategory
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
			this.textBoxDisplayOrder = new System.Windows.Forms.TextBox();
			this.labelDisplayOrder = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxDisplayOrder
			// 
			this.textBoxDisplayOrder.Location = new System.Drawing.Point(198, 131);
			this.textBoxDisplayOrder.Name = "textBoxDisplayOrder";
			this.textBoxDisplayOrder.Size = new System.Drawing.Size(180, 25);
			this.textBoxDisplayOrder.TabIndex = 5;
			// 
			// labelDisplayOrder
			// 
			this.labelDisplayOrder.AutoSize = true;
			this.labelDisplayOrder.Location = new System.Drawing.Point(77, 134);
			this.labelDisplayOrder.Name = "labelDisplayOrder";
			this.labelDisplayOrder.Size = new System.Drawing.Size(83, 15);
			this.labelDisplayOrder.TabIndex = 3;
			this.labelDisplayOrder.Text = "DisplayOrder";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(198, 83);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(180, 25);
			this.textBoxName.TabIndex = 6;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(77, 83);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(40, 15);
			this.labelName.TabIndex = 4;
			this.labelName.Text = "Name";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(303, 194);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// FormCreateCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 275);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.textBoxDisplayOrder);
			this.Controls.Add(this.labelDisplayOrder);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Name = "FormCreateCategory";
			this.Text = "FormCreateCategory";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxDisplayOrder;
		private System.Windows.Forms.Label labelDisplayOrder;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Button buttonSave;
	}
}