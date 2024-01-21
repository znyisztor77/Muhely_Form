using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Muhely_Form
{
    internal class Muhely
    {
        
        public int id;
        public string nev;
        public DateTime meretvetel;
        public DateTime atadas;
        public string eszkoz;
        public string orvos;
        public string cim;
        public string taj;
        public DateTime szulev;
        public string telefon;

        
        public Muhely(int id, string nev, DateTime meretvetel, DateTime atadas, string eszkoz,string orvos, string cim, string taj, DateTime szulev, string telefon)
        {
            this.id = id;
            this.nev = nev;
            this.meretvetel = meretvetel;
            this.atadas = atadas;
            this.eszkoz = eszkoz;
            this.orvos = orvos;
            this.cim = cim;
            this.taj = taj;
            this.szulev = szulev;
            this.telefon = telefon;

        }
        

        public string toCSV()
        {
            return $"{id};{nev};{meretvetel};{atadas};{eszkoz};{orvos};{cim};{taj};{szulev};{telefon}";
        }
        public override string ToString()
        {
            return $"{nev} {eszkoz} {atadas}";
        }
    }
}
