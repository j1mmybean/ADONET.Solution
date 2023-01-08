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
			this.labelCategoryId = new System.Windows.Forms.Label();
			this.textBoxCategoryId = new System.Windows.Forms.TextBox();
			this.buttonExcuteScalar = new System.Windows.Forms.Button();
			this.buttonGetProducts = new System.Windows.Forms.Button();
			this.textBoxPruductName = new System.Windows.Forms.TextBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.buttonCreateNews = new System.Windows.Forms.Button();
			this.buttonEditNews = new System.Windows.Forms.Button();
			this.textBoxNewsId = new System.Windows.Forms.TextBox();
			this.labelNewsId = new System.Windows.Forms.Label();
			this.buttonDeleteNews = new System.Windows.Forms.Button();
			this.buttonMaintainUsers = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBoxProductCategoryId = new System.Windows.Forms.TextBox();
			this.labelProductId = new System.Windows.Forms.Label();
			this.buttonEditCategory = new System.Windows.Forms.Button();
			this.buttonNews = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonGetConnectionString
			// 
			this.buttonGetConnectionString.Location = new System.Drawing.Point(34, 12);
			this.buttonGetConnectionString.Name = "buttonGetConnectionString";
			this.buttonGetConnectionString.Size = new System.Drawing.Size(199, 47);
			this.buttonGetConnectionString.TabIndex = 0;
			this.buttonGetConnectionString.Text = "GetConnectionString";
			this.buttonGetConnectionString.UseVisualStyleBackColor = true;
			this.buttonGetConnectionString.Click += new System.EventHandler(this.buttonGetConnectionString_Click);
			// 
			// buttonGetConnection
			// 
			this.buttonGetConnection.Location = new System.Drawing.Point(34, 65);
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
			this.checkBoxPooling.Location = new System.Drawing.Point(239, 80);
			this.checkBoxPooling.Name = "checkBoxPooling";
			this.checkBoxPooling.Size = new System.Drawing.Size(73, 19);
			this.checkBoxPooling.TabIndex = 2;
			this.checkBoxPooling.Text = "Pooling";
			this.checkBoxPooling.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 47);
			this.button1.TabIndex = 3;
			this.button1.Text = "讀取一筆Category";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelCategoryId
			// 
			this.labelCategoryId.AutoSize = true;
			this.labelCategoryId.Location = new System.Drawing.Point(17, 133);
			this.labelCategoryId.Name = "labelCategoryId";
			this.labelCategoryId.Size = new System.Drawing.Size(19, 15);
			this.labelCategoryId.TabIndex = 4;
			this.labelCategoryId.Text = "Id";
			// 
			// textBoxCategoryId
			// 
			this.textBoxCategoryId.Location = new System.Drawing.Point(65, 130);
			this.textBoxCategoryId.Name = "textBoxCategoryId";
			this.textBoxCategoryId.Size = new System.Drawing.Size(140, 25);
			this.textBoxCategoryId.TabIndex = 5;
			// 
			// buttonExcuteScalar
			// 
			this.buttonExcuteScalar.Location = new System.Drawing.Point(6, 77);
			this.buttonExcuteScalar.Name = "buttonExcuteScalar";
			this.buttonExcuteScalar.Size = new System.Drawing.Size(199, 47);
			this.buttonExcuteScalar.TabIndex = 6;
			this.buttonExcuteScalar.Text = "ExcuteScalar";
			this.buttonExcuteScalar.UseVisualStyleBackColor = true;
			this.buttonExcuteScalar.Click += new System.EventHandler(this.buttonExcuteScalar_Click);
			// 
			// buttonGetProducts
			// 
			this.buttonGetProducts.Location = new System.Drawing.Point(40, 24);
			this.buttonGetProducts.Name = "buttonGetProducts";
			this.buttonGetProducts.Size = new System.Drawing.Size(199, 47);
			this.buttonGetProducts.TabIndex = 7;
			this.buttonGetProducts.Text = "顯示多筆Product";
			this.buttonGetProducts.UseVisualStyleBackColor = true;
			this.buttonGetProducts.Click += new System.EventHandler(this.buttonGetProducts_Click);
			// 
			// textBoxPruductName
			// 
			this.textBoxPruductName.Location = new System.Drawing.Point(114, 125);
			this.textBoxPruductName.Name = "textBoxPruductName";
			this.textBoxPruductName.Size = new System.Drawing.Size(140, 25);
			this.textBoxPruductName.TabIndex = 8;
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Location = new System.Drawing.Point(20, 128);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(88, 15);
			this.labelProductName.TabIndex = 9;
			this.labelProductName.Text = "Product Name";
			// 
			// buttonCreateNews
			// 
			this.buttonCreateNews.Location = new System.Drawing.Point(18, 24);
			this.buttonCreateNews.Name = "buttonCreateNews";
			this.buttonCreateNews.Size = new System.Drawing.Size(199, 47);
			this.buttonCreateNews.TabIndex = 10;
			this.buttonCreateNews.Text = "Create News";
			this.buttonCreateNews.UseVisualStyleBackColor = true;
			this.buttonCreateNews.Click += new System.EventHandler(this.buttonCreateNews_Click);
			// 
			// buttonEditNews
			// 
			this.buttonEditNews.Location = new System.Drawing.Point(18, 77);
			this.buttonEditNews.Name = "buttonEditNews";
			this.buttonEditNews.Size = new System.Drawing.Size(90, 47);
			this.buttonEditNews.TabIndex = 11;
			this.buttonEditNews.Text = "編輯News";
			this.buttonEditNews.UseVisualStyleBackColor = true;
			this.buttonEditNews.Click += new System.EventHandler(this.buttonEditNews_Click);
			// 
			// textBoxNewsId
			// 
			this.textBoxNewsId.Location = new System.Drawing.Point(98, 141);
			this.textBoxNewsId.Name = "textBoxNewsId";
			this.textBoxNewsId.Size = new System.Drawing.Size(140, 25);
			this.textBoxNewsId.TabIndex = 8;
			// 
			// labelNewsId
			// 
			this.labelNewsId.AutoSize = true;
			this.labelNewsId.Location = new System.Drawing.Point(20, 144);
			this.labelNewsId.Name = "labelNewsId";
			this.labelNewsId.Size = new System.Drawing.Size(62, 15);
			this.labelNewsId.TabIndex = 9;
			this.labelNewsId.Text = "News Id :";
			// 
			// buttonDeleteNews
			// 
			this.buttonDeleteNews.Location = new System.Drawing.Point(127, 77);
			this.buttonDeleteNews.Name = "buttonDeleteNews";
			this.buttonDeleteNews.Size = new System.Drawing.Size(90, 47);
			this.buttonDeleteNews.TabIndex = 12;
			this.buttonDeleteNews.Text = "刪除News";
			this.buttonDeleteNews.UseVisualStyleBackColor = true;
			this.buttonDeleteNews.Click += new System.EventHandler(this.buttonDeleteNews_Click);
			// 
			// buttonMaintainUsers
			// 
			this.buttonMaintainUsers.Location = new System.Drawing.Point(57, 488);
			this.buttonMaintainUsers.Name = "buttonMaintainUsers";
			this.buttonMaintainUsers.Size = new System.Drawing.Size(199, 47);
			this.buttonMaintainUsers.TabIndex = 13;
			this.buttonMaintainUsers.Text = "MaintainUsers";
			this.buttonMaintainUsers.UseVisualStyleBackColor = true;
			this.buttonMaintainUsers.Click += new System.EventHandler(this.buttonMaintainUsers_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonNews);
			this.groupBox1.Controls.Add(this.buttonCreateNews);
			this.groupBox1.Controls.Add(this.textBoxNewsId);
			this.groupBox1.Controls.Add(this.buttonDeleteNews);
			this.groupBox1.Controls.Add(this.labelNewsId);
			this.groupBox1.Controls.Add(this.buttonEditNews);
			this.groupBox1.Location = new System.Drawing.Point(34, 178);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 246);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "News";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonEditCategory);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.buttonExcuteScalar);
			this.groupBox2.Controls.Add(this.textBoxCategoryId);
			this.groupBox2.Controls.Add(this.labelCategoryId);
			this.groupBox2.Location = new System.Drawing.Point(402, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(329, 246);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Category";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.buttonGetProducts);
			this.groupBox3.Controls.Add(this.textBoxPruductName);
			this.groupBox3.Controls.Add(this.textBoxProductCategoryId);
			this.groupBox3.Controls.Add(this.labelProductId);
			this.groupBox3.Controls.Add(this.labelProductName);
			this.groupBox3.Location = new System.Drawing.Point(408, 319);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(285, 216);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Product";
			// 
			// textBoxProductCategoryId
			// 
			this.textBoxProductCategoryId.Location = new System.Drawing.Point(114, 80);
			this.textBoxProductCategoryId.Name = "textBoxProductCategoryId";
			this.textBoxProductCategoryId.Size = new System.Drawing.Size(140, 25);
			this.textBoxProductCategoryId.TabIndex = 5;
			// 
			// labelProductId
			// 
			this.labelProductId.AutoSize = true;
			this.labelProductId.Location = new System.Drawing.Point(51, 80);
			this.labelProductId.Name = "labelProductId";
			this.labelProductId.Size = new System.Drawing.Size(19, 15);
			this.labelProductId.TabIndex = 4;
			this.labelProductId.Text = "Id";
			// 
			// buttonEditCategory
			// 
			this.buttonEditCategory.Location = new System.Drawing.Point(6, 169);
			this.buttonEditCategory.Name = "buttonEditCategory";
			this.buttonEditCategory.Size = new System.Drawing.Size(199, 47);
			this.buttonEditCategory.TabIndex = 7;
			this.buttonEditCategory.Text = "EditCategory";
			this.buttonEditCategory.UseVisualStyleBackColor = true;
			this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
			// 
			// buttonNews
			// 
			this.buttonNews.Location = new System.Drawing.Point(18, 189);
			this.buttonNews.Name = "buttonNews";
			this.buttonNews.Size = new System.Drawing.Size(199, 47);
			this.buttonNews.TabIndex = 13;
			this.buttonNews.Text = "Edit News";
			this.buttonNews.UseVisualStyleBackColor = true;
			this.buttonNews.Click += new System.EventHandler(this.buttonNews_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 588);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonMaintainUsers);
			this.Controls.Add(this.checkBoxPooling);
			this.Controls.Add(this.buttonGetConnection);
			this.Controls.Add(this.buttonGetConnectionString);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetConnectionString;
        private System.Windows.Forms.Button buttonGetConnection;
        private System.Windows.Forms.CheckBox checkBoxPooling;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCategoryId;
        private System.Windows.Forms.TextBox textBoxCategoryId;
        private System.Windows.Forms.Button buttonExcuteScalar;
        private System.Windows.Forms.Button buttonGetProducts;
		private System.Windows.Forms.TextBox textBoxPruductName;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Button buttonCreateNews;
		private System.Windows.Forms.Button buttonEditNews;
		private System.Windows.Forms.TextBox textBoxNewsId;
		private System.Windows.Forms.Label labelNewsId;
		private System.Windows.Forms.Button buttonDeleteNews;
		private System.Windows.Forms.Button buttonMaintainUsers;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBoxProductCategoryId;
		private System.Windows.Forms.Label labelProductId;
		private System.Windows.Forms.Button buttonEditCategory;
		private System.Windows.Forms.Button buttonNews;
	}
}

