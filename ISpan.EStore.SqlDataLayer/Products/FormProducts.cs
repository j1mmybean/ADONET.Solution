using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan.EStore.WinApp;


namespace ISpan.EStore.SqlDataLayer
{
	public partial class FormProducts : Form, IGridContainer
	{
		private ProductRepository repo;
		private List<ProductDto> _products;

		private readonly int? categoryId;
		private readonly string prodName;
		public string PName => textBoxProductName.Text;
		public int? PCategoryId
		=> int.TryParse(textBoxCategoryId.Text, out int categoryId)
				? categoryId
				: (int?)null;

		public FormProducts(int? categoryId, string prodName)
		{
			InitializeComponent();

			repo = new ProductRepository();

			this.categoryId = categoryId;
			this.prodName = prodName;
		}

		private void FormProducts_Load(object sender, EventArgs e)
		{
			var products = new ProductRepository().Search(categoryId, prodName).ToList();
			this.dataGridView1.DataSource = products;
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			FormCreateProducts formCreateProducts = new FormCreateProducts();
			formCreateProducts.Owner = this;
			formCreateProducts.ShowDialog();
		}

		public void Display()
		{
			_products = repo.Search(PCategoryId, PName).ToList();
			this.dataGridView1.DataSource = _products;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			_products = repo.Search(PCategoryId, PName).ToList();
			int productId = _products[e.RowIndex].Id;
			FormEditProducts formEditProducts = new FormEditProducts(productId);
			formEditProducts.Owner = this;
			formEditProducts.ShowDialog();
		}
	}
}
