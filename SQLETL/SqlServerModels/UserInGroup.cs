using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class UserInGroup
    {
        public int UigpId { get; set; }
        public Guid UgpId { get; set; }
        public string UrId { get; set; }
        public string UnitId { get; set; }
    }
}
