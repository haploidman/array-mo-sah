using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        public class Operations
        {
            int[] nums = new int[5];
            public void InputNums()
            {
                Console.WriteLine("Insert 5 numbers:");
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"{i}. ");
                    nums[i - 1] = int.Parse(Console.ReadLine());
                }
            }

            public void DisplayNums()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"{i}. {nums[i - 1]}");
                }
            }

            public void Trav()
            {


                DisplayNums();
            }

            public void Insert()
            {

                int size = 0;

                Console.Write("Insert element number to truncate to: ");
                int position = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Insert new number: ");
                int insertMe = int.Parse(Console.ReadLine());


                size = nums.Length;


                int[] nums2 = new int[size + 1];

                for (int i = 0; i < nums2.Length; i++)
                {
                    if (i < position) nums2[i] = nums[i];
                    else if (i == position) nums2[i] = insertMe;
                    else nums2[i] = nums[i - 1];
                }

                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine($"{i}. {nums2[i - 1]}");
                }

            }

            public void Delete()
            {

                Console.Write("Insert element number to delete: ");
                int DeletePos = int.Parse(Console.ReadLine()) - 1;

                int[] nums2 = new int[nums.Length - 1];

                for (int i = 0; i < nums2.Length; i++)
                {
                    if (i < DeletePos) nums2[i] = nums[i];
                    else nums2[i] = nums[i + 1];
                }

                for (int i = 0; i < nums2.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {nums2[i]}");
                }
            }

            public void Search()
            {

                int count = 0;

                Console.Write("Input an element you are looking for: ");
                int SFM = int.Parse(Console.ReadLine());

                for (int i = 1; i <= nums.Length; i++)
                {
                    if (nums[i - 1] == SFM) count++;
                }

                if (count > 0) Console.WriteLine($"I found {count} instances of '{SFM}'(s)!");
                else Console.WriteLine($"'{SFM}' not found!");
            }

            public void Update()
            {

                Console.Write("Insert element number to be replaced: ");
                int position = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Insert new number: ");
                int insertMe = int.Parse(Console.ReadLine());

                nums[position] = insertMe;

                DisplayNums();

            }
        }
        static void Main(string[] args)
        {
            Operations op1 = new Operations();
            op1.InputNums();
            Console.Write(
                "\nAvailable Operations:\n[a] - Traverse \n[b] - Update \n[c] - Insert \n[d] - Search \n[e] - Delete\n\nSelect your operation: ");
            char option = char.Parse(Console.ReadLine());

            switch (option)
            {
                case 'a':
                    op1.Trav();
                    break;
                case 'b':
                    op1.Update();
                    break;
                case 'c':
                    op1.Insert();
                    break;
                case 'd':
                    op1.Search();
                    break;
                case 'e':
                    op1.Delete();
                    break;
            }
            Console.WriteLine("\n\n");

        }
    }
}
