using System;
using System.Collections.Generic;

namespace Group.Core.Domain
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }
        public User Admin { get; set; }
    }
}