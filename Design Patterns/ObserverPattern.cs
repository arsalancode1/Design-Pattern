using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class ObserverPattern
    {
        public static void TestObserverPattern()
        {
            Microsoft msStock = new Microsoft("MSFT", 87);
            msStock.AttachInvestor(new Investor("Aks"));
            msStock.AttachInvestor(new Investor("Aqb"));

            msStock.Price = 90;
            msStock.Price = 93;
        }
    }

    abstract class Stock
    {
        private string _symbol;
        private int _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        public Stock(string symbol,int price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                Notify();
            }
        }

        public string Symbol
        {
            get { return _symbol; }
        }

        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }
        }

        public void AttachInvestor(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void DetachInvestor(IInvestor investor)
        {
            _investors.Remove(investor);
        }
    }

    interface IInvestor
    {
        void Update(Stock stock);
    }

    class Investor : IInvestor
    {
        private string _name;
        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notifying {0} - Stock {1} updated with price {2}", this._name, stock.Symbol, stock.Price);
        }
    }

    class Microsoft : Stock
    {
        public Microsoft(string symbol, int price) : base(symbol, price)
        {

        }
    }

}
