using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ShiftDiary.DTO
{
    [DataContract]
    public class Month
    {
        [DataMember]
        public virtual int MonthInt { get; set; }

        [DataMember]
        public virtual string Name { get; set; }

        [DataMember]
        public virtual List<Week> Weeks { get; set; }

        [DataMember]
        public virtual Year Year { get; set; }

        public Month(int monthInt, string name, int year)
        {
            MonthInt = monthInt;
            Name = name;
            Year = new Year(year);

            Weeks = new List<Week>();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var t = obj as Month;
            if (t == null)
            {
                return false;
            }

            if (Name + Year.Name == t.Name + t.Year.Name)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name + "|" + Year.Name).GetHashCode();
        }
    }
}
