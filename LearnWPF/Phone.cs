using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnWPF
{
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public override string ToString()
        {
            return $"Смартфон {Name}; Цена: {Price}";
        }
    }
}
