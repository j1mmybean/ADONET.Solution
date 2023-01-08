using ISpan.EStore.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.SqlDataLayer
{
    public partial class FormEditCategory : Form
    {
        private readonly int categoryId;
        public FormEditCategory(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
            this.Load += FormEditCategory_Load;
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            Category category = new CategoryRepository().GetCategory(categoryId);
			BindForm(category);

			#region Used to be

			//if (category == null)
			//{
			//    MessageBox.Show("record not found.");
			//    this.DialogResult = DialogResult.Cancel;
			//    return;
			//}
			//else
			//{
			//    textBoxName.Text = category.Name;
			//    textBoxDisplayOrder.Text = category.DisplayOrder.ToString();
			//}

			//using (var conn = SqlDb.GetConnection())
			//{
			//    string sql = $"Select * from Categories where Id = {categoryId}";
			//    using (var command = new SqlCommand(sql, conn))
			//    {
			//        conn.Open();

			//        var reader = command.ExecuteReader();

			//        if (reader.Read())
			//        {
			//            textBoxName.Text = reader["Name"].ToString();
			//            textBoxDisplayOrder.Text = reader["DisplayOrder"].ToString();
			//        }
			//        else
			//        {
			//            MessageBox.Show("record not found.");
			//            this.DialogResult = DialogResult.Cancel;
			//            return;
			//        }
			//    }
			//}
			#endregion
		}
		private void BindForm(Category category)
		{
			textBoxName.Text = category.Name;
			textBoxDisplayOrder.Text = category.DisplayOrder.HasValue
				? category.DisplayOrder.Value.ToString()
				: String.Empty;
		}
		private int? DisplayOrder
					=> int.TryParse(textBoxDisplayOrder.Text, out int displayOrder)
					? displayOrder
					: (int?)null;

		private Category GetModel()
		=> new Category
		{
			Id = categoryId,
			Name = textBoxName.Text,
			DisplayOrder = this.DisplayOrder
		};

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			new CategoryRepository().Update(GetModel());

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			new CategoryRepository().Delete(GetModel().Id);

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

	}
}
