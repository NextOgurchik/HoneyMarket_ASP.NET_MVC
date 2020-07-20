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
            context.Honeys.Add(new Honey() { Name = "Мёд \"Ивашковский\"", Producer = "Фёдор", Price = 500 });

            base.Seed(context);
        }
    }
}