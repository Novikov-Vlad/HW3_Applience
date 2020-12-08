using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new TVApplienceCreator();
            creators[1] = new ComputerCreator();

            IConsignment consig = new Consignment();

            foreach (Creator i in creators)
            {
                if (i is TVApplienceCreator)
                {
                    consig.Add(i.FactoryMethod("SMART", 20, 100, TypeTVApplience.LG));
                    consig.Add(i.FactoryMethod("BEREZKA", 45, 75, TypeTVApplience.SONY));
                }

                if (i is ComputerCreator)
                {
                    consig.Add(i.FactoryMethod("ASPIRE NITRO", 30, 115, TypeComputerApplience.Acer));
                }
            }

            consig.Sort();
            consig.ShowItems();

            Console.WriteLine();
            foreach (var items in consig.FindApplienceByVat(20, 110))
            {
                Console.WriteLine("Название техники: {0}, Потребление энергии: {1}", items.name, items.vat);
            }

            Console.WriteLine();
            Console.WriteLine("Вес партии груза: {0}", consig.ConsignmentWeight());
            Console.ReadKey();
        }
    }
}
