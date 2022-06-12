using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Deliga
{
    public class Logic
    {
        private readonly Sumer _sumer;
        public Logic()
        {
            _sumer = Sum;
            MyEvent += _sumer;
            MyEvent += _sumer;
        }

        public delegate int Sumer(int x, int y);
        public event Sumer MyEvent;

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public Exception Notification()
        {
            throw new Exception("my program result is: ");
        }

        public int SumResult(Sumer sum, int a, int b, int x, int y)
        {
            int res1 = MyEvent.Invoke(a, b);
            int res2 = MyEvent.Invoke(x, y);
            res1 = res1 + res2;
            TryCatcher(Notification);
            return res1;
        }

        public void TryCatcher(Func<Exception> a)
        {
            try
            {
                a.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
