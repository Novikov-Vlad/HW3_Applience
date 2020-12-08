using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public abstract class Applience
    {
        public string name { get; private set; }
        public int weight { get; private set; }
        public int vat { get; private set; }//Колличество потребляемой энергии

        public Applience(string AppName, int AppWeight, int AppVat)
        {
            this.name = AppName;
            this.weight = AppWeight;
            this.vat = AppVat;
        }

        public abstract void TypeApplience();
    }
}
