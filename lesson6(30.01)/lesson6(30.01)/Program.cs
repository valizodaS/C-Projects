using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_30._01_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //TASK1
            Console.Write("Пожалуйста вводите ключ:");
            String userKey = Console.ReadLine();
            ExpertDocumnetWorker dw = new ExpertDocumnetWorker(userKey);
            dw.OpenDocument();
            dw.EditDocument();
            dw.SaveDocument();
            Console.WriteLine("");

            ExpertDocumnetWorker dp = new ExpertDocumnetWorker(userKey); // "PROKEY12"
            dp.OpenDocument();
            dp.EditDocument();
            dp.SaveDocument();
            Console.WriteLine("");

            ExpertDocumnetWorker de = new ExpertDocumnetWorker(userKey);  // "EXPKEY12"
            de.OpenDocument();
            de.EditDocument();
            de.SaveDocument();
            Console.ReadLine();

            //Task2
            /*
            IPlayable pl = new Player();
            pl.Play();
            pl.Pause();
            pl.Stop();
            Console.WriteLine("");

            IRecodable rc = new Player();
            rc.Record();
            rc.Pause();
            rc.Stop();

            Console.ReadLine();
             */
        }


        class DocumentWorker
        {
            public void OpenDocument()
            {
                Console.WriteLine("Документ открыт!!!");
            }

            public void EditDocument()
            {
                Console.WriteLine("Редактирование документа доступно в версии ПРО");
            }
            public void SaveDocument()
            {
                Console.WriteLine("Сохранение документа доступно в версии ПРО");
            }
        }
        class ProDocumentWorker : DocumentWorker
        {
            private string Key = "PROKEY12";
            public string userKey;
            public void OpenDocument()
            {
                if (Key == userKey)
                {
                    Console.WriteLine("Документ открыт в режиме ПРО!!!");
                }
                else
                {
                    base.OpenDocument();
                }
            }

            public void EditDocument()
            {                
                if (Key == userKey)
                {
                    Console.WriteLine("Документ отредактирован!!!");
                }
                else
                {
                    base.EditDocument();
                }
            }
            public void SaveDocument()
            {                
                if (Key == userKey)
                {
                    Console.WriteLine("Документ сохранен в старом формате. Сохранение в остальных фаорматах доступно в версии Эксперт!!!");
                }
                else
                {
                    base.SaveDocument();
                }
            }

            public ProDocumentWorker(string s):base()
            {
               userKey = s;
            }
        }
        class ExpertDocumnetWorker : ProDocumentWorker
        {
            private string Key = "EXPKEY12";
            public string userKey;
            public void OpenDocument()
            {
                if (Key == userKey)
                {
                    Console.WriteLine("Документ открыт в режиме Эксперт!!!");
                }
                else
                {
                    base.OpenDocument();
                }
            }

            public void EditDocument()
            {
                if (Key == userKey)
                {
                    Console.WriteLine("Документ отредактирован в режиме Эксперт!!!");
                }
                else
                {
                    base.EditDocument();
                }
            }
            public void SaveDocument()
            {
                if (Key == userKey)
                {
                    Console.WriteLine("Документ сохранен в новом формате.");
                }
                else
                {
                    base.SaveDocument();
                }
            }

            public ExpertDocumnetWorker(string s):base(s) 
            {
                userKey = s;
            }
        }


        class Player: IPlayable, IRecodable
        {
            void IPlayable.Play()
            {
                Console.WriteLine("Играть Музыку!!!");
            }
            void IPlayable.Pause()
            {
                Console.WriteLine("Поставить музыку на паузу!!!");
            }
            void IPlayable.Stop()
            {
                Console.WriteLine("Остановить музыку!!!");
            }

            void IRecodable.Record()
            {
                Console.WriteLine("Записать");
            }
            void IRecodable.Pause()
            {
                Console.WriteLine("Остановаить запись");
            }
            void IRecodable.Stop()
            {
                Console.WriteLine("Завершить запись!!!");
            }
        }


        interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();

        }
        interface IRecodable
        {
            void Record();
            void Pause();
            void Stop();

        }
    }
}
