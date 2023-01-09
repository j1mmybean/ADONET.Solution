using ISpan.EStore.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.BLL.DTOs
{
	public class UserCreateDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public int? Height { get; set; }
		public string Email { get; set; }
	}
	public static class UserCreateDtoExtensions
	{
		public static UserEntity CreateToEntity(this UserCreateDto dto)
		{
			return new UserEntity(dto.Name, dto.Account, dto.Password)
			{
				DateOfBirth = dto.DateOfBirth,
				Height = dto.Height,
				Email = dto.Email,
			};
		}
	}

}
