using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class MessageReceiver
    {
        public Guid Id { get; set; }
        public Guid Pid { get; set; }
        public Guid ReceiveTypeId { get; set; }
    }
}
