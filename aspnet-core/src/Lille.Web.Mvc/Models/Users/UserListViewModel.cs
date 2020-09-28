using System.Collections.Generic;
using Lille.Roles.Dto;

namespace Lille.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
