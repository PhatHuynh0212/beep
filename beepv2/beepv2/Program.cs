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
            string[] cau1 = {"Làm", "gì", "có", "ai", "thương", "em", "như", "vậy" };
            int[] tanSo1 = { SOL[2], SOL[2], MI[3], RE[3], DO[3], DO[3], LA[2], SOL[2] };
            int[] khoangThoiGian1 = { 200, 200, 280, 200, 250, 400, 400, 400 };
            int[] thoiGianCho1 = { 120, 80, 80, 80, 120, 300, 300, 300 };

            string[] cau2 = { "Có", "ai", "cần", "em", "đến", "thế" };
            int[] tanSo2 = { MI[3], RE[3], DO[3], RE[3], MI[3], SOL[3] };
            int[] khoangThoiGian2 = { 180, 180, 180, 300, 400, 500 };
            int[] thoiGianCho2 = { 120, 120, 120, 300, 300, 300 };

            string[] cau3 = { "Có", "ai", "chia", "tay", "mà", "vẫn", "mong", "từng", "ngày" };
            int[] tanSo3 = { MI[3], RE[3], DO[3], DO[3], LA[2], MI[3], RE[3], DO[3], DO[3] };
            int[] khoangThoiGian3 = { 150, 150, 150, 150, 160, 220, 120, 120, 120 };
            int[] thoiGianCho3 = { 150, 150, 150, 300, 150, 150, 150, 150, 400 };

            string[] cau4 = { "Mong", "niềm", "vui", "dù", "em", "thuộc", "về", "ai" };
            int[] tanSo4 = { SOL[2], MI[2], FA[2], MI[2], FA[2], MI[2], FA[2], SOL[2] };
            int[] khoangThoiGian4 = { 150, 150, 150, 150, 150, 150, 180, 150 };
            int[] thoiGianCho4 = { 180, 180, 220, 180, 180, 180, 180, 300 };

            Karaoke(cau1, tanSo1, khoangThoiGian1, thoiGianCho1, 0);
            Karaoke(cau2, tanSo2, khoangThoiGian2, thoiGianCho2, 1);
            Karaoke(cau3, tanSo3, khoangThoiGian3, thoiGianCho3, 2);
            Karaoke(cau4, tanSo4, khoangThoiGian4, thoiGianCho4, 3);

            Console.ReadKey();

        }

        static void Karaoke(string[] loiBaiHat, int[] tanSo, int[] khoangThoiGian, int[] thoiGianCho, int dong)
        {
            foreach (string loi in loiBaiHat)
            {
                Console.Write("{0} ", loi);
            }
            int[] hz = tanSo;
            int[] duration = khoangThoiGian;
            int[] timeBreak = thoiGianCho;

            for (int i = 0; i < loiBaiHat.Length; i++)
            {
                int dem = 0;

                for (int z = 0; z <= i; z++)
                {
                    dem += loiBaiHat[z].Length;
                }
                dem += i;

                Console.SetCursorPosition(dem, dong);
                for (int j = 0; j < loiBaiHat[i].Length; j++)
                {
                    Console.Write("\b");
                }
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write(loiBaiHat[i]);
                Console.Beep(hz[i], duration[i]);
                Thread.Sleep(timeBreak[i]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        
    }
}