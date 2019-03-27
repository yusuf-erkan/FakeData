using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahteVeri
{
    class FakeNumberData
    {
        
        
          
        Random rnd;
        public FakeNumberData()
        {
            rnd = new Random();
        }
        public int Karmayas()
        {
            int[] yaslst = { 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };
            int rnd2 = rnd.Next(0, 10);
            return yaslst[rnd2];
        }
        public int Karmanumber()
        {
            int[] numberlst = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int rnd2 = rnd.Next(0, 10);
            return numberlst[rnd2];
        }
    }
}
