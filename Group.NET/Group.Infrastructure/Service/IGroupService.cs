using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Group.Core.Domain;

namespace Group.Infrastructure.Service
{
    public interface IGroupService
    {
        Task AddAsync(Core.Domain.Group group);
        Task UpdateAsync(Core.Domain.Group group);
        Task DeleteAsync(Core.Domain.Group group);
        Task<Core.Domain.Group> GetByIdAsync(Guid id);
        Task<List<User>> GeMembersAsync(Guid id);
        Task AddMember(Core.Domain.Group group, User user);
        Task RemoveMember(Core.Domain.Group group, User user);
    }
}