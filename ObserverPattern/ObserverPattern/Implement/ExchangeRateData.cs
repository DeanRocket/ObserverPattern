using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implement
{
    public class ExchangeRateData : ISubject
    {
        private List<IObserver> observers;
        private double japRate;

        public ExchangeRateData()
        {
            observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
        public void RateChanged()
        {
            NotifyObservers();
        }
        public void SetRate(double japRate)
        {
            this.japRate = japRate;
            RateChanged();

        }
        public double GetJapRate()
        {
            return japRate;
        }
    }

}

