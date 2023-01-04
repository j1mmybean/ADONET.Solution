namespace ISpan.EStore.SqlDataLayer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
			this.buttonGetConnectionString = new System.Windows.Forms.Button();
			this.buttonGetConnection = new System.Windows.Forms.Button();
			this.checkBoxPooling = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.labelId = new System.Windows.Forms.Label();
			this.textBoxCategoryId = new System.Windows.Forms.TextBox();
			this.buttonExcuteScalar = new System.Windows.Forms.Button();
			this.buttonGetProducts = new System.Windows.Forms.Button();
			this.textBoxPruductName = new System.Windows.Forms.TextBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.buttonCreateNews = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonGetConnectionString
			// 
			this.buttonGetConnectionString.Location = new System.Drawing.Point(68, 55);
			this.buttonGetConnectionString.Name = "buttonGetConnectionString";
			this.buttonGetConnectionString.Size = new System.Drawing.Size(199, 47);
			this.buttonGetConnectionString.TabIndex = 0;
			this.buttonGetConnectionString.Text = "GetConnectionString";
			this.buttonGetConnectionString.UseVisualStyleBackColor = true;
			this.buttonGetConnectionString.Click += new System.EventHandler(this.buttonGetConnectionString_Click);
			// 
			// buttonGetConnection
			// 
			this.buttonGetConnection.Location = new System.Drawing.Point(68, 126);
			this.buttonGetConnection.Name = "buttonGetConnection";
			this.buttonGetConnection.Size = new System.Drawing.Size(199, 47);
			this.buttonGetConnection.TabIndex = 1;
			this.buttonGetConnection.Text = "GetConnection";
			this.buttonGetConnection.UseVisualStyleBackColor = true;
			this.buttonGetConnection.Click += new System.EventHandler(this.buttonGetConnection_Click);
			// 
			// checkBoxPooling
			// 
			this.checkBoxPooling.AutoSize = true;
			this.checkBoxPooling.Location = new System.Drawing.Point(301, 141);
			this.checkBoxPooling.Name = "checkBoxPooling";
			this.checkBoxPooling.Size = new System.Drawing.Size(73, 19);
			this.checkBoxPooling.TabIndex = 2;
			this.checkBoxPooling.Text = "Pooling";
			this.checkBoxPooling.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(68, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 47);
			this.button1.TabIndex = 3;
			this.button1.Text = "讀取一筆Category";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelId
			// 
			this.labelId.AutoSize = true;
			this.labelId.Location = new System.Drawing.Point(298, 211);
			this.labelId.Name = "labelId";
			this.labelId.Size = new System.Drawing.Size(19, 15);
			this.labelId.TabIndex = 4;
			this.labelId.Text = "Id";
			// 
			// textBoxCategoryId
			// 
			this.textBoxCategoryId.Location = new System.Drawing.Point(346, 208);
			this.textBoxCategoryId.Name = "textBoxCategoryId";
			this.textBoxCategoryId.Size = new System.Drawing.Size(140, 25);
			this.textBoxCategoryId.TabIndex = 5;
			// 
			// buttonExcuteScalar
			// 
			this.buttonExcuteScalar.Location = new System.Drawing.Point(68, 273);
			this.buttonExcuteScalar.Name = "buttonExcuteScalar";
			this.buttonExcuteScalar.Size = new System.Drawing.Size(199, 47);
			this.buttonExcuteScalar.TabIndex = 6;
			this.buttonExcuteScalar.Text = "ExcuteScalar";
			this.buttonExcuteScalar.UseVisualStyleBackColor = true;
			this.buttonExcuteScalar.Click += new System.EventHandler(this.buttonExcuteScalar_Click);
			// 
			// buttonGetProducts
			// 
			this.buttonGetProducts.Location = new System.Drawing.Point(68, 336);
			this.buttonGetProducts.Name = "buttonGetProducts";
			this.buttonGetProducts.Size = new System.Drawing.Size(199, 47);
			this.buttonGetProducts.TabIndex = 7;
			this.buttonGetProducts.Text = "顯示多筆Product";
			this.buttonGetProducts.UseVisualStyleBackColor = true;
			this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
			// 
			// textBoxPruductName
			// 
			this.textBoxPruductName.Location = new System.Drawing.Point(432, 280);
			this.textBoxPruductName.Name = "textBoxPruductName";
			this.textBoxPruductName.Size = new System.Drawing.Size(140, 25);
			this.textBoxPruductName.TabIndex = 8;
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Location = new System.Drawing.Point(298, 283);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(88, 15);
			this.labelProductName.TabIndex = 9;
			this.labelProductName.Text = "Product Name";
			// 
			// buttonCreateNews
			// 
			this.buttonCreateNews.Location = new System.Drawing.Point(68, 425);
			this.buttonCreateNews.Name = "buttonCreateNews";
			this.buttonCreateNews.Size = new System.Drawing.Size(199, 47);
			this.buttonCreateNews.TabIndex = 10;
			this.buttonCreateNews.Text = "Create News";
			this.buttonCreateNews.UseVisualStyleBackColor = true;
			this.buttonCreateNews.Click += new System.EventHandler(this.buttonCreateNews_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 522);
			this.Controls.Add(this.buttonCreateNews);
			this.Controls.Add(this.labelProductName);
			this.Controls.Add(this.textBoxPruductName);
			this.Controls.Add(this.buttonGetProducts);
			this.Controls.Add(this.buttonExcuteScalar);
			this.Controls.Add(this.textBoxCategoryId);
			this.Controls.Add(this.labelId);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBoxPooling);
			this.Controls.Add(this.buttonGetConnection);
			this.Controls.Add(this.buttonGetConnectionString);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetConnectionString;
        private System.Windows.Forms.Button buttonGetConnection;
        private System.Windows.Forms.CheckBox checkBoxPooling;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxCategoryId;
        private System.Windows.Forms.Button buttonExcuteScalar;
        private System.Windows.Forms.Button buttonGetProducts;
		private System.Windows.Forms.TextBox textBoxPruductName;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Button buttonCreateNews;
	}
}

