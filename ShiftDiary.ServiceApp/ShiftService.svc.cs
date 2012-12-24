using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ShiftDiary.Repository;
using ShiftDiary.Models;
using AutoMapper;
using ShiftDiary.DTO;

namespace ShiftDiary.ServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HotelChainService" in code, svc and config file together.
    public class ShiftService : IShiftService
    {
        private IRepository<ShiftHBM> shiftRepository;

        public ShiftService(IRepository<ShiftHBM> shiftRepository)
        {
            this.shiftRepository = shiftRepository;
        }

        public IEnumerable<Shift> GetAll()
        {
            return (IEnumerable<Shift>)shiftRepository.Get();
        }

        public Shift GetShift(int id)
        {
            return (Shift)shiftRepository.Get(id);
        }

        public void Save(Shift obj)
        {
            shiftRepository.Save((ShiftHBM)obj);
        }

        public void Delete(Shift obj)
        {
            shiftRepository.Delete((ShiftHBM)obj);
        }
    }
}
