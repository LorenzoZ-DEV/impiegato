using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace impiegato
{
    public class Impiegato
    {
        public string nome;
        public double stipendiomensile;
        public decimal PercentualeIncremento; 
        public DateTime dateTime;
        public Impiegato()
        {
            nome = string.Empty;
            dateTime = DateTime.Now;
            stipendiomensile = 300;
            PercentualeIncremento = 0; 
        }
        public class CalcolatoreStipendio
        {
            public static decimal IncrementaStipendio(decimal stipendiomensile, decimal percentualeIncremento)
            {
                decimal incremento = stipendiomensile * (percentualeIncremento / 100);
                decimal nuovoStipendio = stipendiomensile + incremento;
                return nuovoStipendio;
            }
        }
      
    }
}
