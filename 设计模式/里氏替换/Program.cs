using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏替换
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Func();
            a.VirtualFunc();
            B a1 = new B();
            a1.Func();
        }
    }
    public class A
    {
        public void Func()
        {
            Console.WriteLine("A");
        }
        public virtual void VirtualFunc()
        {
            Console.WriteLine("虚方法A");
        }
    }
    public class B : A
    {
        /// <summary>
        /// 覆盖不会改变父类的行为
        /// </summary>
        public new void Func()
        {
            Console.WriteLine("B");
        }
        public override void VirtualFunc()
        {
            Console.WriteLine("虚方法B");
        }
    }
}
