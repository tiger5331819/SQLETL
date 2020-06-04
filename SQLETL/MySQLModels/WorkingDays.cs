using System;
using System.Collections.Generic;

namespace SQLETL.MySQLModels
{
    public partial class WorkingDays
    {
        public DateTime Date { get; set; }
        public int DateType { get; set; }
        public string LunarCalendar { get; set; }
        public int DayOfWeek { get; set; }
        public string SolarTermAndFestival { get; set; }
    }
}
