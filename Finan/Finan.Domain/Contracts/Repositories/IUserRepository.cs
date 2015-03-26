using System;
using Finan.Domain.Entities;

namespace Finan.Domain.Contracts.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>, IDisposable
    {
    }
}