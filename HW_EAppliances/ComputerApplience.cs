using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public enum TypeComputerApplience { Acer, Linux };
    public class ComputerApplience : Applience
    {
        public TypeComputerApplience Computertype;
        public ComputerApplience(string CompName, int CompWeight, int CompVat, TypeComputerApplience Computertype)
            : base(CompName, CompWeight, CompVat)
        {
            this.Computertype = Computertype;
        }
        public override void TypeApplience()
        {
            Console.WriteLine(Computertype.ToString());
        }
    }
}
