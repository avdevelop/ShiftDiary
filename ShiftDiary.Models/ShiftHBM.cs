using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShiftDiary.DTO;

namespace ShiftDiary.Models
{
    public class ShiftHBM
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime ShiftDate { get; set; }
        public virtual long ShiftStart { get; set; }
        public virtual long ShiftEnd { get; set; }
        public virtual int ShiftBreakMins { get; set; }
        public virtual string GemUrl { get; set; }
    }
}
