using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedExtensionExtension
{
    public static class sClass
    {
        //РАСШИРЯЮЩИЕ МЕТОДЫ
        public static int[] SortAscending(this int[] array)
        {
            Array.Sort(array);
            return array;
        }

    }
}
