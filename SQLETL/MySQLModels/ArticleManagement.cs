using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class ArticleManagement
    {
        public string AmtId { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public string RowVersion { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string AmtTitle { get; set; }
        public string AmtContent { get; set; }
        public string AmtClassifiyId { get; set; }
        public int AmtSort { get; set; }
        public string AppId { get; set; }
    }
}
