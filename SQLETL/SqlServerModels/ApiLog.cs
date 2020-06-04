using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class ApiLog
    {
        public int AlgId { get; set; }
        public string ClientIp { get; set; }
        public long ResponseTime { get; set; }
        public string AccessToken { get; set; }
        public DateTime AccessTime { get; set; }
        public string AccessApiUrl { get; set; }
        public string AccessAction { get; set; }
        public string QueryString { get; set; }
        public string Body { get; set; }
        public int HttpStatus { get; set; }
    }
}
