using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class ApplyPermission
    {
        public Guid Id { get; set; }
        public int State { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string ApplyRemark { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string ApprovalRemark { get; set; }
        public Guid AioId { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid CreateUnitId { get; set; }
        public string CreateUnit { get; set; }
    }
}
