using ISpan.EStore.BLL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.BLL.DTOs
{
	public class UserEditDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public int? Height { get; set; }
		public string Email { get; set; }
	}
	public static class UserEditDtoExtensions
	{
		public static UserEditDto ToEditDto(this UserEntity entity)
		{
			return new UserEditDto()
			{
				Id = entity.Id,
				Name = entity.Name,
				DateOfBirth = entity.DateOfBirth,
				Height = entity.Height,
				Email = entity.Email,
			};
		}
	}

}
