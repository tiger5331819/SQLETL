﻿using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class EfmigrationsHistory
    {
        public string MigrationId { get; set; }
        public string ProductVersion { get; set; }
    }
}
