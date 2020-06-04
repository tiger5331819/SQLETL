using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class AppInfo
    {
        public string Id { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public string RowVersion { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string AppName { get; set; }
        public string Describe { get; set; }
        public string ClientId { get; set; }
        public string Link { get; set; }
        public string Iocn { get; set; }
        public string AppSource { get; set; }
        public bool IsAllShow { get; set; }
        public bool IsRecommend { get; set; }
    }
}
