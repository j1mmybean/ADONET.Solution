namespace ISpan.EStore.SqlDataLayer
{
	partial class FormCreateProducts
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
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelCategoryId = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxCategoryId = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(65, 133);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(40, 15);
			this.labelPrice.TabIndex = 33;
			this.labelPrice.Text = "Price:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(65, 102);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(44, 15);
			this.labelName.TabIndex = 34;
			this.labelName.Text = "Name:";
			// 
			// labelCategoryId
			// 
			this.labelCategoryId.AutoSize = true;
			this.labelCategoryId.Location = new System.Drawing.Point(65, 71);
			this.labelCategoryId.Name = "labelCategoryId";
			this.labelCategoryId.Size = new System.Drawing.Size(74, 15);
			this.labelCategoryId.TabIndex = 36;
			this.labelCategoryId.Text = "CategoryId:";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(162, 123);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(261, 25);
			this.textBoxPrice.TabIndex = 29;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(162, 92);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(261, 25);
			this.textBoxName.TabIndex = 30;
			// 
			// textBoxCategoryId
			// 
			this.textBoxCategoryId.Location = new System.Drawing.Point(162, 61);
			this.textBoxCategoryId.Name = "textBoxCategoryId";
			this.textBoxCategoryId.Size = new System.Drawing.Size(261, 25);
			this.textBoxCategoryId.TabIndex = 32;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(348, 169);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 37;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// FormCreateProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 234);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelCategoryId);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxCategoryId);
			this.Name = "FormCreateProducts";
			this.Text = "FormCreateProducts";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelCategoryId;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxCategoryId;
		private System.Windows.Forms.Button buttonSave;
	}
}