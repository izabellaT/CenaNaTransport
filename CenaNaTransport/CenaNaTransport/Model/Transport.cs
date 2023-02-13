using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenaNaTransport.Model
{
    public class Transport
    {
        private int n;
        private string dayTime;
        
        public int N
        {
            get { return this.n; }
            set
            {
                if (n < 0 || n > 5000)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    this.n = value;
                }
            }
        }
        public string DayTime 
        {
            get { return this.dayTime; }
            set { this.dayTime = value; }
        }
        public Transport(int n, string dayTime)
        {
            N = n;
            DayTime = dayTime;
        }
        public double CalcullatePrice()
        {
            double cena = 0;
            if (n < 20 && dayTime == "day")
            {
                cena = cena + 0.79 * n + 0.70;
            }
            else if (n < 20 && dayTime == "night")
            {
                cena = cena + 0.90 * n + 0.70;
            }
            if (n > 20 && n < 100 && dayTime == "day")
            {
                cena = cena + 0.09* n;
            }
            else if (n > 20 && n < 100 && dayTime == "night")
            {
                cena = cena + 0.09 * n;
            }
            if (n > 100 && dayTime == "day")
            {
                cena = cena + 0.06* n;
            }
            else if (n >100 && dayTime == "night")
            {
                cena = cena + 0.06* n;
            }
        }
    }
}
