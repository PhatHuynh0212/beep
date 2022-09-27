using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace demo
{
    internal class Program
    {
        static int[] DO = { 131, 262, 523, 1074 };
        static int[] DOs = { 139, 277, 540, 1109 };
        static int[] RE = { 147, 294, 587, 1175 };
        static int[] REs = { 156, 311, 622, 1245 };
        static int[] MI = { 165, 330, 659, 1319 };
        static int[] FA = { 175, 349, 698, 1397 };
        static int[] FAs = { 185, 370, 740, 1480 };
        static int[] SOL = { 196, 392, 784, 1568 };
        static int[] SOLs = { 208, 415, 831, 1661 };
        static int[] LA = { 220, 440, 880, 1760 };
        static int[] LAs = { 233, 466, 932, 1865 };
        static int[] SI = { 247, 494, 988, 1976 };
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] loiBaiHat = { "Con", "cò", "bé", "bé", "nó", "đậu", "cành", "tre" };
            foreach (string loi in loiBaiHat)
            {
                Console.Write("{0} ", loi);
            }
            Console.Clear();
            int[] hz = tanSo();
            int[] duration = khoangThoiGian();
            int[] timeBreak = thoiGianCho();

            for (int i = 0; i < loiBaiHat.Length; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (j != loiBaiHat.Length)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(loiBaiHat[j] + " ");
                    }

                }

                for (int z = i + 1; z < loiBaiHat.Length; z++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(loiBaiHat[z] + " ");
                }
                Console.Beep(hz[i], duration[i]);
                Thread.Sleep(timeBreak[i]);
                if (i < loiBaiHat.Length - 1)
                {
                    Console.Clear();
                }
            }

            
            Console.ReadKey();

        }
        static int[] tanSo()
        {
            int[] a = { DO[2], SOL[1], FA[2], FA[2], FA[2], LA[1], DO[2], RE[2] };
            return a;
        }
        static int[] khoangThoiGian()
        {
            int[] a = { 200, 200, 400, 500, 200, 300, 200, 200 };
            return a;
        }
        static int[] thoiGianCho()
        {
            int[] a = { 200, 200, 200, 600, 200, 200, 200, 200 };
            return a;
        }
    }
}
