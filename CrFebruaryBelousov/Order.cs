using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrFebruaryBelousov
{
    internal class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int NumberBox { get; set; }
        public DateTime DateCreate { get; set; }
        public int Sum { get; set; }
    }
}
