using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class UserGroupInRole
    {
        public int UgireId { get; set; }
        public Guid UgpId { get; set; }
        public Guid UreId { get; set; }
    }
}
