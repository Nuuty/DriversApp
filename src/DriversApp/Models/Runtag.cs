using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriversApp.Models
{
    public class Runtag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DueTime { get; set; }
        public string Address { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }

        public Runtag()
        {
            
        }

    }
}
