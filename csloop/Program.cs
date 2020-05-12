using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csloop
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }
            Console.WriteLine(count+"번 반복됨");

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
            while(true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료):");
                int input = int.Parse(Console.ReadLine());
                if(input%2==0)
                {
                    break;
                }
            }

            for(int i=1;i<10;i++)
            {
                if(i%2!=0)
                {
                    continue;
                }Console.WriteLine(i);
            }
            String input = "Potato Tomato";
            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());

            String input2 = "감자 고구마 토마토";
            String[] inputs=input2.Split(new char[] { ' ' });
            foreach(var item in inputs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(input2.Trim());

            Console.WriteLine(string.Join(",", inputs));
        }
    }
}
