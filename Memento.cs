//using System;
//namespace Memento
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            TestState teststate = new TestState() { StringProperty = "Test", IntProperty = 15 };
//            teststate.Print();
//            Caretaker ct1 = new Caretaker();
//            Caretaker ct2 = new Caretaker();
//            ct1.SaveState(teststate);
//            teststate.IntProperty += 152;
//            teststate.Print();
//            ct2.SaveState(teststate);
//            ct1.RestoreState(teststate);
//            teststate.Print();
//            ct2.RestoreState(teststate);
//            teststate.Print();
//            Console.ReadKey();
//        }
//    }
//    public interface IOriginator
//    {
//        object GetMemento();
//        void SetMemento(object memento);
//    }
//    public class TestState : IOriginator
//    {
//        public string StringProperty { get; set; }
//        public int IntProperty { get; set; } = 0;
//        public void Print()
//        {
//            Console.WriteLine("=============");
//            Console.WriteLine($"StringProperty value: {StringProperty} IntProperty value: {IntProperty}");
//            Console.WriteLine("=============");
//        }
//        object IOriginator.GetMemento()
//        {
//            return new Memento
//            {
//                StringProperty = this.StringProperty,
//                IntProperty = this.IntProperty
//            };
//        }
//        void IOriginator.SetMemento(object memento)
//        {
//            if (Object.ReferenceEquals(memento, null))
//                throw new ArgumentNullException("memento");
//            if (!(memento is Memento))
//                throw new ArgumentException("memento");
//            StringProperty = ((Memento)memento).StringProperty;
//            IntProperty = ((Memento)memento).IntProperty;
//        }
//        class Memento
//        {
//            public string StringProperty { get; set; }
//            public int IntProperty { get; set; }
//        }
//    }
//    public class Caretaker
//    {
//        private object m_memento;
//        public void SaveState(IOriginator originator)
//        {
//            if (originator == null)
//                throw new ArgumentNullException("originator");
//            m_memento = originator.GetMemento();
//        }
//        public void RestoreState(IOriginator originator)
//        {
//            if (originator == null)
//                throw new ArgumentNullException("originator");
//            if (m_memento == null)
//                throw new InvalidOperationException("m_memento == null");
//            originator.SetMemento(m_memento);
//        }
//    }
//}
