using DemoClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoClass.FoodFactory2;

namespace interViewDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Creater create1 = new TomatoEggFactory();
                create1.CreateFactory().print();
            }
            {
                //简单工厂
                //Food food1 = FoodFactory.CreateFood("土豆肉丝");
                //food1.print();
            }
            {
                //冒泡排序
                //int[] dataArray = new int[] { 4, 5, 2, 1, 3 };
                //BubbleSort2(dataArray);
            }
            Console.ReadLine();
        }

        public static void BubbleSort(int[] dataArray)
        {
            int temp;
            for (int i = 0; i < dataArray.Length - 1; i++)
            {
                for (int j = 1; j < dataArray.Length - i; j++)
                {
                    int x = dataArray[j - 1];
                    int y = dataArray[j];
                    if (x > y)
                    {
                        temp = dataArray[j - 1];
                        dataArray[j - 1] = dataArray[j];
                        dataArray[j] = temp;
                    }
                }
                //打印数据
                string Str = string.Empty;
                for (int n = 0; n < dataArray.Length; n++)
                {
                    Str += dataArray[n] +"-";  
                }
                Console.WriteLine($"第{i}次的调整顺序是：{Str.Trim('-')}");
            }
            Console.WriteLine($"---------------------------------");
            //打印数据
            string newStr = string.Empty;
            for (int m = 0; m < dataArray.Length; m++)
            {
                newStr += dataArray[m] + "-";
            }
            Console.WriteLine($"最后的调整顺序是：{newStr.Trim('-')}");
        }
        public static void BubbleSort2(int[] dataArray)
        {
            //4,5,2,1,3
            for (int i = 0; i < dataArray.Length; i++)
            {
                for (int j = i + 1; j < dataArray.Length; j++)
                {
                    int x = dataArray[i];
                    int y = dataArray[j];
                    if (x > y)
                    {
                        int temp = dataArray[i];
                        dataArray[i] = dataArray[j];
                        dataArray[j] = temp;
                    }
                }

                //打印数据
                string Str = string.Empty;
                for (int n = 0; n < dataArray.Length; n++)
                {
                    Str += dataArray[n] + "-";
                }
                Console.WriteLine($"第{i}次的调整顺序是：{Str.Trim('-')}");
            }

            Console.WriteLine($"---------------------------------");
            //打印数据
            string newStr = string.Empty;
            for (int m = 0; m < dataArray.Length; m++)
            {
                newStr += dataArray[m] + "-";
            }
            Console.WriteLine($"最后的调整顺序是：{newStr.Trim('-')}");
        }
    }
}
