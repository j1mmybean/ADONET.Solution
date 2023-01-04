using ISpan.EStore.WinApp;
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

namespace ISpan.EStore.SqlDataLayer
{
    public partial class FormEditCategory : System.Windows.Forms.Form
    {
        private readonly int categoryId;

        public FormEditCategory(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;

            this.Load += FormEditCategory_Load;
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            using (var conn = SqlDb.GetConnection())
            {
                string sql = $"Select * from Categories where Id = {categoryId}";
                using (var command = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textBoxName.Text = reader["Name"].ToString();
                        textBoxDisplayOrder.Text = reader["DisplayOrder"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("record not found.");
                        this.DialogResult = DialogResult.Cancel;
                        return;
                    }
                }
            }
        }
    }
}
