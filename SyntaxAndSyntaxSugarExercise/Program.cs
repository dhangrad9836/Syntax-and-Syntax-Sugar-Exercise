﻿namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int answer = 4;
            var answer = 4;
            //string response;
            var response = (answer < 9) ? $"{answer} is less than nine" : 
                $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);


            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}
            Console.ReadLine();
        }
        
    }
}
