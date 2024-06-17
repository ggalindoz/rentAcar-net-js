using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;
        public UserService(IRepository<UserEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.deleteAsync(id);
        }

        public async Task<UserEntity> Get(Guid id)
        {
            return await _repository.selectAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _repository.selectAsync();
        }

        public async Task<UserEntity> Post(UserEntity user)
        {
            return await _repository.insertAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repository.updateAsync(user);
        }
    }
}