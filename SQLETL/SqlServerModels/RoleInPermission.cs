using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class RoleInPermission
    {
        public int RipnId { get; set; }
        public Guid UreId { get; set; }
        public string TseId { get; set; }
        public int TseChildVal { get; set; }
    }
}
