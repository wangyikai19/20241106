using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _20241106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\我是胖虎.txt";
            //string song = "我是胖虎";
            //File.WriteAllText(path, song);
            //Console.ReadKey();

            //string path2 = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\1.txt";
            //string input=File.ReadAllText(path2);
            //Console.WriteLine(input);
            //Console.ReadKey();

            //string path3 = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\99.txt";
            //string input = "";
            //for (int i = 1; i <= 9; i = i + 3)
            //{
            //    for (int j = 1; j <=9; j++)
            //    {
            //        for(int k = i; k <i+3;k++)
            //        {
            //            input = ($"{k:##}*{j:##}={k * j:##}\t");
            //            File.AppendAllText(path3, input);
            //        }
            //    }
            //}
            //File.AppendAllText(path3, input);
            //Console.ReadKey();

            //string path = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\1.txt";
            //string input = File.ReadAllText(path);
            //input = input.Replace("1", "壹");
            //input = input.Replace("2", "貳");
            //input = input.Replace("3", "參");
            //input = input.Replace("4", "肆");
            //input = input.Replace("5", "伍");
            //input = input.Replace("6", "陸");
            //input = input.Replace("7", "柒");
            //input = input.Replace("8", "捌");
            //input = input.Replace("9", "玖");
            //string path2 = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\1toChinese.txt";
            //File.WriteAllText(path2, input);
            //Console.ReadKey();

            //Random rom = new Random();
            //int i = rom.Next(0, 99);
            //Console.WriteLine(i);
            //Console.ReadKey();

            //Random rom = new Random();
            //int num;
            //for (int i = 1; i <= 10; i++)
            //{
            //    num = rom.Next(0, 99);
            //    Console.WriteLine(num);
            //}
            //Console.ReadKey();

            //Random rom = new Random();
            //int num;
            //List<string> score=new List<string>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    num = rom.Next(0, 99);
            //    score.Add(num + "，");

            //}

            //string path = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\score.txt";
            //File.WriteAllLines(path, score);
            //Console.ReadKey();

            //Random rom = new Random();
            //string bingo = "";
            //for(int i = 1; i <= 7; i++)
            //{
            //    int num = rom.Next(1, 42);
            //    bingo += num.ToString() + ",";
            //}
            //bingo = bingo + "特別號" + rom.Next(1, 7);
            //Console.WriteLine(bingo);
            //Console.ReadKey();

            //string path = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\餐廳.txt";
            //string input = File.ReadAllText(path);
            //string[] inputToArray = input.Split('，');
            //Random rest= new Random();
            //int restIndex = rest.Next(inputToArray.Length-1);
            //Console.WriteLine(inputToArray[restIndex]);
            //Console.ReadKey();

            //string path = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\student.txt";
            //string path2 = @"C:\Users\HP\Desktop\火箭隊-backend\20241106\20241106\files\selectedStudent.txt";
            //string[] allStudents = File.ReadAllText(path).Split('，');
            //string[] selectedStudents = File.ReadAllText(path2).Split('，');
            //if (allStudents.Length == selectedStudents.Length)
            //{
            //    File.WriteAllText(path2,"");
            //}
            //Random random = new Random();
            //int num = random.Next(allStudents.Length - 1);
            //string selectedStudent= allStudents[num];
            //File.AppendAllText(path2, selectedStudent+"，");
            //Console.WriteLine("今天的值日生是：" + selectedStudent);
            //Console.ReadKey();

            //Console.WriteLine(DateTime.Now.ToString());
            //Console.ReadKey();
            //Console.WriteLine(DateTime.Now.AddDays(30).ToString("yyyy/MM/dd"));
            //Console.ReadKey();
            //Console.WriteLine(DateTime.Now.AddHours(-24).ToString());
            //Console.ReadKey();
            //Console.WriteLine(DateTime.Now.Month.ToString());
            //Console.ReadKey();
            //int nextYear=  DateTime.Now.Year+1;
            //bool isLeapYear = DateTime.IsLeapYear(nextYear);
            //Console.WriteLine($"{nextYear} 年是否為閏年：{isLeapYear}");
            //Console.ReadKey();
            //DateTime today = DateTime.Today;
            //DateTime thatDate = new DateTime(2025, 1, 1);
            //int next = (int)(thatDate - today).TotalDays;
            //Console.WriteLine($"今天是{today:yyyy年MM月dd日}，距離2025/1/1還有{next}天");
            //Console.ReadKey();
            //DayOfWeek today = DateTime.Today.DayOfWeek;
            //switch (today)
            //{
            //    case DayOfWeek.Monday:
            //        Console.WriteLine("星期一，猴子穿新衣");
            //        break;
            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine("星期二，猴子肚子餓");
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine("星期三，猴子去爬山");
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine("星期四，猴子看電視");
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("星期五，猴子去跳舞");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("星期六，猴子去斗六");
            //        break;
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("星期日，猴子過生日");
            //        break;
            //}
            //Console.ReadKey();
            //Console.WriteLine("請輸入第一個日期");
            //DateTime one= Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("請輸入第二個日期");
            //DateTime two = Convert.ToDateTime(Console.ReadLine());
            //int next = (int)(two - one).TotalDays;
            //Console.WriteLine($"{one:yyyy年MM月dd日}，距離{two:yyyy年MM月dd日}還有{next}天");
            //Console.ReadKey();
            Random random = new Random();
            int year = DateTime.Now.Year; 
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            int s = (month * 2 + day) % 3;
            Console.WriteLine($"{year}年{month}月{day}日");
            switch (s)
            {
                case 0:
                    Console.WriteLine("普通");
                    break;
                case 1:
                    Console.WriteLine("吉");
                    break;
                case 2:
                    Console.WriteLine("大吉");
                    break;
            }
            Console.ReadKey();
        }
    }
}
