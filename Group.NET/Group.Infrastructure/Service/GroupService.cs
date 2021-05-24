using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Group.Core.Domain;

namespace Group.Infrastructure.Service
{
    public class GroupService : IGroupService
    {
        public Task AddAsync(Core.Domain.Group @group)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Core.Domain.Group @group)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Core.Domain.Group @group)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Domain.Group> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GeMembersAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}