using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class Dict
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
        public string AppId { get; set; }
        public string Mark { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public string Hierarchy { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }
    }
}
