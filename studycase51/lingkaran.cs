using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studycase51
{
    internal class lingkaran
    {
        public void luasLingkaran()
        {
            double jari, luas;
            Console.Write("Masukan jari-jari lingkaran: ");
            jari = Convert.ToInt32(Console.ReadLine());

            if (jari%7==0)
            {
                Console.WriteLine("=====================");
                luas = 22 / 7 * jari * jari;
                Console.WriteLine($"Luas lingkaran: {luas}");
            }
            else
            {
                Console.WriteLine("=====================");
                luas = 3.14 * jari * jari;
                Console.WriteLine($"Luas lingkaran: {luas}");
            }
        }
    }
}
