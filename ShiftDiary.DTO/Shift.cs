using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiftDiary.DTO
{
    public class Shift
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ShiftDate { get; set; }
        public virtual long ShiftStart { get; set; }
        public virtual long ShiftEnd { get; set; }
        public virtual int ShiftBreakMins { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var t = obj as Shift;
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
            return (Name + "|" + Id).GetHashCode();
        }
    }
}
