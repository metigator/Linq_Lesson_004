using LINQTut04.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut04.SELECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();
            RunExample03();
            Console.ReadKey();
        }

        private static void RunExample01()
        {
            // string[] words01 = { "I", "love", "asp.net", "core" };

            List<string> words = new() { "i", "love", "asp.net", "core" };

            //var result01 = words.Select(x => { return x;});
            var result = words.Select(x => x.ToUpper());
            // using query syntax
            //var result02 = from word in words
            //               select word.ToUpper();

            foreach (var word in result)
                Console.WriteLine(word);

        }

        private static void RunExample02()
        {

            List<int> numbers = new() { 2, 3, 5, 7 };

            //var result01 = words.Select(x => { return x;});
            var result = numbers.Select(x => x * x);

            // using query syntax
            //var result02 = from n in numbers
            //               select n * n;

            foreach (var n in result)
                Console.WriteLine(n);

        }

        private static void RunExample03()
        {
            var employees = Repository.LoadEmployees();


            var result = employees.Select(x => {
                return new EmployeeDto
                {
                    Name = $"{x.FirstName} {x.LastName}",
                    TotalSkills = x.Skills.Count() 
                };
            });
            // using query syntax
            //var result02 = from n in numbers
            //               select n * n;

            foreach (var n in result)
                Console.WriteLine(n);

        }
    } 
}   

