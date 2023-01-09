namespace ISpan.EStore.SqlDataLayer
{
	partial class FormEditUser
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
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.labelHeight = new System.Windows.Forms.Label();
			this.labelDateOfBirth = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxHeight = new System.Windows.Forms.TextBox();
			this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(344, 183);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(73, 33);
			this.buttonUpdate.TabIndex = 15;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// labelHeight
			// 
			this.labelHeight.AutoSize = true;
			this.labelHeight.Location = new System.Drawing.Point(59, 152);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new System.Drawing.Size(49, 15);
			this.labelHeight.TabIndex = 9;
			this.labelHeight.Text = "Height:";
			// 
			// labelDateOfBirth
			// 
			this.labelDateOfBirth.AutoSize = true;
			this.labelDateOfBirth.Location = new System.Drawing.Point(59, 121);
			this.labelDateOfBirth.Name = "labelDateOfBirth";
			this.labelDateOfBirth.Size = new System.Drawing.Size(86, 15);
			this.labelDateOfBirth.TabIndex = 10;
			this.labelDateOfBirth.Text = "Date of Birth:";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(59, 90);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(45, 15);
			this.labelEmail.TabIndex = 11;
			this.labelEmail.Text = "Email:";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(59, 59);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(44, 15);
			this.labelName.TabIndex = 12;
			this.labelName.Text = "Name:";
			// 
			// textBoxHeight
			// 
			this.textBoxHeight.Location = new System.Drawing.Point(156, 142);
			this.textBoxHeight.Name = "textBoxHeight";
			this.textBoxHeight.Size = new System.Drawing.Size(261, 25);
			this.textBoxHeight.TabIndex = 3;
			// 
			// textBoxDateOfBirth
			// 
			this.textBoxDateOfBirth.Location = new System.Drawing.Point(156, 111);
			this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
			this.textBoxDateOfBirth.Size = new System.Drawing.Size(261, 25);
			this.textBoxDateOfBirth.TabIndex = 4;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(156, 80);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(261, 25);
			this.textBoxEmail.TabIndex = 5;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(156, 49);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(261, 25);
			this.textBoxName.TabIndex = 6;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(240, 183);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(73, 33);
			this.buttonDelete.TabIndex = 16;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormEditUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 249);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.labelHeight);
			this.Controls.Add(this.labelDateOfBirth);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxHeight);
			this.Controls.Add(this.textBoxDateOfBirth);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxName);
			this.Name = "FormEditUser";
			this.Text = "FormEditUser";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Label labelHeight;
		private System.Windows.Forms.Label labelDateOfBirth;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxHeight;
		private System.Windows.Forms.TextBox textBoxDateOfBirth;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}