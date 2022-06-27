using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수 입력하세요?");
            string kor = Console.ReadLine();
            //int kor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수 입력하세요?");
            string eng = Console.ReadLine();
            //int eng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수 입력하세요?");
            string mat = Console.ReadLine();
            //int mat = int.Parse(Console.ReadLine());
            Console.Write("과학 점수 입력하세요?");
            string sci = Console.ReadLine();
            //int sci = int.Parse(Console.ReadLine());

            int koNum = int.Parse(kor);
            int enNum = int.Parse(eng);
            int maNum = int.Parse(mat);
            int scNum = int.Parse(sci);

            int sum = koNum + enNum + maNum + scNum;
            float avg = sum / 4;
            //float avg = sum /4f;

            Console.WriteLine("국어 : {0} 영어 : {1} 수학 : {2}   과학 : {3}",kor,eng,mat,sci);
            Console.WriteLine("총점 : {0}    평균 : {1}",sum,string.Format("{0:0.0}",avg));
        }
    }
}
