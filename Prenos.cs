using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clickathon3000
{
    internal class Prenos
    {
        private static string naslov = "", tekst = "";

        public static string Naslov { get => naslov; set => naslov = value; }
        public static string Tekst { get => tekst; set => tekst = value; }

        /*public string Naslov { get => naslov; set => naslov = value; }
        public string Tekst { get => tekst; set => tekst = value; }*/
        /*public static string Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }*/
    }
}
