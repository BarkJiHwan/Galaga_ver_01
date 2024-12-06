using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Presentation_2.Program;

namespace Presentation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(30, 23);
            Stopwatch watch = new Stopwatch();
            long reverseCounter = 0;
            int[] bulltes = new int[100];
            string[] map =

            {
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "■　　　　　　　　　　　　　■",
             "　　　　　　　　　　　　　　",
            };

            foreach (var i in map)
            {
                Console.WriteLine(i);
            }

            int posX = 14; //x좌표 기억할 변수
            int posX_old = 14;
            int posY = 20;
            int posY_old = 20;
            Console.SetCursorPosition(posX, 20);
            Console.Write("★");
            bool isFired = true;
            bool[] bools = new bool[30];
            for (int i = 0; i > bools.Length; i++)
            {
                bools[i] = true;
            }

            while (true)
            {
                watch.Start();
                if (watch.ElapsedMilliseconds >= 50)
                {
                    watch.Restart();
                    if (Console.KeyAvailable) //사용가능한 키
                    {
                        var myInput = Console.ReadKey(true);
                        if (myInput.Key == ConsoleKey.A)
                        {
                            if (posX > 2)
                            {
                                posX_old = posX;
                                posX = posX - 2;
                            }
                        }
                        if (myInput.Key == ConsoleKey.D)
                        {
                            if (posX < 26)
                            {
                                posX_old = posX;
                                posX = posX + 2;
                            }
                        }
                        //if (myInput.Key == ConsoleKey.W)
                        //{
                        //    isFired = true;
                        //if (bools[rand] == false)
                        //{
                        //    bools[rand] = true;
                        //}
                        //else if (bools[rand] == true)
                        //{

                        //}

                        //if (posY > 1)
                        //{
                        //    posY_old = posY;
                        //    posY = posY - 1;
                        //}
                        //else if (posY_old > 1)
                        //{
                        //    posY_old -= 1;
                        //}

                    }
                    Console.SetCursorPosition(posX_old, 20);
                    Console.Write("　");
                    Console.SetCursorPosition(posX, 20);
                    Console.Write("★");


                    if (isFired == true)
                    {
                        for (int i = 20; i >= 0; i--)
                        {
                            if (posY > i)
                            {
                                posY -= 1;
                                Console.SetCursorPosition(posX, i);
                                Console.Write("▲");
                                Console.SetCursorPosition(posX_old, i);
                                Console.Write("　");
                            }
                            if (posY_old > i)
                            {
                                posY = 20;
                                posY_old = 20;
                            }
                        }
                    }
                }
            }
        }
        static bool Bulls()
        {
            bool[] bull = new bool[30];
            bull[0] = true;
            
            foreach (bool bulls in bull )
            {
                if(bulls)
                {
                    return true;
                }
            }
            return false;
        }
    }
}



//if (myInput.Key == ConsoleKey.W)
//{
//    watch.Start();
//    for (int i = 19; i >= 1; i--)
//    {
//        reverseCounter = (1000 - watch.ElapsedMilliseconds) / 1000;
//        if (reverseCounter > 0)
//        {
//            Console.SetCursorPosition(posX, i);
//            Console.Write("▲");
//        }
//        if (reverseCounter < 0)
//        {
//            Console.SetCursorPosition(posX, i);
//            Console.Write("　");
//        }
//        watch.Restart();
//    }
//}