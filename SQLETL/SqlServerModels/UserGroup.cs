using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class UserGroup
    {
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid UgpId { get; set; }
        public string UgpName { get; set; }
        public string UgpDescribe { get; set; }
        public string UnitId { get; set; }
        public int? IdetityId { get; set; }
        public Guid AioId { get; set; }
    }
}
