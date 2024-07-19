using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {

        Task<UserEntity> Get(Guid id);
        
        //Esse getAll está sendo feito pelo Api.Domain.Interfaces.Services.IUserTdoService, para gerar um TDO onde só volta o nome do usuário.
        //Task<IEnumerable<UserEntity>> GetAll();

        Task<UserEntity> Post(UserEntity user);
        Task<UserEntity> Put(UserEntity user);

        Task<bool> Delete(Guid id);

    }
}