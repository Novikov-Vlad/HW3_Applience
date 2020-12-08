using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public enum TypeTVApplience { LG, SONY };
    public class TVApplience : Applience
    {
        public TypeTVApplience type;

        public TVApplience(string EAppName, int EAppWeight, int EAppVat, TypeTVApplience type)
            : base( EAppName, EAppWeight, EAppVat)
        {
            this.type = type;
        }
        public override void TypeApplience()
        {
            Console.WriteLine(type.ToString());
        }
    }
}
