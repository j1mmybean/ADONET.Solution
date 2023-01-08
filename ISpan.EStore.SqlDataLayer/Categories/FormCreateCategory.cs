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
	public partial class FormCreateCategory : Form
	{
		public FormCreateCategory()
		{
			InitializeComponent();
		}
		private int? DisplayOrder
		=> int.TryParse(textBoxDisplayOrder.Text, out int displayOrder)
				? displayOrder
				: (int?)null;

		private Category GetModel()
		=> new Category
		{
			Name = textBoxName.Text,
			DisplayOrder = this.DisplayOrder,
		};

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				new CategoryRepository().Create(GetModel());
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
