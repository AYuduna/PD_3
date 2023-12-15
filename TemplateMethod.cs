//using System;


////class School
////{
////    // идем в первый класс
////    public void Enter() { }
////    // обучение
////    public void Study() { }
////    // сдаем выпускные экзамены
////    public void PassExams() { }
////    // получение аттестата об окончании
////    public void GetAttestat() { }
////}

////class Academy
////{
////    // поступление в университет
////    public void Enter() { }
////    // обучение
////    public void Study() { }
////    // проходим практику
////    public void Practice() { }
////    // сдаем выпускные экзамены
////    public void PassExams() { }
////    // получение диплома
////    public void GetDiploma() { }
////}

//class Program
//{
//    static void Main(string[] args)
//    {
//        School school = new School();
//        Academy academy = new Academy();

//        school.Learn();
//        academy.Learn();

//        Console.Read();
//    }
//}
//abstract class Education
//{
//    public void Learn()
//    {
//        Enter();
//        Study();
//        PassExams();
//        GetDocument();
//    }
//    public abstract void Enter();
//    public abstract void Study();
//    public virtual void PassExams()
//    {
//        Console.WriteLine("Сдаем выпускные экзамены");
//    }
//    public abstract void GetDocument();
//}

//class School : Education
//{
//    public override void Enter()
//    {
//        Console.WriteLine("Идем в первый класс");
//    }

//    public override void Study()
//    {

//        Console.WriteLine("Посещаем уроки, делаем домашние задания");
//    }

//    public override void GetDocument()
//    {
//        Console.WriteLine("Получаем аттестат о среднем образовании");
//    }

//    //public new void Learn()
//    //{ 
//    //    Console.WriteLine("Не хочу учиться......"); 
//    //}
//}
//class Academy : Education
//{
//    public override void Enter()
//    {
//        Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ");
//    }

//    public override void Study()
//    {
//        Console.WriteLine("Посещаем лекции");
//        Console.WriteLine("Проходим практику");
//    }

//    public override void PassExams()
//    {
//        Console.WriteLine("Сдаем экзамен по специальности");
//    }

//    public override void GetDocument()
//    {
//        Console.WriteLine("Получаем диплом о высшем образовании");
//    }
//}
