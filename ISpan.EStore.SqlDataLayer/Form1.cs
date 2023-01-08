using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan.EStore.SqlDataLayer;
using ISpan.EStore.SqlDataLayer.Categories;
using ISpan.EStore.SqlDataLayer.News;
using ISpan.EStore.WinApp;

namespace ISpan.EStore.SqlDataLayer
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetConnectionString_Click(object sender, EventArgs e)
        {
            SqlDb.ApplicationName = "mytest";
            SqlDb.ConnectionTimeout = 99;
            SqlDb.Pooling = true;

            string connStr = SqlDb.GetConnectionString("default");

            MessageBox.Show(connStr);
        }

        //private void buttonGetConnection_Click(object sender, EventArgs e)
        //{
        //    SqlDb.ApplicationName = "conn test";
        //    SqlDb.Pooling = this.checkBoxPooling.Checked;
        //    SqlConnection conn = SqlDb.GetConnection("default");
        //    conn.Open();

        //    var command = new SqlCommand("Select*from Categories", conn);
        //    var reader = command.ExecuteReader();
        //    reader.Close();

        //    conn.Close();
        //    conn.Dispose();
        //}
        private void buttonGetConnection_Click(object sender, EventArgs e)
        {
            SqlDb.ApplicationName = "conn test";
            SqlDb.Pooling = this.checkBoxPooling.Checked;

            using (SqlConnection conn = SqlDb.GetConnection("default"))
            {
                using (var command = new SqlCommand("Select*from Categories", conn))
                {
                conn.Open();
                var reader = command.ExecuteReader();
                reader.Close();
                }            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxCategoryId.Text, out int categoryId);
            if (isInt == false)
            {
                MessageBox.Show("請輸入正確 CategoryId");
                return;
            }
            var frm = new FormEditCategory(categoryId);
            frm.ShowDialog();
        }

        private void buttonExcuteScalar_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxCategoryId.Text, out int categoryId);
            if (isInt == false)
            {
                MessageBox.Show("請輸入正確 CategoryId");
                return;
            }
            int countOfProductByCategory = new CategoryRepository().GetProductCount(categoryId);
            MessageBox.Show(countOfProductByCategory.ToString());
            
        }

        private void buttonGetProducts_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxProductCategoryId.Text, out int value);
            int? categoryId = isInt?value:(int?)null;
            string prodName = textBoxPruductName.Text; 
            var frm = new FormProducts(categoryId, prodName);
            frm.ShowDialog();
        }

        private void buttonCreateNews_Click(object sender, EventArgs e)
        {
            FormCreateNews formCreateNews = new FormCreateNews();
            formCreateNews.ShowDialog();
        }

        private void buttonEditNews_Click(object sender, EventArgs e)
        {
			bool isInt = int.TryParse(textBoxNewsId.Text, out int NewsId);
            if(isInt == false)
            {
                MessageBox.Show("請輸入正確Id");
                return ;
            }
			var frm = new FormEditNews(NewsId);
			frm.ShowDialog();

		}

        private void buttonDeleteNews_Click(object sender, EventArgs e)
        {
			bool isInt = int.TryParse(textBoxNewsId.Text, out int newsId);
			if (isInt == false)
			{
				MessageBox.Show("請輸入正確Id");
				return;
			}
			int rowsAffected = new NewsRepository().Delete(newsId);
			//todo 如果回傳比數是1,表示正確更新一筆
			if (rowsAffected > 0)
			{
				MessageBox.Show("紀錄已刪除");
			}
			else
			{
				MessageBox.Show("沒有紀錄被刪除，可能紀錄不存在");
			}
		}

        private void buttonMaintainUsers_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.ShowDialog();
        }

		private void buttonEditCategory_Click(object sender, EventArgs e)
		{
			FormCategory formCategory = new FormCategory();
			formCategory.ShowDialog();
		}

		private void buttonNews_Click(object sender, EventArgs e)
		{
			FormNews formNews = new FormNews();
			formNews.ShowDialog();
		}
	}
}
