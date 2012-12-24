using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Ninject.Extensions.Wcf;
using Ninject;
using Ninject.Web.Common;
using AutoMapper;
using ShiftDiary.Models;
using ShiftDiary.DTO;

namespace ShiftDiary.ServiceApp
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {            
            //Mapper.CreateMap<HotelChain, HotelChainDTO>();
            //Mapper.CreateMap<HotelChainDTO, HotelChain>();

            //Mapper.CreateMap<Hotel, HotelDTO>();
            //Mapper.CreateMap<HotelDTO, Hotel>();            
            
            //Mapper.AssertConfigurationIsValid();
            

            StandardKernel kernel = new StandardKernel(new WCFNinject());
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            return kernel;
        }

        protected void Application_Start(object sender, EventArgs e)
        {
           
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}