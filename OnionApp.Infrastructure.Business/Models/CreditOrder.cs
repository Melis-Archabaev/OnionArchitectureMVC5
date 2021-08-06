using OnionApp.Domain.Core.Entities;
using OnionApp.Services.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Infrastructure.Business.Models
{
    public class CreditOrder:IOrder
    {
        public void MakeOrder(Book book)
        {
            //код покупки книги с помошъю кредитной карты
        }
    }
}
