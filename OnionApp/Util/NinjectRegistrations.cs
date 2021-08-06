using Ninject.Modules;
using Onion.App.Infrasutructure.Data.Context;
using OnionApp.Domain.Interfaces.Interfaces;
using OnionApp.Infrastructure.Business.Models;
using OnionApp.Services.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnionApp.Util
{
    public class NinjectRegistrations:NinjectModule
    {
        public override void Load()
        {
            Bind<IBookRepository>().To<BookRepository>();
            Bind<IOrder>().To<CacheOrder>();
        }
    }
}