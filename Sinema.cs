using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineeema
{
    class Sinema
    {
        int topkoltuksayi;
        int boskoltuksayi;
        double bakiye;
        string salonNo;

        const double TAM = 15.0;
        const double INDIRIMLI = 10.0;
        public Sinema(string salon,int koltuksayi)
        {
            topkoltuksayi = koltuksayi;
            salonNo = salon;
            boskoltuksayi = topkoltuksayi;
            bakiye = 0;           
        }
        public void BiletSat(bool indirimli)
        {
            boskoltuksayi--;
            if (indirimli)
                bakiye += INDIRIMLI;
            else
                bakiye += TAM;
        }
        public void BiletIptal(bool indirimli)
        {
            boskoltuksayi++;
            if (indirimli)
                bakiye -= INDIRIMLI;
            else
                bakiye -= TAM;

        }
        public int BosKoltukOgren()
        {
            return boskoltuksayi;
        }
        public double bakiyeogren()
        {
            return bakiye;
        }















    }
}
