using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class MessageTemplate
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid AioId { get; set; }
        public string Title { get; set; }
    }
}
