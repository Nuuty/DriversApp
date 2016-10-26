using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriversApp.Models;

namespace DriversApp.ViewModels
{
    public class RuntagIndexViewModel
    {
        public IEnumerable<RuntagViewModel> Runtags { get; set; }

        public RuntagIndexViewModel()
        {
            
        }
    }
}
