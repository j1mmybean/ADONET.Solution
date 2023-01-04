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
	public partial class FormProducts : Form
	{
		private readonly int? categoryId;
		private readonly string prodName;

		public FormProducts(int? categoryId, string prodName)
		{
			InitializeComponent();
			this.categoryId = categoryId;
			this.prodName = prodName;
		}

		private void FormProducts_Load(object sender, EventArgs e)
		{
			var products = new ProductRepository().Search(categoryId, prodName).ToList();
			this.dataGridView1.DataSource = products;
		}
	}
}
