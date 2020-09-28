using System.Collections.Generic;
using Lille.Roles.Dto;

namespace Lille.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}