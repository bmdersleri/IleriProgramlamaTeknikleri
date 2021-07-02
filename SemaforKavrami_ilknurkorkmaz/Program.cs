using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp8
{
    public class Program
    {
        public static Semaphore Okur { get; set; }

        public static void Main(string[] args)
        {
            
            Okur = new Semaphore(3, 3);

            
            OpenKutuphane();
        }

        public static void OpenKutuphane()
        {
            for (int i = 1; i <= 50; i++)
            {
                // 
                Thread thread = new Thread(new ParameterizedThreadStart(ziyaretci));
                thread.Start(i);
            }
        }

        public static void ziyaretci(object args)
        {
            
            Console.WriteLine("ziyaretci {0} kütüphaneye girmeyi bekliyor .", args);
            Okur.WaitOne();

            
            Console.WriteLine("ziyaterci {0} biraz kitap okuyor.", args);
            Thread.Sleep(500);

            
            Console.WriteLine("ziyaretci {0} kütüphaneden ayrılıyor.", args);
            Okur.Release(1);
        }
    }
    }
