namespace ISpan.EStore.SqlDataLayer
{
	partial class FormEditProducts
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
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelCategoryId = new System.Windows.Forms.Label();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxCategoryId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(252, 152);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(73, 33);
			this.buttonDelete.TabIndex = 30;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(356, 152);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(73, 33);
			this.buttonUpdate.TabIndex = 29;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(71, 131);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(40, 15);
			this.labelPrice.TabIndex = 25;
			this.labelPrice.Text = "Price:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(71, 100);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(44, 15);
			this.labelName.TabIndex = 26;
			this.labelName.Text = "Name:";
			// 
			// labelCategoryId
			// 
			this.labelCategoryId.AutoSize = true;
			this.labelCategoryId.Location = new System.Drawing.Point(71, 69);
			this.labelCategoryId.Name = "labelCategoryId";
			this.labelCategoryId.Size = new System.Drawing.Size(74, 15);
			this.labelCategoryId.TabIndex = 28;
			this.labelCategoryId.Text = "CategoryId:";
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(168, 121);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(261, 25);
			this.textBoxPrice.TabIndex = 19;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(168, 90);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(261, 25);
			this.textBoxName.TabIndex = 20;
			// 
			// textBoxCategoryId
			// 
			this.textBoxCategoryId.Location = new System.Drawing.Point(168, 59);
			this.textBoxCategoryId.Name = "textBoxCategoryId";
			this.textBoxCategoryId.Size = new System.Drawing.Size(261, 25);
			this.textBoxCategoryId.TabIndex = 22;
			// 
			// FormEditProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 226);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelCategoryId);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxCategoryId);
			this.Name = "FormEditProducts";
			this.Text = "FormEditProducts";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelCategoryId;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxCategoryId;
	}
}