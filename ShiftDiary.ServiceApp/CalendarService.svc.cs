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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HotelService" in code, svc and config file together.
    public class CalendarService : ICalendarService
    {
        private IRepository<CalendarHBM> calendarRepository;

        public CalendarService(IRepository<CalendarHBM> calendarRepository)
        {
            this.calendarRepository = calendarRepository;
        }

        public IEnumerable<Calendar> GetAll()
        {
            return (IEnumerable<Calendar>)calendarRepository.Get();            
        }

        public Calendar GetCalendar(int id)
        {
            return (Calendar)calendarRepository.Get(id);
        }

        public void Save(Calendar obj)
        {
            calendarRepository.Save((CalendarHBM)obj);
        }

        public void Delete(Calendar obj)
        {
            calendarRepository.Delete((CalendarHBM)obj);
        }
    }
}
