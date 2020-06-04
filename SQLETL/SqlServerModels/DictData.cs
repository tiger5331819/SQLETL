using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class DictData
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
        public string DdaMark { get; set; }
        public string DdaTitle { get; set; }
        public string DdaLink { get; set; }
        public string DdaDescribe { get; set; }
        public int DdaSort { get; set; }
        public string DcsId { get; set; }
        public string DdaImg { get; set; }
        public int? Ddalft { get; set; }
        public int? Ddargt { get; set; }
        public int DdaType { get; set; }
        public string DdaId { get; set; }
    }
}
