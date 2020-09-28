using System.Collections.Generic;
using Lille.Roles.Dto;

namespace Lille.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
