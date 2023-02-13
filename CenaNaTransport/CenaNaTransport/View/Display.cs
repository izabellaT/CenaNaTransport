using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenaNaTransport.View
{
    public class Display
    {
        public int N { get; set; }
        public string DayTime { get; set; }
        public double Cena { get; set; }
        public Display()
        {
            N = 0;
            DayTime = string.Empty;
            Cena = 0;
            GetValues();
        }
        private void GetValues()
        {
            Console.WriteLine("Enter kms");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day or night");
            DayTime = Console.ReadLine();
        }
        public void ShowCena()
        {
            Console.WriteLine(Cena);
        }
    }
}
