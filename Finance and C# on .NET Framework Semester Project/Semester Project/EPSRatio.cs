using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Project
{
   public class EPSRatio
    {
        public EPSRatio(decimal earnings, decimal shares)
        {
            Earnings = earnings;

            Shares = shares;

        }
        public decimal Earnings { get; set; }
        public decimal Shares { get; set; }

    }
}
