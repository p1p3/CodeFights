using System.Collections.Generic;
using System.Linq;

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
