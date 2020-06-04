using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class TodoGather
    {
        public string Id { get; set; }
        public string AppId { get; set; }
        public string IdentityKey { get; set; }
        public int ToDoCount { get; set; }
        public string ToDoUrl { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
