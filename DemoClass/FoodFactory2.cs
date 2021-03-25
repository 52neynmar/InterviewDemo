using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    public class FoodFactory2
    {
        public abstract class Food
        {
            public abstract void print();
        }

        public class TomatoEgg : Food
        {
            public override void print()
            {
                Console.WriteLine($"当前饭菜是：西红柿炒鸡蛋！");
            }
        }

        public class Meat : Food
        {
            public override void print()
            {
                Console.WriteLine($"当前饭菜是：土豆肉丝！");
            }
        }

        public abstract class Creater
        {
            public abstract Food CreateFactory();
        }

        public class TomatoEggFactory:Creater
        {
            public override Food CreateFactory()
            {
                return new TomatoEgg();
            }
        }

        public  class MeatFactory : Creater
        {
            public override Food CreateFactory()
            {
                return new Meat();
            }
        }
    }
}
