using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjektiPon
{
    class Stablo
    {
        bool otpadajuListovi;
        string vrstaStabla;

        //set
        public void setListovi(bool otpdajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }

        //get
        public bool getListovi()
        {
            return this.otpadajuListovi;
        }

        public override string ToString()
        {
            return "Stablo je " + this.vrstaStabla;

        }

        public Stablo()
        { }
        //konstruktor
        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
            if (otpadajuListovi)
            {
                this.vrstaStabla = "bijelogorično";

            }
            else
            {
                this.vrstaStabla = "crnogorično";

            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(true);
            Stablo stablo2 = new Stablo(false);

            Console.WriteLine(stablo1.ToString());
            Console.WriteLine(stablo2.ToString());
            Console.ReadKey();
        }


    }
}
