using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC
{
    public interface ITestServiceA
    {
        void Test();
    }
	//方法TestServiceA 一
    public class TestServiceA : ITestServiceA
    {
        public void Test()
        {
            Console.WriteLine("123");
        }
    }

    public class TestServiceB : ITestServiceA
    {
        public void Test()
        {
            Console.WriteLine("456");
        }
    }
}
