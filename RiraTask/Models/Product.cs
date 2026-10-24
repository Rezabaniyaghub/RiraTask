using RiraTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiraTask.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Categories Category { get; set; }

        public decimal Price { get; set; }
    }
}
