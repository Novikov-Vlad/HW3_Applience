using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public abstract class Creator
    {
        public abstract Applience FactoryMethod(string EAppName, int EAppWeight, int EAppVat, TypeTVApplience type);
        public abstract Applience FactoryMethod(string EAppName, int EAppWeight, int EAppVat, TypeComputerApplience type);
    }
}
