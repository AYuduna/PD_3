//using System;
//using System.Threading;
//using System.Threading.Tasks;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Pult pult = new Pult();
//        TV tv = new TV();
//        pult.SetCommand(new TVOnCommand(tv));
//        pult.PressButton();
//        pult.PressUndo();

//        Microwave microwave = new Microwave();
//        // 5000 - время нагрева пищи
//        pult.SetCommand(new MicrowaveCommand(microwave, 5000));
//        pult.PressButton();

//        Console.Read();
//    }
//}

//// Invoker - инициатор
//class Pult
//{
//    ICommand command;

//    public Pult() { }

//    public void SetCommand(ICommand com)
//    {
//        command = com;
//    }

//    public void PressButton()
//    {
//        command.Execute();
//    }
//    public void PressUndo()
//    {
//        command.Undo();
//    }
//}

//interface ICommand
//{
//    void Execute();
//    void Undo();
   
//}

//// Receiver - Получатель 1
//class TV
//{
//    public void On()
//    {
//        Console.WriteLine("Телевизор включен!");
//    }

//    public void Off()
//    {
//        Console.WriteLine("Телевизор выключен...");
//    }
//}

//class TVOnCommand : ICommand
//{
//    TV tv;
//    public TVOnCommand(TV tvSet)
//    {
//        tv = tvSet;
//    }
//    public void Execute()
//    {
//        tv.On();
//    }
//    public void Undo()
//    {
//        tv.Off();
//    }
//}


//// Receiver - Получатель 2
//class Microwave
//{
//    public void StartCooking(int time)
//    {
//        Console.WriteLine("Подогреваем еду.....");
       
        
//    }

//    public void StopCooking()
//    {
//        Thread.Sleep(1000);
//        Console.Beep();
//        Console.WriteLine("Еда подогрета!");
//    }

//    public void UndoCooking()
//    {
//        Console.WriteLine("Отмена подогрева!");
//    }
//}
//class MicrowaveCommand : ICommand
//{
//    Microwave microwave;
//    int time;
//    public MicrowaveCommand(Microwave m, int t)
//    {
//        microwave = m;
//        time = t;
//    }
//    public void Execute()
//    {
//        microwave.StartCooking(time);
//        microwave.StopCooking();
//    }

//    public void Undo()
//    {
//        microwave.UndoCooking();
//    }
//}