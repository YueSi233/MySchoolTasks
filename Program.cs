using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            int x = 0;
            Console.WriteLine("请输入学生的成绩并以逗号隔开：");
            string str = Console.ReadLine();
            string[] result = str.Split(',');
            float[] chengJi = new float[result.Length];
            for (int i = 0; i < chengJi.Length; i++)
            {
                chengJi[i] = Convert.ToSingle(result[i]);
            }
            a = chengJi.Average();
            for (int i = 0; i < chengJi.Length; i++)
            {
                if (chengJi[i] > a)
                {
                    x++;
                }
            }
            Console.WriteLine("最高成绩：{0}，最低成绩：{1}，高于平均成绩人数：{2}", chengJi.Max(), chengJi.Min(), x);
            Console.ReadKey();
        }
    }
}
