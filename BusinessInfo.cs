using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Practice_StaticClass_Methods_Constructor
{
    internal static class BusinessInfo
    {
        public static string _businessName = "Something Inc.";
        public static double _taxAmount;
        
        static BusinessInfo()
        {
            _businessName = "Something Inc.";
            _taxAmount = .11;
        }
        public static double TaxAmount { get; }
        public static double BusinessName { get; }

    }
}
