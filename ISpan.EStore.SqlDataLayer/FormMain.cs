using ISpan.EStore.SqlDataLayer.News;
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
	public partial class FormMain : Form
	{
		private readonly bool isMdi = false;
		public FormMain()
		{
			InitializeComponent();

			if (isMdi) this.IsMdiContainer = true;
		}

		private void maintainNewsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormNews();
			if (isMdi) frm.MdiParent = this;
			frm.Show();
		}

		private static FormProducts _frmProducts;
		private void maintainProductsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_frmProducts == null || IsClosed("FormProducts"))
			{
				_frmProducts = new FormProducts(null, null);
				if (isMdi) _frmProducts.MdiParent = this;
			}
			
			var frm = _frmProducts;
			frm.Show();
		}
		/// <summary>
		/// 判斷已開啟的表單裡，有沒有指定名稱的表單
		/// </summary>
		/// <param name="formName"></param>
		/// <returns></returns>
		private bool IsClosed(string formName)
		{
			return !Application.OpenForms.Cast<Form>().Any(f => f.Name == formName);
			//foreach (var item in Application.OpenForms)
			//{
			//	var frm = item as Form;
			//	if(frm != null&&frm.Name == formName) return false;
			//}

			//return true;
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
