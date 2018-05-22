using System.Collections.Generic;
using System.Linq;

/*
 Given an array a that contains only numbers in the range from 1 to a.length, find the first duplicate number for which the second occurrence has the minimal index. In other words, if there are more than 1 duplicated numbers, return the number for which the second occurrence has a smaller index than the second occurrence of the other number does. If there are no such elements, return -1.
   
   Example
   
   For a = [2, 1, 3, 5, 3, 2], the output should be
   firstDuplicate(a) = 3.
   
   There are 2 duplicates: numbers 2 and 3. The second occurrence of 3 has a smaller index than the second occurrence of 2 does, so the answer is 3.
   
   For a = [2, 4, 3, 5, 1], the output should be
   firstDuplicate(a) = -1.
 */
namespace CodeFights.Solutions
{
    public class FirstDuplicate
    {
        public static int firstDuplicate(int[] a)
        {
            var ocurrences = new Dictionary<int, Duplicate>();

            for (var index = 0; index < a.Length; index++)
            {
                var number = a[index];
                var exist = ocurrences.ContainsKey(number);

                if (exist)
                {
                    var ocurrence = ocurrences[number];
                    ocurrence.Indexes.Add(index);
                }
                else
                {
                    var ocurrence = new Duplicate() { Indexes = { index }, Number = number };
                    ocurrences.Add(number, ocurrence);
                }
            }

            var duplicates = ocurrences.Where(ocurrence => ocurrence.Value.Ocurrences > 1).ToList();
            var duplicatesOrderedByIndex = duplicates.OrderBy(duplicate => duplicate.Value.Indexes[1]).ToList();

            if (!duplicatesOrderedByIndex.Any()) return -1;

            return duplicatesOrderedByIndex.First().Value.Number;
        }

        public class Duplicate
        {
            public Duplicate()
            {
                Indexes = new List<int>();
            }

            public IList<int> Indexes { get; set; }
            public int Ocurrences => Indexes.Count;
            public int Number { get; set; }
        }
    }
}
