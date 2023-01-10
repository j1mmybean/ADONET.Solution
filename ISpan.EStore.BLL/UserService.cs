using ISpan.EStore.BLL.Core;
using ISpan.EStore.BLL.DTOs;
using ISpan.EStore.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.EStore.BLL
{
	public class UserService
	{
		private readonly IUserRepository repo;

		public UserService(IUserRepository repo)
		{
			this.repo = repo;
		}

		public int Create(UserCreateDto dto)
		{
			var entity = dto.CreateToEntity();

			// 驗證Account 是否唯一
			var entityInDb = repo.GetByAccount(entity.Account);
			if (entityInDb != null) throw new Exception("帳號已存在");

			//若通過,建檔
			return repo.Create(entity);
		}
		//public int Get(int userId)
		//{
		//	var entity = GetUser(int userId);

		//	// 驗證Account 是否唯一
		//	var entityInDb = repo.GetByAccount(entity.Account);
		//	if (entityInDb != null) throw new Exception("帳號已存在");

		//}

		public int Update(UserUpdateDto dto, UserEntity entity)
		{
			var updateEntity = dto.UpdateToEntity(entity);

			//若通過,建檔
			return repo.Update(updateEntity);
		}
	}
}
