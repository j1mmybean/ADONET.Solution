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

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var news = new News
			{
				Title = textBoxTitle.Text,
				Description = textBoxDescription.Text,
				CreatedTime = DateTime.Now,
				ModifiedTime = DateTime.Now
			};
			int newId = new NewsRepository().Create(news);
			MessageBox.Show($"紀錄已新增, id={newId}");
		}
	}
}
