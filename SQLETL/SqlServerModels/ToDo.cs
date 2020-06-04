using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class ToDo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UrId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int IsRead { get; set; }
        public int State { get; set; }
        public string Url { get; set; }
        public Guid AioId { get; set; }
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
    }
}
