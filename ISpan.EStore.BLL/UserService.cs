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
			var entity = dto.ToCreateEntity();

			// 驗證Account 是否唯一
			var entityInDb = repo.GetByAccount(entity.Account);
			if (entityInDb != null) throw new Exception("帳號已存在");

			//若通過,建檔
			return repo.Create(entity);
		}

		public int Update(UserUpdateDto dto, UserEntity entity)
		{
			string account = entity.Account;
			string password = entity.Password;

			var updateEntity = dto.ToUpdateEntity(account, password);

			var entityInDb = repo.GetByUserId(entity.Id);

			//若通過,建檔
			return repo.Update(updateEntity);
		}
		public UserEditDto GetUser(int userId)
		{
			var entity = repo.GetByUserId(userId);
			return entity.ToEditDto();
		}

	}
}
