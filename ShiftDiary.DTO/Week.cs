using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiftDiary.DTO
{
    public class Week
    {
        public int Index { get; set; }
        public List<Day> Days { get; set; }

        public Week()
        {
            Days = new List<Day>();
        }
    }
}
