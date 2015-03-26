using System;
using Finan.Domain.Entities;

namespace Finan.Domain.Contracts.Repositories
{
    public interface IItemRepository : IRepositoryBase<Item>, IDisposable
    {
    }
}