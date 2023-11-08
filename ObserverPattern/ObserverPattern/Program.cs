using ObserverPattern.Implement;
using ObserverPattern.Interface;
using System;

namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExchangeRateData exchangeRateData = new ExchangeRateData();
            IObserver observer = new ABank(exchangeRateData);

            exchangeRateData.SetRate(0.021);
            exchangeRateData.SetRate(0.020);
        }
    }
}