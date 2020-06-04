using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class Smslog
    {
        public int Id { get; set; }
        public string ReceiveNum { get; set; }
        public string Content { get; set; }
        public DateTime SendTime { get; set; }
        public int ResultCode { get; set; }
        public string ResultMsg { get; set; }
        public string SeqNum { get; set; }
        public string SenderId { get; set; }
        public string Sender { get; set; }
        public Guid? AioId { get; set; }
    }
}
