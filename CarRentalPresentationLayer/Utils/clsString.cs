using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalPresentationLayer.Utils
{
    public static class clsString
    {
        public static string PriceToString(decimal Price)
        {
            return Price.ToString("F2") + " AED";
        }
    }
}
