using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiftDiary.DTO
{
    public class Calendar
    {
        public virtual int Id { get; set; }
        public virtual DateTime CalendarDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var t = obj as Calendar;
            if (t == null)
            {
                return false;
            }

            if (Id == t.Id)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (CalendarDate.ToLongDateString() + "|" + Id).GetHashCode();
        }
    }
}
