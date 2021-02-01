using System;

namespace ConsoleApplication
{
    //Задание 2.


    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }


    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }


    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }

    //Задание 3.

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();


    }

    public interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();

    }


    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2.

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введите ключь: ");
            string sirealnumber = Console.ReadLine();

            DocumentWorker freeprogramm = new DocumentWorker();

            ProDocumentWorker proprogramm = new ProDocumentWorker();

            ExpertDocumentWorker expertprogramm = new ExpertDocumentWorker();


            if (sirealnumber == "pro")
            {
                proprogramm.EditDocument();
                proprogramm.SaveDocument();
            }
            if (sirealnumber == "exp")
            {
                expertprogramm.SaveDocument();
            }
            else
            {
                freeprogramm.OpenDocument();
                freeprogramm.EditDocument();
                freeprogramm.SaveDocument();
            }


            //Задание 3.

            IPlayable Play = new Player();
            IRecodable Record = new Player();

            Console.WriteLine();
            Play.Play();
            Play.Pause();
            Play.Stop();

            Console.WriteLine();
            Record.Record();
            Record.Pause();
            Record.Stop();
        }
    }
}
