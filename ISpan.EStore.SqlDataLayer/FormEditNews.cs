﻿using ISpan.EStore.WinApp;
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
	public partial class FormEditNews : Form
	{
		private readonly int newsId;

		public FormEditNews(int newsId)
		{
			InitializeComponent();
			this.newsId = newsId;
		}
		private void FormEditNews_Load(object sender, EventArgs e)
		{
			News news = new NewsRepository().GetNews(this.newsId);
			if (news == null)
			{
				MessageBox.Show("Record not found.");
				this.DialogResult = DialogResult.Cancel;
				return;
			}

			//bind data
			textBoxTitle.Text = news.Title;
			textBoxDescription.Text = news.Description;
			labelModifiedTime.Text = news.ModifiedTime.ToString("yyyy/MM/dd HH:dd:ss");
		}
		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var news = new News
			{
				Id = this.newsId,
				Title = textBoxTitle.Text,
				Description = textBoxDescription.Text,
				ModifiedTime = DateTime.Now,
			};

			int rowsAffected = new NewsRepository().Update(news);
			//todo 如果回傳比數是1,表示正確更新一筆
			if (rowsAffected > 0)
			{
				MessageBox.Show("紀錄已更新");
			}
			else
			{
				MessageBox.Show("紀錄沒有被異動，可能紀錄已經被刪除");
			}

			FormEditNews_Load(this, EventArgs.Empty);
		}


	}
}
