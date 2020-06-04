using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class ArticleManagement
    {
        public Guid AmtId { get; set; }
        public string AmtTitle { get; set; }
        public string AmtContent { get; set; }
        public int AmtSort { get; set; }
        public int AmtClassificationId { get; set; }
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
        public Guid? UnitId { get; set; }
        public string UnitName { get; set; }
        public string NoticeRoleId { get; set; }
        public bool? IsNoticed { get; set; }
        public string FileList { get; set; }
    }
}
