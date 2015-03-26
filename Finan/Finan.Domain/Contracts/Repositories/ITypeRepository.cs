using System;
using Finan.Domain.Entities;

namespace Finan.Domain.Contracts.Repositories
{
    public interface ITypeRepository : IRepositoryBase<EnterType>, IDisposable
    {
    }
}