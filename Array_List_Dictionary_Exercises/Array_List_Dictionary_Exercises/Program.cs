using System;
using System.Collections.Generic;

namespace Array_List_Dictionary_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise37();
            //Exercise40();
            //Exercise50();
        }

        static void Exercise37()
        {
            int[] nums = new int[5];
            int sum = 0;
            Console.WriteLine("Please enter five numbers.");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = int.Parse(Console.ReadLine());

                sum += nums[i];
            }

            Console.WriteLine($"The sum of all of your numbers is {sum}.");

            Console.WriteLine("Would you like to continue? Y/N");
            string repCheck = Console.ReadLine().ToLower();

            if (repCheck == "y")
            {
                Exercise37();
            }
            else if (repCheck == "n")
            {
                Console.WriteLine("Goodbye!");
            }

        }

        static void Exercise40()
        {
            Console.WriteLine("Please enter five numbers.");
            List<int> nums = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                nums.Add(int.Parse(Console.ReadLine()));
            }

            nums.Sort();

            //Console.WriteLine($"The median of ({nums[0]}, {nums[1]}, {nums[2]}, {nums[3]}, {nums[4]}) is {nums[2]}.");

            //trying to do the same thing without hard coding the index for each element of the list
            int median = nums.Count / 2;

            Console.Write("The median of (");
            for (int i = 0; i < nums.Count - 1; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.Write(nums[nums.Count - 1] + ") is " + nums[median]);

            Console.WriteLine();
            Console.WriteLine("Would you like to continue? Y/N");

            string repCheck = Console.ReadLine().ToLower();

            if (repCheck == "y")
            {
                Exercise40();
            }
            else if (repCheck == "n")
            {
                Console.WriteLine("Goodbye!");
            }
        }

        static void Exercise50()
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            students.Add("Jack", 34);
            students.Add("Allison", 28);
            students.Add("Farha", 46);
            students.Add("Mason", 28);
            students.Add("Melinda", 23);
            students.Add("Yvette", 19);
            students.Add("Stephen", 37);
            students.Add("Johann", 44);
            students.Add("Freddy", 25);
            students.Add("Nancy", 30);

            Console.WriteLine("Please enter a student name.");
            string input = Console.ReadLine();

            foreach(KeyValuePair<string, int> student in students)
            {
                if (students.ContainsKey(input))
                {
                    Console.WriteLine($"{input} is {students[input]} years old.");
                    break; //couldn't figure out how to keep the loop from repeating the same output over and over without explicitly coding a break
                }
                else
                {
                    Console.WriteLine($"{input} is not a student here.");
                    break;
                }
            }

            Console.WriteLine("Would you like to continue? Y/N");

            string repCheck = Console.ReadLine().ToLower();

            if (repCheck == "y")
            {
                Exercise50();
            }
            else if (repCheck == "n")
            {
                Console.WriteLine("Goodbye!");
            }
        }

    }
}
