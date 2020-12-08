using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    class ComputerCreator : Creator
    {
        public override Applience FactoryMethod(string CompName, int CompWeight, int CompVat, TypeComputerApplience Computertype)
        {
            return new ComputerApplience(CompName, CompWeight, CompVat, Computertype);
        }
        public override Applience FactoryMethod(string EAppName, int EAppWeight, int EAppVat, TypeTVApplience type)
        {
            throw new NotImplementedException();
        }
    }
}
