using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoverage
{
    public class Class1
    {
        public Class1()
        {

        }

        public int Method1(bool x, string s)
        {
            if (x && s == "foo")
            {
                Bar();
                return 0;
            }

            if (!x && s == "foo")
            {
                return 111;
            }

            if (x)
            {
                var a = 1;
                var b = s == "bar" ? 2 : 3;
                if (b == 2)
                {
                    return a + 1;
                }
                if (b == 2 && a == 0)
                {
                    return 222;
                }
            }
            return 3;
        }

        private void Bar()
        {
            Console.WriteLine("here");
        }
    }
}
