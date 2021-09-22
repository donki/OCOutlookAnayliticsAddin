using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCAnalytics
{
    public class SummaryMonth
    {
        public string MonthName;
        public int TotalWorkHours;
        public decimal TotalHoursPlanned;
        public decimal TotalRemainHours;
        public decimal TotalRemainHoursToday = 0;
        public decimal TotalWorkHoursToday = 0;
        public decimal TotalHoursPlannedToday = 0;        
        public int TotalTasks;
        public int TotalProgress;
        public int PerceProgress;
        public int PercePlanned;
        public DateTime BeginOfMonth;
        public DateTime EndOfMonth;
        public Boolean isMonthPeriod = false;
        public decimal TotalNonPlannedHours = 0;
        public int PerceNonPlannedHours = 0;
    }
}
