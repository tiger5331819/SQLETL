using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class ApplyPermissionRole
    {
        public Guid Id { get; set; }
        public Guid Pid { get; set; }
        public Guid RoleId { get; set; }
    }
}
