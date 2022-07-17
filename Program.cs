using System;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_11
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string glasnie = "аоэеиыуёюяAEIOUY";
            string soglasnie = "бпвфгкдтзсжшлмнрйцхчщBCDFGHJKLMNPQRSTVWXZ";

            Console.WriteLine("Введите текст:");
            string stroka = Console.ReadLine();

            Console.WriteLine($"Всего гласных: {await GlasieAsunc(stroka, glasnie)} {"\n"}Всего согласных {await SoGlasieAsunc(stroka, soglasnie)} ");
        }

        public static int Count(string stroka, string symbl)
        {
            int count = 0;
            foreach (char strokaC in stroka.ToLower())
            {
                foreach (char C in symbl.ToLower())
                {
                    if (strokaC == C)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int Glasnie(string stroka, string glasnie)
        {
            return Count(stroka, glasnie);
        }

        public static int SoGlasnie(string stroka, string soglasnie)
        {
            return Count(stroka, soglasnie);
        }

        public static Task<int> GlasieAsunc(string stroka, string glasnie)
        {
            return Task.Run(()=>(Glasnie(stroka, glasnie)));
        }

        public static Task<int> SoGlasieAsunc(string stroka, string soglasnie)
        {
            return Task.Run(() => (SoGlasnie(stroka, soglasnie)));
        }
    }
}
