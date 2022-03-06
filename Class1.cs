using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class Class1 : Interface1
    {
        private double _myProterty;
        public double MyProperty { 
            get { return _myProterty * 1.23; }
            set { _myProterty = value; }
        }

        public int Zmienna { get; set; }

        public virtual void func()
        {

        }

    }
}
