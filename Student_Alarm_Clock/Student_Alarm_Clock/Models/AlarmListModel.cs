using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Alarm_Clock.Models
{
    public class AlarmListModel
    {
        public string AlarmID { get; set; }
        public string UserID { get; set; }
        public int WakeHour { get; set; } public int WakeMinute { get; set; }
        public int YellowHour { get; set; } public int YellowMinute { get; set; }
        public int RedHour { get; set; } public int RedMinute { get; set; }
    }
}