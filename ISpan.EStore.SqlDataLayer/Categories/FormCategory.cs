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

namespace ISpan.EStore.SqlDataLayer.Categories
{
	public partial class FormCategory : Form, IGridContainer
	{
		private CategoryRepository repo;
		private List<Category> _categories;
		public string CName => textBoxName.Text;
		public int? CDisplayOrder 
		=> int.TryParse(textBoxDisplayOrder.Text, out int displayOrder)
				? displayOrder
				: (int?)null;
		public FormCategory()
		{
			InitializeComponent();

			repo =  new CategoryRepository();
			
			this.Load += FormCategory_Load;
		}

		private void FormCategory_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			_categories = repo.Search(CName, CDisplayOrder).ToList();
			dataGridView1.DataSource = _categories;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			FormCreateCategory formCreateCategory = new FormCreateCategory();
			formCreateCategory.Owner = this;
			formCreateCategory.ShowDialog();
		}
		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int categoryId = _categories[e.RowIndex].Id;
			FormEditCategory formEditCategory = new FormEditCategory(categoryId);
			formEditCategory.Owner = this;
			formEditCategory.ShowDialog();
		}
	}
}
