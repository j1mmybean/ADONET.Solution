namespace ISpan.EStore.SqlDataLayer
{
	partial class FormProducts
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttonAddNew = new System.Windows.Forms.Button();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.textBoxCategoryId = new System.Windows.Forms.TextBox();
			this.labelCategotyId = new System.Windows.Forms.Label();
			this.labelProductName = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(53, 80);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(743, 274);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// buttonAddNew
			// 
			this.buttonAddNew.Location = new System.Drawing.Point(696, 360);
			this.buttonAddNew.Name = "buttonAddNew";
			this.buttonAddNew.Size = new System.Drawing.Size(100, 23);
			this.buttonAddNew.TabIndex = 2;
			this.buttonAddNew.Text = "Add New...";
			this.buttonAddNew.UseVisualStyleBackColor = true;
			this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.Location = new System.Drawing.Point(326, 37);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(140, 25);
			this.textBoxProductName.TabIndex = 12;
			// 
			// textBoxCategoryId
			// 
			this.textBoxCategoryId.Location = new System.Drawing.Point(126, 37);
			this.textBoxCategoryId.Name = "textBoxCategoryId";
			this.textBoxCategoryId.Size = new System.Drawing.Size(74, 25);
			this.textBoxCategoryId.TabIndex = 11;
			// 
			// labelCategotyId
			// 
			this.labelCategotyId.AutoSize = true;
			this.labelCategotyId.Location = new System.Drawing.Point(50, 43);
			this.labelCategotyId.Name = "labelCategotyId";
			this.labelCategotyId.Size = new System.Drawing.Size(70, 15);
			this.labelCategotyId.TabIndex = 10;
			this.labelCategotyId.Text = "CategoryId";
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Location = new System.Drawing.Point(232, 44);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(88, 15);
			this.labelProductName.TabIndex = 13;
			this.labelProductName.Text = "Product Name";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(667, 38);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(129, 27);
			this.buttonSearch.TabIndex = 14;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// FormProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 406);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxProductName);
			this.Controls.Add(this.textBoxCategoryId);
			this.Controls.Add(this.labelCategotyId);
			this.Controls.Add(this.labelProductName);
			this.Controls.Add(this.buttonAddNew);
			this.Controls.Add(this.dataGridView1);
			this.Name = "FormProducts";
			this.Text = "FormProducts";
			this.Load += new System.EventHandler(this.FormProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttonAddNew;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.TextBox textBoxCategoryId;
		private System.Windows.Forms.Label labelCategotyId;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Button buttonSearch;
	}
}