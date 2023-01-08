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
	public partial class FormEditProducts : Form
	{
		private readonly int productId;

		public FormEditProducts(int productId)
		{
			InitializeComponent();
			this.productId = productId;
			this.Load += FormEditProducts_Load;
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
			Id = productId,
			CategoryId = this.CategoryId,
			Name = textBoxName.Text,
			Price = this.Price
		};

		private void FormEditProducts_Load(object sender, EventArgs e)
		{
			ProductDto product = new ProductRepository().GetProduct(productId);
			BindForm(product);
		}

		private void BindForm(ProductDto product)
		{
			textBoxCategoryId.Text = product.CategoryId.HasValue
				? product.CategoryId.Value.ToString()
				: String.Empty;
			textBoxName.Text = product.Name;
			textBoxPrice.Text = product.Price.HasValue
				? product.Price.Value.ToString()
	:			String.Empty;
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			new ProductRepository().Delete(GetModel().Id);

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			new ProductRepository().Update(GetModel());

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
