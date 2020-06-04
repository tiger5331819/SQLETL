using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class TreeStructureChildren
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
        public string TscnId { get; set; }
        public int TscnValue { get; set; }
        public string TseId { get; set; }
    }
}
