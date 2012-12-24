using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using ShiftDiary.Repository;
using ShiftDiary.Models;

namespace ShiftDiary.ServiceApp
{
    public class WCFNinject : NinjectModule
    {
        public override void Load()
        {
            //Injects the constructors of all DI-ed objects 
            //with a LinqToSQL implementation of IRepository            
            Bind<IRepository<CalendarHBM>>().To<NHibernateRepository<CalendarHBM>>();
            Bind<IRepository<ShiftHBM>>().To<NHibernateRepository<ShiftHBM>>();            
        }
    }
}
