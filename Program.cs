using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        /// <summary>
        /// Метод, который соберет всех учеников всех классов в один список, используя LINQ
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudents = from c in classes.ToList<Classroom>() from s in c.Students orderby s select s;
            return allStudents.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}