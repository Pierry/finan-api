using System;
using System.Collections.Generic;
using Finan.Domain.Entities;

namespace Finan.Domain.Contracts.Business
{
    public interface ITypeService : IDisposable
    {
        IList<EnterType> Get(int page);
        EnterType GetById(int id);
        EnterType Create(string description, int userId);
        void ChangeDescription(int type, string description);
        void Delete(int typeId);
    }
}