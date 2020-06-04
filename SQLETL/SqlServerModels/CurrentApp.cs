using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class CurrentApp
    {
        public string Id { get; set; }
        public string Sid { get; set; }
        public string AppId { get; set; }
        public DateTime SetTime { get; set; }
    }
}
