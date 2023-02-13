using CenaNaTransport.Model;
using CenaNaTransport.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CenaNaTransport.Controllers
{
    public class TransportController
    {
        private Transport transport;
        private Display display;
        public TransportController()
        {
            display = new Display();
            transport = new Transport(display.N, display.DayTime);
            display.Cena = transport.CalcullatePrice();
            display.ShowCena();
        }
    }
}
