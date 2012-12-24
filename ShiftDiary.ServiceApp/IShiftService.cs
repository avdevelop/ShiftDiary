using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShiftDiary.DTO;

namespace ShiftDiary.ServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHotelChainService" in both code and config file together.
    [ServiceContract]
    public interface IShiftService
    {
        [OperationContract]
        IEnumerable<Shift> GetAll();

        [OperationContract]
        Shift GetShift(int id);

        [OperationContract]
        void Save(Shift obj);

        [OperationContract]
        void Delete(Shift obj);
    }
}
