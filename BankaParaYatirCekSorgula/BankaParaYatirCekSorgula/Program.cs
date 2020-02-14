using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaParaYatirCekSorgula
{
    class BankaIsleri
    {
        private int bakiye = 1000000;
        public void ParaYatir (int miktar)
        {
            bakiye += miktar;
        }
        public void ParaCek (int miktar)
        {
            bakiye -= miktar;
        }
        public int BakiyeSorgula()
        {
            return bakiye;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            BankaIsleri b1 = new BankaIsleri();
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz" +
                "\n1-ParaYatır" +
                "\n2-ParaÇek" +
                "\n3-BakiyeSor" +
                "\n4-ÇıkışYap");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim=='3')
            {
                Console.WriteLine("Banka hesabınızda" + " " + b1.BakiyeSorgula() + " " + "TL vardır.");
                goto BASADON;            
            }
            if (secim=='1')
            {
                Console.WriteLine("Ne kadar yatıracaksınız");
                int yatirilan = int.Parse(Console.ReadLine());
                b1.ParaYatir(yatirilan);
                Console.WriteLine("Banka hesabınızda" + " " + b1.BakiyeSorgula() + " " + "TL vardır.");
                goto BASADON;
            }
            if (secim=='2')
            {
                Console.WriteLine("Ne kadar çekeceksiniz");
                int cekilen = int.Parse(Console.ReadLine());
                b1.ParaCek(cekilen);
                Console.WriteLine("Banka hesabınızda" + " " + b1.BakiyeSorgula() + " " + "TL vardır.");
                goto BASADON;
            }
            if (secim=='4')
            {
                Environment.Exit(0);
            }
            
            Console.Read();
        }
    }
}
