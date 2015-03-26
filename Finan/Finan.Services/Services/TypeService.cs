using System.Collections.Generic;
using Finan.Domain.Contracts.Business;
using Finan.Domain.Contracts.Repositories;
using Finan.Domain.Entities;

namespace Finan.Services.Services
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository _typeRepository;

        public TypeService(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }

        public IList<EnterType> Get(int page)
        {
            return _typeRepository.Get();
        }

        public EnterType GetById(int id)
        {
            return _typeRepository.GetById(id);
        }

        public EnterType Create(string description, int userId)
        {
            var type = new EnterType(description, userId);
            return _typeRepository.Create(type);
        }

        public void ChangeDescription(int typeId, string description)
        {
            var type = GetById(typeId);
            type.ChangeDescription(description);
            _typeRepository.Update(type);
        }

        public void Delete(int typeId)
        {
            var type = GetById(typeId);
            _typeRepository.Delete(type);
        }

        public void Dispose()
        {
            _typeRepository.Dispose();
        }
    }
}