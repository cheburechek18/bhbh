using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            Console.WriteLine("Время ВИКТОРИНЫ!!!!!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("у вас будет всего три попытки на проигрышь и 5 вопросов !");
           
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("НАЧАЛИ!");

            Console.WriteLine("в каком году была куликовская битва");//q 1
            string q1 = Console.ReadLine();
            if (q1=="1380")
            {
                Console.WriteLine("Верно");
                Console.WriteLine("Счётчик ошибок = "+a);
                Console.WriteLine("Следующий вопрос");//nextq
               
                Console.WriteLine("какая самая богатая страна");//q2
                string q2 = Console.ReadLine();
                if (q2 == "швеция")//q2a
                {
                    Console.WriteLine("верно счётчик ошибок = "+a);
                    Console.WriteLine("сколько горбов у верблюда");//q3
                    string q3 = Console.ReadLine();
                    Console.WriteLine();
                    if (q3 == "2")//q3a
                    {
                        Console.WriteLine("верно счётчик ошибок = " + a);
                        Console.WriteLine();
                        Console.WriteLine("последний вопрос сколько будет 2+2");//ql
                        string ql4 = Console.ReadLine();
                        if (ql4 == "4")//qal
                        {
                            Console.WriteLine("ты прошёл!!!00000)))(9((9)()()()9)!)(01()!!)(!))!");
                        }
                        else
                        {
                            a++;
                            Console.WriteLine("счётчик ошибок = " + a);//f
                            if (a == 3)
                            {
                                Console.WriteLine("игра окончена ");

                            }
                        }

                    }
                    else
                    {
                        a++;
                        Console.WriteLine("неверно счётчик ошибок = " + a);
                    }

                    Console.ReadLine();
                }
                else
                {
                    a++;
                    Console.WriteLine("неверно счётчик ошибок = " + a);

                    Console.WriteLine("сколько горбов у верблюда");//q3
                    string q3 = Console.ReadLine();
                    Console.WriteLine();
                    if (q3 == "2")//q3a
                    {
                        Console.WriteLine("верно счётчик ошибок = " + a);
                        Console.WriteLine();
                        Console.WriteLine("последний вопрос сколько будет 2+2");//ql
                        string ql4 = Console.ReadLine();
                        if (ql4 == "4")//qal
                        {
                            Console.WriteLine("ты прошёл!!!00000)))(9((9)()()()9)!)(01()!!)(!))!");
                        }
                        else
                        {
                            a++;
                            Console.WriteLine("счётчик ошибок = " + a);//f
                            if (a == 3)
                            {
                                Console.WriteLine("игра окончена ");

                            }
                        }
                    }
                    else
                    {
                        a++;
                        Console.WriteLine("неверно счётчик ошибок = " + a);
                        Console.WriteLine("последний вопрос сколько будет 2+2");//ql
                        string ql4 = Console.ReadLine();
                        if (ql4 == "4")//qal
                        {
                            Console.WriteLine("ты прошёл!!!00000)))(9((9)()()()9)!)(01()!!)(!))!");
                        }
                        else
                        {
                            a++;
                            Console.WriteLine("счётчик ошибок = " + a);//f
                            if (a == 3)
                            {
                                Console.WriteLine("игра окончена ");

                            }
                        }
                    }
                    Console.ReadLine();
                }
                Console.ReadLine();

            }
            else
            {
                a++;
                Console.WriteLine("неверно. Счётчик ошибок = " + a);

                
                Console.WriteLine("какая самая богатая страна");//q2
                string q2 = Console.ReadLine();
                if (q2 == "швеция")//q2a
                {
                    Console.WriteLine("верно счётчик ошибок = "+a);
                    a++;
                    Console.WriteLine("неверно счётчик ошибок = " + a);

                    Console.WriteLine("сколько горбов у верблюда");//q3
                    string q3 = Console.ReadLine();
                    Console.WriteLine();
                    if (q3 == "2")//q3a
                    {
                        Console.WriteLine("верно счётчик ошибок = " + a);
                        Console.WriteLine("последний вопрос сколько будет 2+2");//ql
                        string ql4 = Console.ReadLine();
                        if (ql4 == "4")//qal
                        {

                        }
                        else
                        {
                            a++;
                            Console.WriteLine("счётчик ошибок = " + a);//f
                            if (a == 3)
                            {
                                Console.WriteLine("игра окончена ");

                            }
                        }
                        
                    }
                    else
                    {
                        a++;
                        Console.WriteLine("неверно счётчик ошибок = " + a);
                        Console.WriteLine("последний вопрос сколько будет 2+2");//ql
                        string ql4 = Console.ReadLine();
                        if (ql4 == "4")//qal
                        {

                        }
                        else
                        {
                            a++;
                            Console.WriteLine("счётчик ошибок = " + a);//f
                            if (a == 3)
                            {
                                Console.WriteLine("игра окончена ");

                            }
                        }
                    }
                    Console.ReadLine();
                }
                else
                {
                    a++;
                    Console.WriteLine("неверно счётчик ошибок = " + a);
                   

                    Console.WriteLine("сколько горбов у верблюда");//q3
                    string q3 = Console.ReadLine();
                    Console.WriteLine();
                    if (q3 == "2")//q3a
                    {
                        Console.WriteLine("верно счётчик ошибок = " + a);
                        Console.WriteLine();
                        Console.WriteLine("последний вопрос сколько будет 2+2");//ql
                        string ql4 = Console.ReadLine();
                        if (ql4 == "4")//qal
                        {

                        }
                        else
                        {
                            a++;
                            Console.WriteLine("счётчик ошибок = " + a);//f
                            if (a == 3)
                            {
                                Console.WriteLine("игра окончена ");

                            }
                        }
                    }
                    else
                    {
                        a++;
                        Console.WriteLine("неверно счётчик ошибок = " + a);
                        if (a==3)
                        {
                            Console.WriteLine("игра окончена");

                        }
                        else
                        {
                            Console.WriteLine("последний вопрос сколько будет 2+2");//ql
                            string ql4=Console.ReadLine();
                            if (ql4=="4")//qal
                            {

                            }
                            else
                            {
                                a++;
                                Console.WriteLine("счётчик ошибок = "+a);//f
                                if (a == 3)
                                {
                                    Console.WriteLine("игра окончена ");
                                
                                }
                            }
                        }
                    }
                    Console.ReadLine();
                }
                
            }
            Console.ReadLine();
        }
    }
}
