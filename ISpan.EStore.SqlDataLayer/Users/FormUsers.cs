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
	public partial class FormUsers : Form, IGridContainer
	{
		private UserRepository repo;
		private List<UserEntity> _users;
		public string SName => textBoxName.Text;
		public string SAccount => textBoxAccount.Text;
		public string SEmail => textBoxEmail.Text;

		public FormUsers()
		{
			InitializeComponent();

			repo = new UserRepository();
			
			this.Load += FormUsers_Load;
		}

		private void FormUsers_Load(object sender, EventArgs e)
		{
			Display();
		}
		/// <summary>
		/// 顯示紀錄
		/// </summary>
		public void Display()
		{
			_users = repo.Search(SName, SAccount, SEmail).ToList();
			dataGridView1.DataSource = _users;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			Display();
		}

		private void buttonAddNew_Click(object sender, EventArgs e)
		{
			FormCreateUser formCreateUser =	new FormCreateUser();
			formCreateUser.Owner = this;
			formCreateUser.ShowDialog();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex < 0)	return;

			int userId = _users[e.RowIndex].Id;
			FormEditUser formEditUser = new FormEditUser(userId);
			formEditUser.Owner = this;
			formEditUser.ShowDialog();
		}
	}
}
