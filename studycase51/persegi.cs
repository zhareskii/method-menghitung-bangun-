using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studycase51
{
    internal class persegi
    {
        public void luasPersegi()
        {
            int sisi, luas;
            Console.Write("Masukan sisi: ");
            sisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================");
            luas = sisi * sisi;
            Console.WriteLine($"Luas persegi: {luas}");

        }
    }
}
