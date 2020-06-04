using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class ApplicationInfo
    {
        public string CreateId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ModifyId { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public bool IsEnable { get; set; }
        public bool IsDelete { get; set; }
        public byte[] RowVersion { get; set; }
        public Guid AioId { get; set; }
        public string AioMark { get; set; }
        public string AioName { get; set; }
        public string AioDescribe { get; set; }
        public bool AioIsUserCount { get; set; }
        public string AioClass { get; set; }
        public string AioIcon { get; set; }
        public string AioLink { get; set; }
        public string AioOtherId { get; set; }
        public string AioOtherMark { get; set; }
        public string AioUseLink { get; set; }
        public string Subscript { get; set; }
        public bool AioIsIdentity { get; set; }
        public string AioMsgUrl { get; set; }
        public bool AioAllShow { get; set; }
        public string AioSubscriptId { get; set; }
        public bool IsRecommend { get; set; }
        public string AppSource { get; set; }
    }
}
