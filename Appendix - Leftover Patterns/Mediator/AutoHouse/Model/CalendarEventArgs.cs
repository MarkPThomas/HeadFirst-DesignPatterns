using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHouse.Model
{
    public class CalendarEventArgs : EventArgs
    {
        public bool IsWeekend { get; set; }
        public bool IsTrashDay { get; set; }
        public DayOfWeek Day { get; set; }

        public List<CalendarEventTypes> DayEvents { get; set; }
    }
}
