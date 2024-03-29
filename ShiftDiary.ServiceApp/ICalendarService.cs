﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShiftDiary.DTO;

namespace ShiftDiary.ServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHotelService" in both code and config file together.
    [ServiceContract]
    public interface ICalendarService
    {
        [OperationContract]
        IEnumerable<Calendar> GetAll();

        [OperationContract]
        Calendar GetCalendar(int id);

        [OperationContract]
        void Save(Calendar obj);

        [OperationContract]
        void Delete(Calendar obj);
    }
}
