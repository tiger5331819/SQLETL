using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class Test
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public bool? Sex { get; set; }
        public DateTime? Createtime { get; set; }
    }
}
