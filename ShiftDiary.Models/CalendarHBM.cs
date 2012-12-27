using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShiftDiary.DTO;

namespace ShiftDiary.Models
{
    public class CalendarHBM
    {
        public virtual int Id { get; set; }
        public virtual DateTime CalendarDate { get; set; }
    }
}
