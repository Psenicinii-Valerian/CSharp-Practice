using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_functiilor
{
    internal class Gamer
    {  
        public static void showClass()
        {
            Console.WriteLine("I'm the Gamer Class");
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int variable;

        public void showGamer()
        {
            Console.WriteLine("Gamer");
        }

        public void showGamer(string nickname)
        {
            Console.WriteLine($"Gamer's nickname: {nickname}");
        }

        public void showGamer(string nickname, string game)
        {
            Console.WriteLine($"Nickname: {nickname} \nGame: {game}");
        }

        public void a(int a, string b)
        {
            Console.WriteLine($"{a} {b}");
        }

        public void a(string b, int a)
        {
            Console.WriteLine($"{b} {a}");
        }

    }
}
