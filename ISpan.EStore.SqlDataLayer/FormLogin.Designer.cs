namespace ISpan.EStore.SqlDataLayer
{
	partial class FormLogin
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
			this.labelAccount = new System.Windows.Forms.Label();
			this.textBoxAccount = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelAccount
			// 
			this.labelAccount.AutoSize = true;
			this.labelAccount.Location = new System.Drawing.Point(136, 61);
			this.labelAccount.Name = "labelAccount";
			this.labelAccount.Size = new System.Drawing.Size(54, 15);
			this.labelAccount.TabIndex = 0;
			this.labelAccount.Text = "Account";
			// 
			// textBoxAccount
			// 
			this.textBoxAccount.Location = new System.Drawing.Point(201, 51);
			this.textBoxAccount.Name = "textBoxAccount";
			this.textBoxAccount.Size = new System.Drawing.Size(100, 25);
			this.textBoxAccount.TabIndex = 1;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(136, 106);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(60, 15);
			this.labelPassword.TabIndex = 0;
			this.labelPassword.Text = "Password";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(202, 96);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(100, 25);
			this.textBoxPassword.TabIndex = 1;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(201, 141);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(100, 34);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 242);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.textBoxAccount);
			this.Controls.Add(this.labelAccount);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "FormLogin";
			this.Text = "FormLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAccount;
		private System.Windows.Forms.TextBox textBoxAccount;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonLogin;
	}
}