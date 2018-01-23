using System;

namespace Tik.Travis.Lib
{
    public class Sample
    {
        public Sample()
        {

        }

        public int Plus(int a, int b){
            return a + b;
        }

        public int Plus(int? a, int? b)
        {
            return a + b;
        }
    }
}
