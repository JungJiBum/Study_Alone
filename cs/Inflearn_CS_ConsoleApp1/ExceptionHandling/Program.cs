using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //오류가 발생할것 같거나 가능성이 높거나 중요한 코드일 경우 try 안에 기입
                int[] asd = { 1, 2, 3, 4 };

                throw new Exception();
                Console.WriteLine(asd[6]);
            }
            catch (IndexOutOfRangeException e)
            {
                //오류 발생시 catch문 실행
                Console.WriteLine("오류 발생 했을때 실행되는 영역2");
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                //오류 발생시 catch문 실행
                Console.WriteLine("오류 발생 했을때 실행되는 영역");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("오류가 발생하거나, 발생하지않아도 실행 되는 영역");
                Console.WriteLine("오류가 발생하거나, 발생하지않아도 실행 되는 영역");
            }
        }

        void test()
        {

        }
    }
}
