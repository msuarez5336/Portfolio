using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Project
{
    public class CurrentRatio
    {
        public CurrentRatio(decimal assets, decimal liabilities)
        {
            Assets = assets;

            Liabilities = liabilities;

        }
        public decimal Assets { get; set; }
        public decimal Liabilities { get; set; }

    }
  
}

