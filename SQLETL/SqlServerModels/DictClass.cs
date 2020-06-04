using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class DictClass
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
        public string DcsMark { get; set; }
        public string DcsTitle { get; set; }
        public string DcsDescribe { get; set; }
        public int DcsSort { get; set; }
        public Guid AioId { get; set; }
        public bool IsRoot { get; set; }
        public string DcsId { get; set; }
    }
}
