using ISpan.EStore.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.EStore.SqlDataLayer
{
	public partial class FormCreateProducts : Form
	{
		public FormCreateProducts()
		{
			InitializeComponent();
		}
		private int? CategoryId
		=> int.TryParse(textBoxCategoryId.Text, out int categoryId)
				? categoryId
				: (int?)null;
		private int? Price
		=> int.TryParse(textBoxPrice.Text, out int price)
				? price
				: (int?)null;

		private ProductDto GetModel()
		=> new ProductDto
		{
			CategoryId = this.CategoryId,
			Name = textBoxName.Text,
			Price = this.Price
		};

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				new ProductRepository().Create(GetModel());
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗\n" + ex.Message);
			}

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
