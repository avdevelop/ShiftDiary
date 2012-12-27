using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ShiftDiary.DTO
{
    [DataContract]
    public class Day
    {
        [DataMember]
        public virtual DateTime Date { get; set; }

        [DataMember]
        public virtual List<Shift> Shifts { get; set; }
        
        public Day(DateTime date)
        {
            Date = date;
            Shifts = new List<Shift>();
        }
    }
}
