using System;

namespace Private__Protected_and_Public
{
    public class BaseClass
    {
        protected int id = 100;
    }

    public class DerivedClass : BaseClass
    {
        public void DerivedClassMethod()
        {
            DerivedClass dc = new DerivedClass();
            dc.id = 200;
            base.id = 300;
            this.id = 400;
            //BaseClass bc = new BaseClass();
            //bc.id = 9;
        }
    }
    class Program : DerivedClass
    {
        static void Main(string[] args)
        {
            Program bc1 = new Program();
        }
    }
}
