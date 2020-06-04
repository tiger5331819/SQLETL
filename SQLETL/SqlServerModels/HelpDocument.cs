using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class HelpDocument
    {
        public Guid HdtId { get; set; }
        public string HdtSpreadhead { get; set; }
        public string HdtSubhead { get; set; }
        public string HdtTitle { get; set; }
        public string HdtContent { get; set; }
        public int Sort { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid AioId { get; set; }
        public string FileList { get; set; }
        public string Unitid { get; set; }
        public string UnitName { get; set; }
    }
}
