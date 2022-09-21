using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void ZmianaNrHandler(int nowyNr, int staryNr);

namespace ZarzadzanieSklepem
{
    class NrZamowienia
    {
        public event ZmianaNrHandler ZmianaNr;
        private int numer;


        public int Numer
        {
            get { return numer; }
            set
            {
                if (numer != value)
                {
                    var tmp = numer;
                    numer = value;
                    ZmianaNr?.Invoke(value,tmp); //-warunkowe wywoałenie na obiekcie
                }
            }
        }
    }
}
