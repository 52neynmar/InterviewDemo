using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    public class FoodSimpleFactory
    {

    }

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

    public class FoodFactory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            switch(type)
            {
                case "土豆肉丝":
                    food = new Meat();
                    break;
                case "西红柿炒蛋":
                    food = new TomatoEgg();
                    break;
            }
            return food;
        }
    }
}
