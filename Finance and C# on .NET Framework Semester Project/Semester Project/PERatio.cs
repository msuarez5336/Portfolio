using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Project
{
    class PERatio
    {
        public PERatio(decimal sharePrice, decimal EPS)
        {
            SharePrice = sharePrice;

            Eps = EPS;
        }
        public decimal SharePrice { get; set; }
        public decimal Eps { get; set; }
    }
}
