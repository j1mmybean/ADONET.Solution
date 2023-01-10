namespace ISpan.EStore.SqlDataLayer
{
	partial class FormUsers
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
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonAddNew = new System.Windows.Forms.Button();
			this.labelName = new System.Windows.Forms.Label();
			this.labelAccount = new System.Windows.Forms.Label();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxAccount = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.userEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userEntityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(589, 47);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(100, 29);
			this.buttonSearch.TabIndex = 0;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonAddNew
			// 
			this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddNew.Location = new System.Drawing.Point(968, 393);
			this.buttonAddNew.Name = "buttonAddNew";
			this.buttonAddNew.Size = new System.Drawing.Size(100, 23);
			this.buttonAddNew.TabIndex = 1;
			this.buttonAddNew.Text = "Add New...";
			this.buttonAddNew.UseVisualStyleBackColor = true;
			this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(62, 57);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(44, 15);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Name:";
			// 
			// labelAccount
			// 
			this.labelAccount.AutoSize = true;
			this.labelAccount.Location = new System.Drawing.Point(231, 57);
			this.labelAccount.Name = "labelAccount";
			this.labelAccount.Size = new System.Drawing.Size(58, 15);
			this.labelAccount.TabIndex = 3;
			this.labelAccount.Text = "Account:";
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(414, 57);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(45, 15);
			this.labelEmail.TabIndex = 4;
			this.labelEmail.Text = "Email:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(109, 47);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 25);
			this.textBoxName.TabIndex = 5;
			// 
			// textBoxAccount
			// 
			this.textBoxAccount.Location = new System.Drawing.Point(291, 47);
			this.textBoxAccount.Name = "textBoxAccount";
			this.textBoxAccount.Size = new System.Drawing.Size(100, 25);
			this.textBoxAccount.TabIndex = 6;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(460, 47);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(100, 25);
			this.textBoxEmail.TabIndex = 7;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userEntityBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(65, 91);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(1003, 283);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// userEntityBindingSource
			// 
			this.userEntityBindingSource.DataSource = typeof(ISpan.EStore.BLL.Core.UserEntity);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 120;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 125;
			// 
			// accountDataGridViewTextBoxColumn
			// 
			this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
			this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
			this.accountDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
			this.accountDataGridViewTextBoxColumn.ReadOnly = true;
			this.accountDataGridViewTextBoxColumn.Width = 125;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
			this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
			this.passwordDataGridViewTextBoxColumn.Width = 125;
			// 
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			this.dateOfBirthDataGridViewTextBoxColumn.Width = 125;
			// 
			// heightDataGridViewTextBoxColumn
			// 
			this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
			this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
			this.heightDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
			this.heightDataGridViewTextBoxColumn.Width = 125;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.Width = 125;
			// 
			// FormUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1179, 470);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxAccount);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.labelAccount);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.buttonAddNew);
			this.Controls.Add(this.buttonSearch);
			this.Name = "FormUsers";
			this.Text = "FormUsers";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userEntityBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button buttonAddNew;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelAccount;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxAccount;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource userEntityBindingSource;
	}
}