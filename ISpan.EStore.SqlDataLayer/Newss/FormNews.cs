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

namespace ISpan.EStore.SqlDataLayer.News
{
	public partial class FormNews : Form, IGridContainer
	{
		private NewsRepository repo;
		private List<NewsInfo> _news;
		public string NTitle => textBoxTitle.Text;
		public string NDescription => textBoxDescription.Text;
		public FormNews()
		{
			InitializeComponent();

			repo = new NewsRepository();

			this.Load += FormNews_Load;
		}

		private void FormNews_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			_news = repo.Search(NTitle, NDescription).ToList();
			dataGridView1.DataSource = _news;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			FormCreateNews formCreateNews = new FormCreateNews();
			formCreateNews.Owner = this;
			formCreateNews.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int newsId = _news[e.RowIndex].Id;
			FormEditNews formEditNews = new FormEditNews(newsId);
			formEditNews.Owner = this;
			formEditNews.ShowDialog();
		}
	}
}
