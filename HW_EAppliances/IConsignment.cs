using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public interface IConsignment
    {
        IEnumerable<Applience> Items { get; }
        void Add(Applience sweets);
        int ConsignmentWeight();
        void Sort();
        //void ShowItems();
        IEnumerable<Applience> FindApplienceByVat(int min, int max);
        //void FindCandyBySugar(int min, int max);
    }
}
