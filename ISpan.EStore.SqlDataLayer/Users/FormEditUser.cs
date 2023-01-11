using ISpan.EStore.BLL.Interfaces;
using ISpan.EStore.BLL;
using ISpan.EStore.SqlDataLayer.Models.ViewModels;
using ISpan.EStore.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISpan.EStore.BLL.Core;
using ISpan.EStore.BLL.DTOs;

namespace ISpan.EStore.SqlDataLayer
{
	public partial class FormEditUser : Form
	{
		private readonly int userId;
		private UserService service;

		public FormEditUser(int userId)
		{
			InitializeComponent();

			IUserRepository repo = new UserRepository();
			service = new UserService(repo);

			this.userId = userId;
			this.Load += FormEditUser_Load;
		}

		private void FormEditUser_Load(object sender, EventArgs e)
		{
			UserEditDto user = service.GetUser(userId);

			BindForm(user);
		}

		private void BindForm(UserEditDto dto)
		{
			textBoxName.Text = dto.Name;
			textBoxEmail.Text = dto.Email;
			textBoxDateOfBirth.Text = dto.DateOfBirth.HasValue
				?dto.DateOfBirth.Value.ToString("yyyy/MM/dd")
				:string.Empty;
			textBoxHeight.Text = dto.Height.HasValue
				?dto.Height.Value.ToString()
				:String.Empty;
		}
		private DateTime? DateOfBirth
					=> DateTime.TryParse(textBoxDateOfBirth.Text, out DateTime dt)
					? dt
					: (DateTime?)null;
		private int? UserHeight
					=> int.TryParse(textBoxHeight.Text, out int height)
					? height
					: (int?)null;

		private UserUpdateVm GetModel()
		=> new UserUpdateVm
		{
			Id = userId,
			Name = textBoxName.Text,
			Email = textBoxEmail.Text,
			DateOfBirth = this.DateOfBirth,
			Height = this.UserHeight,
		};
		private (bool isValid, List<ValidationResult> errors) Validate(UserUpdateVm vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}

		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", textBoxName},
				{"Email", textBoxEmail},
				{"DateOfBirth", textBoxDateOfBirth},
				{"Height", textBoxHeight}
			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			//new UserRepository().Update(GetModel());
			// 繫結表單控制項到 UserUpdateVm
			var vm = GetModel();

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			// 如果通過驗證,轉型為UserUpdateDto
			var dto = vm.ToUpdateDto();

			// 傳給 UserService
			IUserRepository repo = new UserRepository();
			UserService service = new UserService(repo);

			try
			{
				var entity = new UserRepository().GetByUserId(userId);

				service.Update(dto, entity);
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗\r\n" + ex.Message);
			}

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			new UserRepository().Delete(GetModel().Id);

			IGridContainer container = this.Owner as IGridContainer;
			if (container != null) container.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
