using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public class Consignment : IConsignment
    {
        private ICollection<Applience> items;

        public Consignment()
        {
            items = new List<Applience>();
        }

        public void Add(Applience appl)
        {
            items.Add(appl);
        }

        public int ConsignmentWeight()
        {
            return items.Sum(x => x.weight);
        }

        public void Sort()
        {
            var temp = items.OrderBy(x => x.weight).ToList();
            items.Clear();
            foreach (var item in temp)
            {
                items.Add(item);
            }
        }

        public IEnumerable<Applience> FindApplienceByVat(int min, int max)
        {
            return items.Where(x => (x.vat >= min) && (x.vat <= max)).ToList();
        }

        public IEnumerable<Applience> Items
        {
            get { return this.items; }
        }
    }
}
