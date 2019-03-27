using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    
    class FakeData
    {
       
        
          

        Random rnd;
        public FakeData()
        {
            rnd = new Random();
        }
        public string Karmaisim()
        {
            string[] isimlst = { "Onur", "Serkan", "Yusuf", "Nükhet", "Selcen", "Hasan", "Ahmet", "Günışığı", "Gülşah", "Gülcan" };
            int rnd2 = rnd.Next(0,10);
            return isimlst[rnd2];
        }
        public string Karmasoyisim()
        {
            string[] soyİsimlst = { "Atan", "Tutan", "Bakan", "Koç", "Sabancı", "Gençoğlu", "Karaca", "Manço", "Koray", "Kenter" };
            int rnd2 = rnd.Next(0, 10);
            return soyİsimlst[rnd2];
        } 
    }
}
