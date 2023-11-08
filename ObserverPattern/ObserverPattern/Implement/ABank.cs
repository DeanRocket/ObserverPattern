using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implement
{
    public class ABank : IObserver
    {
        private ExchangeRateData exchangeRateData;
        private double japRate;
        public ABank(ExchangeRateData exchangeRateData)
        {
            this.exchangeRateData = exchangeRateData;
            exchangeRateData.RegisterObserver(this);

        }

        public void Update()
        {
            japRate = exchangeRateData.GetJapRate();
            display();
        }
        public void display()
        {
            Console.WriteLine("現在日幣的匯率是: " + japRate);
        }
    }
}
