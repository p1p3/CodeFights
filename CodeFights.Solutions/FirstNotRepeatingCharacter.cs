using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/* Note: Write a solution that only iterates over the string once and uses O(1) additional memory, since this is what you would be asked to do during a real interview.

Given a string s, find and return the first instance of a non-repeating character in it. If there is no such character, return '_'.

Example

For s = "abacabad", the output should be
firstNotRepeatingCharacter(s) = 'c'.

There are 2 non-repeating characters in the string: 'c' and 'd'. Return c since it appears in the string first.

For s = "abacabaabacaba", the output should be
firstNotRepeatingCharacter(s) = '_'.

There are no characters in this string that do not repeat.*/

namespace CodeFights.Solutions
{
    public static class FirstNotRepeatingCharacter
    {
        public static char firstNotRepeatingCharacter(string s)
        {
            var chars = s.ToCharArray();

            var groupedChars = chars.GroupBy(c => c);
            var notRepeated = groupedChars.Where(group => group.Count() == 1).ToList();

            return notRepeated.Any() ? Convert.ToChar(notRepeated.First().Key) : '_';
        }
    }
}
