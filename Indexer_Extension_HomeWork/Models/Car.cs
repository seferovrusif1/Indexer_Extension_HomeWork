using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Extension_HomeWork.Models
{
    internal class Car
    {

        public string Name { get; set; }
        public string color { get; set; }
        public int ProductYear { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\nColor: {color}\nProductYear: {ProductYear}";
        }
    }
}
