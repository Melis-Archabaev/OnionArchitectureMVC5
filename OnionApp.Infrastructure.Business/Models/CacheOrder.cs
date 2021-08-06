using OnionApp.Domain.Core.Entities;
using OnionApp.Services.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Infrastructure.Business.Models
{
    public class CacheOrder:IOrder
    {
        public void MakeOrder(Book book)
        {
            //код покупки книги при оплате наличностью
        }
    }
}
