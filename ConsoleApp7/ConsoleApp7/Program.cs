using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////상수 : 값을 변경할 수 없는 변수. 초기화 할 때 값을 넣을 수 있다.
            //const double Pi = 3.14;
            //const int Maxscore = 100;



            ////출력
            //Console.WriteLine("Pi: " + Pi);
            //Console.WriteLine("Max Score: " + Maxscore);


            const int maxPlayer = 4;
            const int startCoin = 1000;
            const string ver = "1.0.0";
            Console.WriteLine("** 실행 결과**");
            Console.WriteLine("' ' '");
            Console.WriteLine("=== 게임 설정 ===");
            Console.WriteLine("최대 플레이어: " + maxPlayer + "명");
            Console.WriteLine("시작 골드: "+startCoin+"G");
            Console.WriteLine("버전 " + ver);
            Console.WriteLine("' ' '");



        }
    }
}
