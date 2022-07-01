using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            base.quackBehavior = new Quack();
            base.flyBehavior = new FlyWithWings();
        }

        public void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}
