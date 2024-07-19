using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.UserTdo
{
    public interface IUserTdoService
    {
        Task<IEnumerable<UserTdoEntity>> GetAll();
    }
}