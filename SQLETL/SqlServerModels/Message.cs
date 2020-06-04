using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class Message
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ReceiveType { get; set; }
        public string ReceiveDesc { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public Guid AioId { get; set; }
        public int SendType { get; set; }
        public string SendResult { get; set; }
    }
}
