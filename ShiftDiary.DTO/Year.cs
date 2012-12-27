using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ShiftDiary.DTO
{
    [DataContract]
    public class Year
    {
        [DataMember]
        public int Name { get; set; }

        [DataMember]
        public List<Month> Months { get; set; }

        public Year(int name)
        {
            Name = name;
            Months = new List<Month>();
        }
    }
}
