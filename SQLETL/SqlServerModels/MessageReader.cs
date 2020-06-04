using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class MessageReader
    {
        public int Id { get; set; }
        public Guid MessageId { get; set; }
        public string UserId { get; set; }
        public DateTime ReadTime { get; set; }
    }
}
