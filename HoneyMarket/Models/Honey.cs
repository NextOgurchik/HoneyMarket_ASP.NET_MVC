using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoneyMarket.Models
{
    public class Honey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Price { get; set; }
    }
}