using System;
using System.Collections.Generic;
using Finan.Domain.Entities;

namespace Finan.Domain.Contracts.Business
{
    public interface ILocalService : IDisposable
    {
        IList<Local> Get(int page);
        Local GetById(int id);
        Local Create(string description, int userId);
        void ChangeDescription(int localId, string description);
        void Delete(int localId);
    }
}