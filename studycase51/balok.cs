using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studycase51
{
    internal class balok
    {
        public void volumeBalok()
        {
            double panjang, lebar, tinggi, volume;
            Console.Write("Masukan panjang: ");
            panjang= Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan lebar: ");
            lebar= Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan tinggi: ");
            tinggi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=====================");
            volume = panjang * lebar * tinggi;
            Console.WriteLine($"Volume balok: {volume}");
        }
    }
}
