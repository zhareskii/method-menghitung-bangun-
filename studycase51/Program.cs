using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studycase51
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pilih menu!\n" +
                "1. Luas Persegi\n" +
                "2. Luas Lingkaran\n" +
                "3. Volume Balok\n");
            int menu = Convert.ToInt32(Console.ReadLine());

            if(menu == 1)
            {
                persegi myPersegi = new persegi();
                myPersegi.luasPersegi();
            }
            else if (menu == 2)
            {
                lingkaran myLingkaran = new lingkaran();
                myLingkaran.luasLingkaran();
            }
            else if (menu == 3)
            {
                balok myBalok = new balok();
                myBalok.volumeBalok();
            }
            else
            {
                Console.WriteLine("Masukan angka sesuai menu!");
            }
        }
    }
}
