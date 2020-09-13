using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HoneyMarket.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<HoneyContext>
    {
        protected override void Seed(HoneyContext context)
        {
            context.Honeys.Add(new Honey() { Name = "Липовый мёд", Producer = "Фёдор", Price = 500 });
            context.Purchases.Add(new Purchase() {HoneyId = 1, Address="г.Рязань", DateTime=DateTime.Now, Email="ivan@gmail.com", FIO="Иванов Иван Иванович"});

            base.Seed(context);
        }
    }
}