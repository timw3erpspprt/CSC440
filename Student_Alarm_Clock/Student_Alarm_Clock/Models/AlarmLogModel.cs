using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Alarm_Clock.Models
{
    public class AlarmLogModel
    {
        public int IndexId { get; set; }
        public int AlarmId { get; set; }
        public string YellowStatus { get; set; }
        public string RedStatus { get; set; }
        public bool AlarmUsed { get; set; }
        public string DateTime { get; set; }
    }
}