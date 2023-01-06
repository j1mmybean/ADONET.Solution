namespace ISpan.EStore.SqlDataLayer
{
	partial class FormCreateUser
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
			this.textBoxAccount = new System.Windows.Forms.TextBox();
			this.labelAccount = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
			this.labelDateOfBirth = new System.Windows.Forms.Label();
			this.textBoxHeight = new System.Windows.Forms.TextBox();
			this.labelHeight = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxAccount
			// 
			this.textBoxAccount.Location = new System.Drawing.Point(169, 55);
			this.textBoxAccount.Name = "textBoxAccount";
			this.textBoxAccount.Size = new System.Drawing.Size(261, 25);
			this.textBoxAccount.TabIndex = 0;
			// 
			// labelAccount
			// 
			this.labelAccount.AutoSize = true;
			this.labelAccount.Location = new System.Drawing.Point(72, 65);
			this.labelAccount.Name = "labelAccount";
			this.labelAccount.Size = new System.Drawing.Size(58, 15);
			this.labelAccount.TabIndex = 1;
			this.labelAccount.Text = "Account:";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(169, 86);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(261, 25);
			this.textBoxPassword.TabIndex = 0;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(72, 96);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(64, 15);
			this.labelPassword.TabIndex = 1;
			this.labelPassword.Text = "Password:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(169, 117);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(261, 25);
			this.textBoxName.TabIndex = 0;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(72, 127);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(44, 15);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Name:";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(169, 148);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(261, 25);
			this.textBoxEmail.TabIndex = 0;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(72, 158);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(45, 15);
			this.labelEmail.TabIndex = 1;
			this.labelEmail.Text = "Email:";
			// 
			// textBoxDateOfBirth
			// 
			this.textBoxDateOfBirth.Location = new System.Drawing.Point(169, 179);
			this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
			this.textBoxDateOfBirth.Size = new System.Drawing.Size(261, 25);
			this.textBoxDateOfBirth.TabIndex = 0;
			// 
			// labelDateOfBirth
			// 
			this.labelDateOfBirth.AutoSize = true;
			this.labelDateOfBirth.Location = new System.Drawing.Point(72, 189);
			this.labelDateOfBirth.Name = "labelDateOfBirth";
			this.labelDateOfBirth.Size = new System.Drawing.Size(86, 15);
			this.labelDateOfBirth.TabIndex = 1;
			this.labelDateOfBirth.Text = "Date of Birth:";
			// 
			// textBoxHeight
			// 
			this.textBoxHeight.Location = new System.Drawing.Point(169, 210);
			this.textBoxHeight.Name = "textBoxHeight";
			this.textBoxHeight.Size = new System.Drawing.Size(261, 25);
			this.textBoxHeight.TabIndex = 0;
			// 
			// labelHeight
			// 
			this.labelHeight.AutoSize = true;
			this.labelHeight.Location = new System.Drawing.Point(72, 220);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new System.Drawing.Size(49, 15);
			this.labelHeight.TabIndex = 1;
			this.labelHeight.Text = "Height:";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(357, 251);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(73, 33);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// FormCreateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 317);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelHeight);
			this.Controls.Add(this.labelDateOfBirth);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelAccount);
			this.Controls.Add(this.textBoxHeight);
			this.Controls.Add(this.textBoxDateOfBirth);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxAccount);
			this.Name = "FormCreateUser";
			this.Text = "FormCreateUser";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxAccount;
		private System.Windows.Forms.Label labelAccount;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textBoxDateOfBirth;
		private System.Windows.Forms.Label labelDateOfBirth;
		private System.Windows.Forms.TextBox textBoxHeight;
		private System.Windows.Forms.Label labelHeight;
		private System.Windows.Forms.Button buttonSave;
	}
}