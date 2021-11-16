using System;
using System.Collections;
using System.IO;

namespace Lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers from 0 to 255 separated by space and press ENTER:");
            string entry = Console.ReadLine();
            string[] t = entry.Split(' ');
            ArrayList tempList = new ArrayList();
            for (int j = 0; j < t.Length; j++)
            {
                byte number;
                if (byte.TryParse(t[j], out number))
                {
                    tempList.Add(number);
                }
            }

            byte[] array = new byte[tempList.Count];
            for (int i = 0; i < tempList.Count; i++)
            {
                array[i] = (byte)tempList[i];
            }
            File.WriteAllBytes("bytes.bin", array);

        }
    }
}
