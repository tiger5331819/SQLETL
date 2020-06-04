using System;
using System.Collections.Generic;

namespace SQLETL.SqlServerModels
{
    public partial class OssfileInfo
    {
        public string Fileid { get; set; }
        public decimal? Filesize { get; set; }
        public string Filepath { get; set; }
        public string Fileext { get; set; }
        public string Filename { get; set; }
        public DateTime? Createtime { get; set; }
        public string Createid { get; set; }
        public string Createname { get; set; }
    }
}
