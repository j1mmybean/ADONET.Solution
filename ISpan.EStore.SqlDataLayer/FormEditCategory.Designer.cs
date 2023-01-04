namespace ISpan.EStore.SqlDataLayer
{
    partial class FormEditCategory
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDisplayOrder = new System.Windows.Forms.Label();
            this.textBoxDisplayOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(115, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(236, 78);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 25);
            this.textBoxName.TabIndex = 2;
            // 
            // labelDisplayOrder
            // 
            this.labelDisplayOrder.AutoSize = true;
            this.labelDisplayOrder.Location = new System.Drawing.Point(115, 129);
            this.labelDisplayOrder.Name = "labelDisplayOrder";
            this.labelDisplayOrder.Size = new System.Drawing.Size(83, 15);
            this.labelDisplayOrder.TabIndex = 0;
            this.labelDisplayOrder.Text = "DisplayOrder";
            // 
            // textBoxDisplayOrder
            // 
            this.textBoxDisplayOrder.Location = new System.Drawing.Point(236, 126);
            this.textBoxDisplayOrder.Name = "textBoxDisplayOrder";
            this.textBoxDisplayOrder.Size = new System.Drawing.Size(180, 25);
            this.textBoxDisplayOrder.TabIndex = 2;
            // 
            // FormEditCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDisplayOrder);
            this.Controls.Add(this.labelDisplayOrder);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "FormEditCategory";
            this.Text = "FormEditCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDisplayOrder;
        private System.Windows.Forms.TextBox textBoxDisplayOrder;
    }
}