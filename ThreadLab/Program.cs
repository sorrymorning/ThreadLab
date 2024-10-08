﻿using System;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        class myThread
        {
            Thread thread;

            public myThread(string name, int num) //Конструктор получает имя функции и номер до кторого ведется счет
            {

                thread = new Thread(this.func);
                thread.Name = name;
                thread.Start(num);//передача параметра в поток
            }

            void func(object num)//Функция потока, передаем параметр
            {
                for (int i = 0; i < (int)num; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
                    Thread.Sleep(0);
                }
                Console.WriteLine(Thread.CurrentThread.Name + " завершился");
            }


        }

        static void Main(string[] args)
        {
            myThread t1 = new myThread("Thread 1", 6);
            myThread t2 = new myThread("Thread 2", 3);
            myThread t3 = new myThread("Thread 3", 2);

            Console.Read();

        }

    }
}