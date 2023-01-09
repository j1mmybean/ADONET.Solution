using ISpan.EStore.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISpan.EStore.SqlDataLayer.Models.ViewModels
{
	public class UserUpdateVm
	{
		public int Id { get; set; }

		[Display(Name = "姓名")]
		[Required(ErrorMessage = "{0} 必填")]
		[StringLength(50, ErrorMessage = "長度不可超過{1}")]
		public string Name { get; set; }

		[DataType(DataType.Date, ErrorMessage = "生日必需是合法日期,例如1900/1/1")]
		public DateTime? DateOfBirth { get; set; }

		[Range(1, 250, ErrorMessage = "身高必需大於零")]
		public int? Height { get; set; }

		[EmailAddress(ErrorMessage = "Email格式有誤")]
		public string Email { get; set; }

	}
	public static class UserUpdateVmExtensions
	{
		public static UserUpdateDto ToUpdateDto(this UserUpdateVm source)
		{
			return new UserUpdateDto
			{
				Id = source.Id,
				Name = source.Name,
				Email = source.Email,
				DateOfBirth = source.DateOfBirth,
				Height = source.Height
			};
		}
	}

}
