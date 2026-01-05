using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //같은 데이터 타입의 변수를 쉼표로 구분해 한번에 선언
            int x = 10, y = 20, z = 30; //정수형 x,y,z 선언하고 초기화

            //Console.WriteLine(x);//출력10
            //Console.WriteLine(y);//출력20
            //Console.WriteLine(z);//출력30

            //중괄호 안에 0 넣고 ,나눠서 값 넣으면 중괄호 안에 값이 들어가는 출력방식
            int age = 20;
            Console.WriteLine("나이: {0}", age);//출력: 나이:20

            //대충 보면알겠지만 중괄호 안 숫자 순서대로 변수가 인덱스처럼 들어간다
            string name = "철수";
            Console.WriteLine("이름: {0}, 나이: {1}{0}", name, age);

            //잘 아는거. age는 문자열 변환하지 않는다
            Console.WriteLine($"나이: {age}");
        }
    }
}
