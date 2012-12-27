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
            return Mapper.Map<IEnumerable<ShiftHBM>, IEnumerable<Shift>>(shiftRepository.Get());
        }

        public Shift GetShift(int id)
        {
            return Mapper.Map<ShiftHBM, Shift>(shiftRepository.Get(id));
        }

        public void Save(Shift obj)
        {
            shiftRepository.Save(Mapper.Map<Shift, ShiftHBM>(obj));
        }

        public void Delete(Shift obj)
        {
            shiftRepository.Delete(Mapper.Map<Shift, ShiftHBM>(obj));
        }

        public IEnumerable<Shift> GetShiftForMonth(Month month)
        {
            return Mapper.Map<IEnumerable<ShiftHBM>, IEnumerable<Shift>>(shiftRepository.Get().Where(s => s.ShiftDate.Month == month.MonthInt && s.ShiftDate.Year == month.Year.Name));
        }

        public IEnumerable<Shift> GetShiftForDay(Day day)
        {
            return Mapper.Map<IEnumerable<ShiftHBM>, IEnumerable<Shift>>(shiftRepository.Get().Where(s => s.ShiftDate == day.Date));
        }
    }
}
