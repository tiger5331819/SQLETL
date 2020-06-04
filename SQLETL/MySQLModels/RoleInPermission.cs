using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class RoleInPermission
    {
        public int RipnId { get; set; }
        public string UreId { get; set; }
        public string MenuId { get; set; }
        public string DictId { get; set; }
    }
}
