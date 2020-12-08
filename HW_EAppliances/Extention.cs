using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EAppliances
{
    public static class Extention
    {
        public static void ShowItems(this IConsignment consig)
        {
            Console.WriteLine("Набор конфет: ");
            foreach (var i in consig.Items)
            {
                Console.WriteLine("Название аппарата: {0}, Вес аппарата: {1}, Потребляемая єнергия: {2},"
                    , i.name, i.weight, i.vat);

            }

        }
    }
}
