using System.Collections.Generic;
using Finan.Domain.Contracts.Business;
using Finan.Domain.Contracts.Repositories;
using Finan.Domain.Entities;

namespace Finan.Services.Services
{
    public class LocalService : ILocalService
    {
        private readonly ILocalRepository _localRepository;

        public LocalService(ILocalRepository localRepository)
        {
            _localRepository = localRepository;
        }

        public IList<Local> Get(int page)
        {
            return _localRepository.Get();
        }

        public Local GetById(int id)
        {
            return _localRepository.GetById(id);
        }

        public Local Create(string description, int userId)
        {
            var local = new Local(description, userId);
            return _localRepository.Create(local);
        }

        public void ChangeDescription(int localId, string description)
        {
            Local local = GetById(localId);
            local.ChangeDescription(description);
            _localRepository.Update(local);
        }

        public void Delete(int localId)
        {
            var local = GetById(localId);
            _localRepository.Delete(local);
        }

        public void Dispose()
        {
            _localRepository.Dispose();
        }
    }
}