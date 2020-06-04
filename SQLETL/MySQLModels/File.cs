using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class File
    {
        public string Id { get; set; }
        public string Md5 { get; set; }
        public string AppId { get; set; }
        public DateTime CreateTime { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public decimal Size { get; set; }
        public string Type { get; set; }
        public string Custom { get; set; }
    }
}
