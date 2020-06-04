using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class UserRole
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
        public Guid UreId { get; set; }
        public string UreName { get; set; }
        public string UreDescribe { get; set; }
        public Guid AioId { get; set; }
        public bool UreIsCadre { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsManageApp { get; set; }
        public bool? OpenApplication { get; set; }
    }
}
