using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repository;
using Api.Domain.Interfaces.Services;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _userRepository;

        public LoginService(IUserRepository repository)
        {
            _userRepository = repository;
        }



        public async Task<UserEntity> Login(UserEntity user)
        {
            var baseUser = new UserEntity();

            if (user != null && !string.IsNullOrEmpty(user.Email))
            {
                baseUser = await _userRepository.FindByLogin(user.Email);
                if (baseUser == null)
                {
                    return null;
                }
                else
                {
                    return baseUser;
                }
            }
            else
            {
                return null;
            }

        }

    }
}