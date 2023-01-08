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
	public partial class FormCreateNews : Form
	{
		public FormCreateNews()
		{
			InitializeComponent();
		}
		private NewsInfo GetModel()
		=> new NewsInfo
		{
			Title = textBoxTitle.Text,
			Description = textBoxDescription.Text,
			CreatedTime = DateTime.Now,
			ModifiedTime = DateTime.Now
		};

		private void buttonSave_Click(object sender, EventArgs e)
		{
			try
			{
				new NewsRepository().Create(GetModel());
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗\n" + ex.Message);
			}

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		//private void buttonSave_Click(object sender, EventArgs e)
		//{
		//	var news = new ISpan.EStore.WinApp.NewsInfo
		//	{
		//		Title = textBoxTitle.Text,
		//		Description = textBoxDescription.Text,
		//		CreatedTime = DateTime.Now,
		//		ModifiedTime = DateTime.Now
		//	};
		//	int newId = new NewsRepository().Create(news);
		//	MessageBox.Show($"紀錄已新增, Id={newId}");
		//}
	}
}
