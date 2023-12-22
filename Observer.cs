using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; 
        Market Market = new Market();
        Buyer Buyer1 = new Buyer("Іван Семенов", Market);
        Buyer Buyer2 = new Buyer("Костянтин Федоров", Market);
        // генерація знижки
        Market.MarketSales();
        Market.MarketSales();
        Market.MarketSales();
        Buyer1.StopMale();
        // генерація знижки
        Market.MarketSales();

        Console.Read();
    }
}

interface IObserver
{
    void Update(Object ob);
}

interface IObservable
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}

class Market : IObservable
{
    Random rnd = new Random();
    DateTime date = new DateTime(2023, 12, 15);
    SalesInfo sInfo; // информация о скидках

    List<IObserver> observers;
    public Market()
    {
        observers = new List<IObserver>();
        sInfo = new SalesInfo();
    }
    public void RegisterObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (IObserver o in observers)
        {
            o.Update(sInfo);
        }
    }

    public void MarketSales()
    {
        sInfo.Date =  (date=date.AddDays(rnd.Next(1,5))).ToShortDateString();
        sInfo.Sales = rnd.Next(10, 20);
        NotifyObservers();
    }
}

class SalesInfo
{
    public int Sales { get; set; }
    public string Date { get; set; }

}

class Buyer : IObserver
{
    public string Name { get; set; }
    IObservable Market;
    public Buyer(string name, IObservable obs)
    {
        this.Name = name;
        Market = obs;
        Market.RegisterObserver(this);
    }
    public void Update(object ob)
    {
        SalesInfo sInfo = (SalesInfo)ob;
        Console.WriteLine("Шановний {0}, {1} знижка - {2}", Name, sInfo.Date, sInfo.Sales);
    }
    public void StopMale()
    {
        Market.RemoveObserver(this);
        Market = null;
    }
}


