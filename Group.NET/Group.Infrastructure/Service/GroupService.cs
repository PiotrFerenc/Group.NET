using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Group.Core.Domain;
using Group.Core.Repository;

namespace Group.Infrastructure.Service
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;

        public GroupService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        /// <summary>
        /// nazwa wymagana 5-50 znaków
        /// admin wymagany
        /// -
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
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

        public Task AddMember(Core.Domain.Group @group, User user)
        {
            throw new NotImplementedException();
        }

        public Task RemoveMember(Core.Domain.Group @group, User user)
        {
            throw new NotImplementedException();
        }
    }
}