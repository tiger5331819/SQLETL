using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class UserRole
    {
        public string UreId { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public string RowVersion { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string UreName { get; set; }
        public string UreDescribe { get; set; }
        public string AppId { get; set; }
        public bool OpenApplication { get; set; }
    }
}
