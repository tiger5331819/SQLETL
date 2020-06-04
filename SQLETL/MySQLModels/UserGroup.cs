using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class UserGroup
    {
        public string UgpId { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public string RowVersion { get; set; }
        public string UgpName { get; set; }
        public string UgpDescribe { get; set; }
        public string AppId { get; set; }
        public string CreateBy { get; set; }
        public string CreateId { get; set; }
        public DateTime CreateTime { get; set; }
        public string ModifyBy { get; set; }
        public string ModifyId { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
