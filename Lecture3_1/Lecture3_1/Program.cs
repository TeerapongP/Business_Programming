using System;

namespace Lecture3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int number_student = 4;
            int [] total_score = new int [number_student];

            //Output
            Console.Write("Press any follwing key");
            Console.ReadLine();

            Console.Write("Enter Total Students : ");
            number_student = int.Parse(Console.ReadLine());

            string[,] student_report = new string[number_student, 4];//abbreviated loop
            
            //Loop for
            for (int i = 0; i < number_student; i++)
            {
                Console.Write("Enter Student Name : ");
                student_report[i, 0] = Console.ReadLine();

                Console.Write("Enter English Marks (Out Of 100) : ");
                student_report[i, 1] = Console.ReadLine();

                Console.Write("Enter Math Marks (Out Of 100) : ");
                student_report[i, 2] = Console.ReadLine();

                Console.Write("Enter Computer Marks (Out Of 100) : ");
                student_report[i, 3] = Console.ReadLine();

            }
            //หาคะเเนนรวม

            for (int i = 0; i < number_student; i++)
            {
                
                for(int j = 1; j < 4; j++)
                {
                    total_score[i] += int.Parse(student_report[i, j]);
                }
                //Output

                Console.WriteLine("\n****************Report Card*******************");
                Console.WriteLine("\n****************************************");
                Console.WriteLine("Student Name: {0}, Position: {1}, Total: {2}/300", student_report[i, 0],i+1, total_score[i]);
                Console.WriteLine("\n****************************************");
            }
            Console.ReadLine();
        }
    }
}
