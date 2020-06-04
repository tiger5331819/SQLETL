using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class Treeregion
    {
        public string Treid { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public string RowVersion { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string TseTitle { get; set; }
        public string TseMark { get; set; }
        public string TseHierarchy { get; set; }
        public string TseDescribe { get; set; }
    }
}
