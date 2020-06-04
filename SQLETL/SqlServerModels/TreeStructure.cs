using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class TreeStructure
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
        public string TseHierarchy { get; set; }
        public string TseMark { get; set; }
        public string TseTitle { get; set; }
        public string TseDescribe { get; set; }
        public string TseIcon { get; set; }
        public string TseLink { get; set; }
        public int TseSort { get; set; }
        public string TseCods { get; set; }
        public string TseOrgType { get; set; }
        public string TseOrgCode { get; set; }
        public string TseAddress { get; set; }
        public string TsePostalCode { get; set; }
        public string TseFax { get; set; }
        public string TseEmail { get; set; }
        public string TseOrgFunction { get; set; }
        public string TseRemark { get; set; }
        public bool IsDept { get; set; }
        public bool? IsShow { get; set; }
        public bool IsPublic { get; set; }
        public string TseId { get; set; }
        public string TseClassId { get; set; }
    }
}
