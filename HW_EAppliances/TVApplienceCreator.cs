using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public class TVApplienceCreator : Creator
    {
        public override Applience FactoryMethod(string EAppName, int EAppWeight, int EAppVat, TypeTVApplience type)
        {
            return new TVApplience(EAppName, EAppWeight, EAppVat, type);
        }
        public override Applience FactoryMethod(string EAppName, int EAppWeight, int EAppVat, TypeComputerApplience Computertype)
        {
            throw new NotImplementedException();
        }
    }
}
