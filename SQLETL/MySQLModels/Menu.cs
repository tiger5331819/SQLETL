using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class Menu
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
        public string Name { get; set; }
        public string Mark { get; set; }
        public string Describe { get; set; }
        public string Hierarchy { get; set; }
        public int Sort { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
    }
}
