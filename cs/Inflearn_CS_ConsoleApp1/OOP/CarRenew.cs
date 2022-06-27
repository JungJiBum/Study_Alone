using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //자식클래스, 서브클래스
    class CarRenew : Car
    {
        //코드가 존재하는것마냥 부모의 클래스(Car)를 사용할 수 있음
        public void getA()
        {
            Console.WriteLine(a);
        }
    }
}
